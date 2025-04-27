namespace ProjectISA_uuuISA.User_Control
{
    partial class UC_EditNilaiRaport
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
            this.dataGridNamaKelas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNamaKelas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(335, 43);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(300, 55);
            this.labelTitle.TabIndex = 48;
            this.labelTitle.Text = "Daftar Kelas";
            // 
            // dataGridNamaKelas
            // 
            this.dataGridNamaKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNamaKelas.Location = new System.Drawing.Point(34, 126);
            this.dataGridNamaKelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridNamaKelas.Name = "dataGridNamaKelas";
            this.dataGridNamaKelas.RowHeadersWidth = 62;
            this.dataGridNamaKelas.RowTemplate.Height = 28;
            this.dataGridNamaKelas.Size = new System.Drawing.Size(961, 569);
            this.dataGridNamaKelas.TabIndex = 53;
            this.dataGridNamaKelas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNamaSiswa_CellContentClick);
            // 
            // UC_EditNilaiRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridNamaKelas);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_EditNilaiRaport";
            this.Size = new System.Drawing.Size(1026, 720);
            this.Load += new System.EventHandler(this.UC_EditNilaiRaport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNamaKelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridNamaKelas;
    }
}
