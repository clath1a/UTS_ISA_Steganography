﻿namespace ProjectISA_uuuISA.User_Control
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
            this.dataGridViewKelas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(307, 55);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(412, 55);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "Input Nilai Raport";
            // 
            // dataGridViewKelas
            // 
            this.dataGridViewKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKelas.Location = new System.Drawing.Point(34, 128);
            this.dataGridViewKelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKelas.Name = "dataGridViewKelas";
            this.dataGridViewKelas.RowHeadersWidth = 62;
            this.dataGridViewKelas.RowTemplate.Height = 28;
            this.dataGridViewKelas.Size = new System.Drawing.Size(961, 569);
            this.dataGridViewKelas.TabIndex = 53;
            this.dataGridViewKelas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNamaSiswa_CellContentClick);
            // 
            // UC_InputNilaiRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewKelas);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_InputNilaiRaport";
            this.Size = new System.Drawing.Size(1026, 720);
            this.Load += new System.EventHandler(this.UC_InputNilaiRaport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewKelas;
    }
}
