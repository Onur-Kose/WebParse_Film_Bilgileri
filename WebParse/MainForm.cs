using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Security.Cryptography.X509Certificates;
using WebParse.Data;
using WebParse.Models;

namespace WebParse
{
    public partial class MainForm : Form
    {
        MovieDbContext db = new MovieDbContext();
        public MainForm()
        {
            //Onur Son Proje
            //proje ilk açýldýðýnda data grid viev dolu larak gelsin
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            CmbDoldur();
            FilmleriYukle();
            dvg_Filmler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pbx_Poster.ImageLocation = (string)dvg_Filmler.SelectedRows[0].Cells[6].Value;
            



        }

        private void FilmleriYukle()
        {
            
            dvg_Filmler.Rows.Clear();
            foreach (var item in db.Filmler.Include(film => film.Oyuncular).Include(film => film.Tur))
            {
                var oyuncular = string.Join(',', item.Oyuncular.Select(oyuncu => oyuncu.AdSoyAd));
                string tur = item.Tur.Ad;
                
                dvg_Filmler.Rows.Add(item.ID, item.Ad, item.Yýl, item.imdbPuaný, item.imdbId, oyuncular,item.Poster,tur);
            }
        }
        private void FilmleriYukle(string deger)
        {

            dvg_Filmler.Rows.Clear();
            foreach (var item in db.Filmler.Include(film => film.Oyuncular).Include(film => film.Tur).Where(x => x.Tur.Ad.Contains(deger)))
            {
                var oyuncular = string.Join(',', item.Oyuncular.Select(oyuncu => oyuncu.AdSoyAd));
                string tur = item.Tur.Ad;

                dvg_Filmler.Rows.Add(item.ID, item.Ad, item.Yýl, item.imdbPuaný, item.imdbId, oyuncular, item.Poster, tur);
            }
        }

        private void dvg_Filmler_SelectionChanged(object sender, EventArgs e)
        {
            if (dvg_Filmler.SelectedRows.Count > 0)
            {
                pbx_Poster.ImageLocation = (string)dvg_Filmler.SelectedRows[0].Cells[6].Value;
            }
            
        }

        private void txt_FilmBul_TextChanged(object sender, EventArgs e)
        {
            string deger = txt_FilmBul.Text;
            FilmleriYukle(deger);
        }
        private void CmbDoldur()
        {
            cmb_FilmBul.Items.Add("Bütün Türler");
            List<Tur> turAdlari = db.Turler.ToList();
            turAdlari.ForEach(tur => cmb_FilmBul.Items.Add(tur.Ad));


            //foreach (var item in db.Turler)
            //{
            //    cmb_FilmBul.Items.Add(item.Ad);
            //}
            cmb_FilmBul.SelectedIndex = 0;
        }


        private void cmb_FilmBul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_FilmBul.SelectedIndex == 0)
            {
                FilmleriYukle();
            }
            else
            {
                dvg_Filmler.Rows.Clear();
                foreach (var item in db.Filmler.Where(tur => tur.Tur.Ad == (string)cmb_FilmBul.SelectedItem).ToList())
                {
                    var oyuncular = string.Join(',', item.Oyuncular.Select(oyuncu => oyuncu.AdSoyAd));
                    string tur = item.Tur.Ad;

                    dvg_Filmler.Rows.Add(item.ID, item.Ad, item.Poster, item.Yýl, item.imdbPuaný, item.imdbId, tur, oyuncular);
                }
                //foreach (var item in db.Filmler.Where(tur => tur.Tur.Id == cmb_FilmBul.SelectedIndex).ToList())
                //{
                //    var oyuncular = string.Join(',', item.Oyuncular.Select(oyuncu => oyuncu.AdSoyAd));
                //    string tur = item.Tur.Ad;

                //    dvg_Filmler.Rows.Add(item.ID, item.Ad, item.Poster, item.Yýl, item.imdbPuaný, item.imdbId, tur, oyuncular);
                //}
            }

        }

        private void filmlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oyuncular frm = new Oyuncular();
            frm.Show();
        }

        private void oyuncuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OyuncuEkleForm frm = new OyuncuEkleForm();
            frm.Show();
        }

        private void türlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurlerForm frm = new TurlerForm();
            frm.Show();
        }

        private void fimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmEkle frmEkle = new FilmEkle();
            frmEkle.Show();
        }
    }
}