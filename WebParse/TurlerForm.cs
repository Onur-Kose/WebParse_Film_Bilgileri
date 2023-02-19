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

namespace WebParse.Models
{
    public partial class TurlerForm : Form
    {
        MovieDbContext db = new MovieDbContext();
        public TurlerForm()
        {
            InitializeComponent();
            


        }


        private void TurlerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Turler.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = db.Turler.Where(x => x.Ad.Contains(textBox1.Text));
            dataGridView1.DataSource = query.ToList();
            
        }

        private void btn_Tur_Ekle_Click(object sender, EventArgs e)
        {
            Tur newTur = new Tur();
            newTur.Ad = textBox1.Text;
            db.Turler.Add(newTur);
            db.SaveChanges();

            
        }

        private void brn_Tur_Guncelle_Click(object sender, EventArgs e)
        {

            //Tur query = db.Turler.Where(x => x.Ad == dataGridView1.SelectedRows[0].Cells[1].Value.ToString()).FirstOrDefault();
            //query.Ad


        }
    }
}
