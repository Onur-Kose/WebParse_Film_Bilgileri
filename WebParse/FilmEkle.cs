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
                bool doğrulaYıl = int.TryParse(txt_Yil.Text, out int Yıl);
                bool doğrulaPuan = int.TryParse(txt_ImdbPuan.Text, out int puan);
                if (doğrulaYıl == true)
                {
                    newFilm.Yıl = Yıl;
                }
                else
                {
                    MessageBox.Show("hatalı yıl Girişi sadece rakam giriniz");
                }
                if (doğrulaPuan)
                {
                    newFilm.imdbPuanı = puan;
                }
                else
                {
                    MessageBox.Show("hatalı Imdb Puanı girişi sadece rakam giriniz");
                }
                               
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
