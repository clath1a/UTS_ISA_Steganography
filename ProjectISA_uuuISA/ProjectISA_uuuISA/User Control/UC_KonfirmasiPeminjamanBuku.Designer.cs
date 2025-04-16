namespace ProjectISA_uuuISA.User_Control
{
    partial class UC_KonfirmasiPeminjamanBuku
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewKonfirmasiPeminjamanBuku = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonfirmasiPeminjamanBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(174, 55);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(679, 55);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "Konfirmasi Peminjaman Buku";
            // 
            // dataGridViewKonfirmasiPeminjamanBuku
            // 
            this.dataGridViewKonfirmasiPeminjamanBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKonfirmasiPeminjamanBuku.Location = new System.Drawing.Point(29, 127);
            this.dataGridViewKonfirmasiPeminjamanBuku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKonfirmasiPeminjamanBuku.Name = "dataGridViewKonfirmasiPeminjamanBuku";
            this.dataGridViewKonfirmasiPeminjamanBuku.RowHeadersWidth = 62;
            this.dataGridViewKonfirmasiPeminjamanBuku.RowTemplate.Height = 28;
            this.dataGridViewKonfirmasiPeminjamanBuku.Size = new System.Drawing.Size(961, 569);
            this.dataGridViewKonfirmasiPeminjamanBuku.TabIndex = 52;
            // 
            // UC_KonfirmasiPeminjamanBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewKonfirmasiPeminjamanBuku);
            this.Controls.Add(this.labelTitle);
            this.Name = "UC_KonfirmasiPeminjamanBuku";
            this.Size = new System.Drawing.Size(1026, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonfirmasiPeminjamanBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewKonfirmasiPeminjamanBuku;
    }
}
