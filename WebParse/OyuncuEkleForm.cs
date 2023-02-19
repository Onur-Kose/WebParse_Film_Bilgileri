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
    public partial class OyuncuEkleForm : Form
    {
        public OyuncuEkleForm()
        {
            InitializeComponent();
        }
        MovieDbContext db = new MovieDbContext();
        private void btn_oyuncuEkle_Click(object sender, EventArgs e)
        {
            //gerekli alanlar boş değilse bir oyuncu oluşturacak ve db ye kaydedilecek
            if (!string.IsNullOrEmpty(txtOyuncuAdres.Text) && !string.IsNullOrEmpty(txtOyuncuAdSoyad.Text) && !string.IsNullOrEmpty(txtOyuncuTelefon.Text))
            {
                db.Oyuncular.Add(new Oyuncu()
                {
                    AdSoyAd = txtOyuncuAdSoyad.Text,
                    IletisimBilgisi = new IletisimBilgisi()
                    {
                        Adres = txtOyuncuAdres.Text,
                        TelefonNo = txtOyuncuTelefon.Text
                    }
                });
                db.SaveChanges();
                Oyuncular frm = new Oyuncular();
                frm.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Eksik Bilgi Kayıt Edilemez");
            }
        }
    }
}
