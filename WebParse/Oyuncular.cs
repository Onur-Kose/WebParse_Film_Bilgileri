using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebParse.Data;
using WebParse.Models;

namespace WebParse
{
    public partial class Oyuncular : Form
    {
        MovieDbContext db = new MovieDbContext();
        public Oyuncular()
        {
            InitializeComponent();
            OyuncularıListele();
            
        }

        public void OyuncularıListele()
        {
            foreach (Oyuncu oyuncu in db.Oyuncular.Include(oyuncu => oyuncu.IletisimBilgisi))
            {

                if (oyuncu.IletisimBilgisi != null)
                {
                    dvg_oyuncular.Rows.Add(oyuncu.Id, oyuncu.AdSoyAd, oyuncu.IletisimBilgisi.TelefonNo, oyuncu.IletisimBilgisi.Adres);
                }
                else
                {
                    dvg_oyuncular.Rows.Add(oyuncu.Id, oyuncu.AdSoyAd, "Adresi Yok", "Telefonu Yok");
                }
            }
        }

        private void Oyuncular_Load(object sender, EventArgs e)
        {
            
        }

        private void dvg_oyuncular_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OyuncuEkleForm frm = new OyuncuEkleForm();
            frm.ShowDialog();
        }

        private void btn_oyuncuSil_Click(object sender, EventArgs e)
        {
            int deneme = (int)dvg_oyuncular.SelectedRows[0].Cells[0].Value;
            var query = db.Oyuncular.Where(x => x.Id == deneme).FirstOrDefault();
            db.Oyuncular.Remove(query);
            db.SaveChanges();
            OyuncularıListele();
        }
    }
}
