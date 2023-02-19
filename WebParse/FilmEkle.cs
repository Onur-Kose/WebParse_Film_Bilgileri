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
    public partial class FilmEkle : Form
    {
        MovieDbContext db = new MovieDbContext();
        public FilmEkle()
        {
            InitializeComponent();
        }

        private async void btn_Tur_Ekle_Click(object sender, EventArgs e)
        {
            Film newFilm = new Film();
            try
            {
                bool dogrulaYıl = int.TryParse(txt_Yil.Text, out int Yıl);
                bool dogrulaPuan = decimal.TryParse(txt_ImdbPuan.Text, out decimal puan);
                
                if (dogrulaYıl == true)
                {
                    newFilm.Yıl = Yıl;
                }
                else
                {
                    MessageBox.Show("hatalı yıl Girişi sadece rakam giriniz");
                }
                if (dogrulaPuan)
                {
                    newFilm.imdbPuanı = puan;
                }
                else
                {
                    MessageBox.Show("hatalı Imdb Puanı girişi sadece rakam giriniz");
                }
                newFilm.Ad = txt_FilmAdi.Text;
                newFilm.Poster = txt_PosterURL.Text;
                newFilm.imdbId = txt_ImdbID.Text;

                //var query = db.Turler.Where(x => x.Id == int.Parse(txt_TurAdi.Text)).FirstOrDefault();
                //newFilm.Tur = query;

                db.Filmler.Add(newFilm);
                db.SaveChanges();
                dataGridView1.DataSource = db.Filmler.ToList();


            }
            catch (Exception)
            {

                MessageBox.Show("İşlem yapılırken bir hata oluştu doğru değerleri girmeyi deneyiniz.");
            }
            

        }

        private void FilmEkle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Filmler.ToList();
        }
    }
}
