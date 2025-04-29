namespace ProjectISA_uuuISA.User_Control
{
    partial class UC_EditNilaiRaportSiswa
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
            this.dataGridNilai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(361, 37);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(304, 55);
            this.labelTitle.TabIndex = 51;
            this.labelTitle.Text = "Nama Siswa";
            // 
            // dataGridNilai
            // 
            this.dataGridNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNilai.Location = new System.Drawing.Point(35, 123);
            this.dataGridNilai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridNilai.Name = "dataGridNilai";
            this.dataGridNilai.RowHeadersWidth = 62;
            this.dataGridNilai.RowTemplate.Height = 28;
            this.dataGridNilai.Size = new System.Drawing.Size(961, 569);
            this.dataGridNilai.TabIndex = 54;
            this.dataGridNilai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNilai_CellContentClick_1);
            // 
            // UC_EditNilaiRaportSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridNilai);
            this.Controls.Add(this.labelTitle);
            this.Name = "UC_EditNilaiRaportSiswa";
            this.Size = new System.Drawing.Size(1026, 720);
            this.Load += new System.EventHandler(this.UC_EditNilaiRaportSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridNilai;
    }
}
