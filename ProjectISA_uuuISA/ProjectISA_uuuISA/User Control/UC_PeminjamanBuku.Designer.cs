namespace ProjectISA_uuuISA.User_Control
{
    partial class UC_PeminjamanBuku
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
            this.dataGridViewDaftarBuku = new System.Windows.Forms.DataGridView();
            this.dataGridViewStatusPeminjaman = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarBuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatusPeminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(369, 41);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(289, 55);
            this.labelTitle.TabIndex = 47;
            this.labelTitle.Text = "Daftar Buku";
            // 
            // dataGridViewDaftarBuku
            // 
            this.dataGridViewDaftarBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarBuku.Location = new System.Drawing.Point(32, 123);
            this.dataGridViewDaftarBuku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDaftarBuku.Name = "dataGridViewDaftarBuku";
            this.dataGridViewDaftarBuku.RowHeadersWidth = 62;
            this.dataGridViewDaftarBuku.RowTemplate.Height = 28;
            this.dataGridViewDaftarBuku.Size = new System.Drawing.Size(961, 376);
            this.dataGridViewDaftarBuku.TabIndex = 48;
            this.dataGridViewDaftarBuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarBuku_CellContentClick);
            // 
            // dataGridViewStatusPeminjaman
            // 
            this.dataGridViewStatusPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatusPeminjaman.Location = new System.Drawing.Point(32, 521);
            this.dataGridViewStatusPeminjaman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewStatusPeminjaman.Name = "dataGridViewStatusPeminjaman";
            this.dataGridViewStatusPeminjaman.RowHeadersWidth = 62;
            this.dataGridViewStatusPeminjaman.RowTemplate.Height = 28;
            this.dataGridViewStatusPeminjaman.Size = new System.Drawing.Size(961, 167);
            this.dataGridViewStatusPeminjaman.TabIndex = 49;
            // 
            // UC_PeminjamanBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewStatusPeminjaman);
            this.Controls.Add(this.dataGridViewDaftarBuku);
            this.Controls.Add(this.labelTitle);
            this.Name = "UC_PeminjamanBuku";
            this.Size = new System.Drawing.Size(1026, 720);
            this.Load += new System.EventHandler(this.UC_PeminjamanBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatusPeminjaman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewDaftarBuku;
        private System.Windows.Forms.DataGridView dataGridViewStatusPeminjaman;
    }
}
