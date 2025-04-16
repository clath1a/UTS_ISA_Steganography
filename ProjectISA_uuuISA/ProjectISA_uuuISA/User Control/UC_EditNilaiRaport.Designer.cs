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
            this.dataGridNamaSiswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNamaSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(320, 41);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(386, 55);
            this.labelTitle.TabIndex = 48;
            this.labelTitle.Text = "Edit Nilai Raport";
            // 
            // dataGridNamaSiswa
            // 
            this.dataGridNamaSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNamaSiswa.Location = new System.Drawing.Point(34, 126);
            this.dataGridNamaSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridNamaSiswa.Name = "dataGridNamaSiswa";
            this.dataGridNamaSiswa.RowHeadersWidth = 62;
            this.dataGridNamaSiswa.RowTemplate.Height = 28;
            this.dataGridNamaSiswa.Size = new System.Drawing.Size(961, 569);
            this.dataGridNamaSiswa.TabIndex = 53;
            // 
            // UC_EditNilaiRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridNamaSiswa);
            this.Controls.Add(this.labelTitle);
            this.Name = "UC_EditNilaiRaport";
            this.Size = new System.Drawing.Size(1026, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNamaSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridNamaSiswa;
    }
}
