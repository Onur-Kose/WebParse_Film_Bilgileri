namespace WebParse
{
    partial class FilmEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Tur_Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FilmAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Yil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ImdbPuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ImdbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TurAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(402, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Tur_Ekle
            // 
            this.btn_Tur_Ekle.Location = new System.Drawing.Point(650, 340);
            this.btn_Tur_Ekle.Name = "btn_Tur_Ekle";
            this.btn_Tur_Ekle.Size = new System.Drawing.Size(114, 42);
            this.btn_Tur_Ekle.TabIndex = 7;
            this.btn_Tur_Ekle.Text = "Film Ekle";
            this.btn_Tur_Ekle.UseVisualStyleBackColor = true;
            this.btn_Tur_Ekle.Click += new System.EventHandler(this.btn_Tur_Ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Film Adı";
            // 
            // txt_FilmAdi
            // 
            this.txt_FilmAdi.Location = new System.Drawing.Point(520, 53);
            this.txt_FilmAdi.Name = "txt_FilmAdi";
            this.txt_FilmAdi.Size = new System.Drawing.Size(235, 27);
            this.txt_FilmAdi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yılı";
            // 
            // txt_Yil
            // 
            this.txt_Yil.Location = new System.Drawing.Point(520, 97);
            this.txt_Yil.Name = "txt_Yil";
            this.txt_Yil.Size = new System.Drawing.Size(235, 27);
            this.txt_Yil.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Imdb Puanı";
            // 
            // txt_ImdbPuan
            // 
            this.txt_ImdbPuan.Location = new System.Drawing.Point(520, 146);
            this.txt_ImdbPuan.Name = "txt_ImdbPuan";
            this.txt_ImdbPuan.Size = new System.Drawing.Size(235, 27);
            this.txt_ImdbPuan.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Imdb ID";
            // 
            // txt_ImdbID
            // 
            this.txt_ImdbID.Location = new System.Drawing.Point(520, 197);
            this.txt_ImdbID.Name = "txt_ImdbID";
            this.txt_ImdbID.Size = new System.Drawing.Size(235, 27);
            this.txt_ImdbID.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tur Adı";
            // 
            // txt_TurAdi
            // 
            this.txt_TurAdi.Location = new System.Drawing.Point(520, 240);
            this.txt_TurAdi.Name = "txt_TurAdi";
            this.txt_TurAdi.Size = new System.Drawing.Size(235, 27);
            this.txt_TurAdi.TabIndex = 14;
            // 
            // FilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TurAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ImdbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ImdbPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Yil);
            this.Controls.Add(this.btn_Tur_Ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_FilmAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FilmEkle";
            this.Text = "FilmEkle";
            this.Load += new System.EventHandler(this.FilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Tur_Ekle;
        private Label label1;
        private TextBox txt_FilmAdi;
        private Label label2;
        private TextBox txt_Yil;
        private Label label3;
        private TextBox txt_ImdbPuan;
        private Label label4;
        private TextBox txt_ImdbID;
        private Label label5;
        private TextBox txt_TurAdi;
    }
}