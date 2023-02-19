namespace WebParse
{
    partial class Oyuncular
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
            this.dvg_oyuncular = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IletisimBilgisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_oyuncuSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_oyuncular)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_oyuncular
            // 
            this.dvg_oyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_oyuncular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AdSoyAd,
            this.IletisimBilgisi,
            this.dataGridViewTextBoxColumn1});
            this.dvg_oyuncular.Location = new System.Drawing.Point(12, 21);
            this.dvg_oyuncular.Name = "dvg_oyuncular";
            this.dvg_oyuncular.RowHeadersWidth = 51;
            this.dvg_oyuncular.RowTemplate.Height = 29;
            this.dvg_oyuncular.Size = new System.Drawing.Size(557, 289);
            this.dvg_oyuncular.TabIndex = 0;
            this.dvg_oyuncular.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_oyuncular_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // AdSoyAd
            // 
            this.AdSoyAd.HeaderText = "Ad Soyad";
            this.AdSoyAd.MinimumWidth = 6;
            this.AdSoyAd.Name = "AdSoyAd";
            this.AdSoyAd.Width = 125;
            // 
            // IletisimBilgisi
            // 
            this.IletisimBilgisi.HeaderText = "Telefon No";
            this.IletisimBilgisi.MinimumWidth = 6;
            this.IletisimBilgisi.Name = "IletisimBilgisi";
            this.IletisimBilgisi.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // btn_oyuncuSil
            // 
            this.btn_oyuncuSil.Location = new System.Drawing.Point(585, 74);
            this.btn_oyuncuSil.Name = "btn_oyuncuSil";
            this.btn_oyuncuSil.Size = new System.Drawing.Size(145, 57);
            this.btn_oyuncuSil.TabIndex = 1;
            this.btn_oyuncuSil.Text = "Sil";
            this.btn_oyuncuSil.UseVisualStyleBackColor = true;
            this.btn_oyuncuSil.Click += new System.EventHandler(this.btn_oyuncuSil_Click);
            // 
            // Oyuncular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 316);
            this.Controls.Add(this.btn_oyuncuSil);
            this.Controls.Add(this.dvg_oyuncular);
            this.Name = "Oyuncular";
            this.Text = "Oyuncular";
            this.Load += new System.EventHandler(this.Oyuncular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_oyuncular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dvg_oyuncular;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn AdSoyAd;
        private DataGridViewTextBoxColumn IletisimBilgisi;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btn_oyuncuSil;
    }
}