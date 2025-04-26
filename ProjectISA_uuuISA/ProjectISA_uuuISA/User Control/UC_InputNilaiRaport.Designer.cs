namespace ProjectISA_uuuISA.User_Control
{
    partial class UC_InputNilaiRaport
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
            this.dataGridViewNamaSiswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNamaSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(273, 44);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(345, 46);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "Input Nilai Raport";
            // 
            // dataGridViewNamaSiswa
            // 
            this.dataGridViewNamaSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNamaSiswa.Location = new System.Drawing.Point(30, 102);
            this.dataGridViewNamaSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewNamaSiswa.Name = "dataGridViewNamaSiswa";
            this.dataGridViewNamaSiswa.RowHeadersWidth = 62;
            this.dataGridViewNamaSiswa.RowTemplate.Height = 28;
            this.dataGridViewNamaSiswa.Size = new System.Drawing.Size(854, 455);
            this.dataGridViewNamaSiswa.TabIndex = 53;
            this.dataGridViewNamaSiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNamaSiswa_CellContentClick);
            // 
            // UC_InputNilaiRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewNamaSiswa);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_InputNilaiRaport";
            this.Size = new System.Drawing.Size(912, 576);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNamaSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewNamaSiswa;
    }
}
