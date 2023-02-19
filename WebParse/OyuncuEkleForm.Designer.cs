namespace WebParse
{
    partial class OyuncuEkleForm
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
            this.txtOyuncuAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOyuncuTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOyuncuAdres = new System.Windows.Forms.TextBox();
            this.btn_oyuncuEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOyuncuAdSoyad
            // 
            this.txtOyuncuAdSoyad.Location = new System.Drawing.Point(106, 64);
            this.txtOyuncuAdSoyad.Name = "txtOyuncuAdSoyad";
            this.txtOyuncuAdSoyad.Size = new System.Drawing.Size(227, 27);
            this.txtOyuncuAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon";
            // 
            // txtOyuncuTelefon
            // 
            this.txtOyuncuTelefon.Location = new System.Drawing.Point(106, 112);
            this.txtOyuncuTelefon.Name = "txtOyuncuTelefon";
            this.txtOyuncuTelefon.Size = new System.Drawing.Size(227, 27);
            this.txtOyuncuTelefon.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adres";
            // 
            // txtOyuncuAdres
            // 
            this.txtOyuncuAdres.Location = new System.Drawing.Point(106, 158);
            this.txtOyuncuAdres.Multiline = true;
            this.txtOyuncuAdres.Name = "txtOyuncuAdres";
            this.txtOyuncuAdres.Size = new System.Drawing.Size(227, 101);
            this.txtOyuncuAdres.TabIndex = 4;
            // 
            // btn_oyuncuEkle
            // 
            this.btn_oyuncuEkle.Location = new System.Drawing.Point(200, 311);
            this.btn_oyuncuEkle.Name = "btn_oyuncuEkle";
            this.btn_oyuncuEkle.Size = new System.Drawing.Size(133, 40);
            this.btn_oyuncuEkle.TabIndex = 6;
            this.btn_oyuncuEkle.Text = "Oyuncu Ekle";
            this.btn_oyuncuEkle.UseVisualStyleBackColor = true;
            this.btn_oyuncuEkle.Click += new System.EventHandler(this.btn_oyuncuEkle_Click);
            // 
            // OyuncuEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.btn_oyuncuEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOyuncuAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOyuncuTelefon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOyuncuAdSoyad);
            this.Name = "OyuncuEkleForm";
            this.Text = "OyuncuEkleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtOyuncuAdSoyad;
        private Label label1;
        private Label label2;
        private TextBox txtOyuncuTelefon;
        private Label label3;
        private TextBox txtOyuncuAdres;
        private Button btn_oyuncuEkle;
    }
}