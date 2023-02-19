namespace WebParse.Models
{
    partial class TurlerForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Tur_Ekle = new System.Windows.Forms.Button();
            this.brn_Tur_Guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(292, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tur Adı";
            // 
            // btn_Tur_Ekle
            // 
            this.btn_Tur_Ekle.Location = new System.Drawing.Point(510, 88);
            this.btn_Tur_Ekle.Name = "btn_Tur_Ekle";
            this.btn_Tur_Ekle.Size = new System.Drawing.Size(114, 42);
            this.btn_Tur_Ekle.TabIndex = 3;
            this.btn_Tur_Ekle.Text = "Tur Ekle";
            this.btn_Tur_Ekle.UseVisualStyleBackColor = true;
            this.btn_Tur_Ekle.Click += new System.EventHandler(this.btn_Tur_Ekle_Click);
            // 
            // brn_Tur_Guncelle
            // 
            this.brn_Tur_Guncelle.Location = new System.Drawing.Point(379, 88);
            this.brn_Tur_Guncelle.Name = "brn_Tur_Guncelle";
            this.brn_Tur_Guncelle.Size = new System.Drawing.Size(114, 42);
            this.brn_Tur_Guncelle.TabIndex = 4;
            this.brn_Tur_Guncelle.Text = "Türü Güncelle";
            this.brn_Tur_Guncelle.UseVisualStyleBackColor = true;
            this.brn_Tur_Guncelle.Click += new System.EventHandler(this.brn_Tur_Guncelle_Click);
            // 
            // TurlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 343);
            this.Controls.Add(this.brn_Tur_Guncelle);
            this.Controls.Add(this.btn_Tur_Ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TurlerForm";
            this.Text = "Turler";
            this.Load += new System.EventHandler(this.TurlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Button btn_Tur_Ekle;
        private Button brn_Tur_Guncelle;
    }
}