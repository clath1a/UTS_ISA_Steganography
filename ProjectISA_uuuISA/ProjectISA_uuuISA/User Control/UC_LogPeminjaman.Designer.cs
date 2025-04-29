namespace ProjectISA_uuuISA.User_Control
{
    partial class UC_LogPeminjaman
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
            this.dataGridViewLogPeminjaman = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogPeminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(311, 40);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(399, 55);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "Log Peminjaman";
            // 
            // dataGridViewLogPeminjaman
            // 
            this.dataGridViewLogPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogPeminjaman.Location = new System.Drawing.Point(31, 122);
            this.dataGridViewLogPeminjaman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLogPeminjaman.Name = "dataGridViewLogPeminjaman";
            this.dataGridViewLogPeminjaman.RowHeadersWidth = 62;
            this.dataGridViewLogPeminjaman.RowTemplate.Height = 28;
            this.dataGridViewLogPeminjaman.Size = new System.Drawing.Size(961, 569);
            this.dataGridViewLogPeminjaman.TabIndex = 50;
            this.dataGridViewLogPeminjaman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLogPeminjaman_CellContentClick);
            // 
            // UC_LogPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewLogPeminjaman);
            this.Controls.Add(this.labelTitle);
            this.Name = "UC_LogPeminjaman";
            this.Size = new System.Drawing.Size(1026, 720);
            this.Load += new System.EventHandler(this.UC_LogPeminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogPeminjaman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewLogPeminjaman;
    }
}
