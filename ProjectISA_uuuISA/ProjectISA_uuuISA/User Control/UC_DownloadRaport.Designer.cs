namespace ProjectISA_uuuISA.User_Control
{
    partial class UC_DownloadRaport
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
            this.comboBoxPilihSiswa = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonDownloadRaport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(426, 244);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(175, 55);
            this.labelTitle.TabIndex = 47;
            this.labelTitle.Text = "Raport";
            // 
            // comboBoxPilihSiswa
            // 
            this.comboBoxPilihSiswa.FormattingEnabled = true;
            this.comboBoxPilihSiswa.Location = new System.Drawing.Point(220, 328);
            this.comboBoxPilihSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPilihSiswa.Name = "comboBoxPilihSiswa";
            this.comboBoxPilihSiswa.Size = new System.Drawing.Size(586, 28);
            this.comboBoxPilihSiswa.TabIndex = 48;
            this.comboBoxPilihSiswa.SelectedIndexChanged += new System.EventHandler(this.comboBoxPilihSemester_SelectedIndexChanged);
            // 
            // buttonDownloadRaport
            // 
            this.buttonDownloadRaport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDownloadRaport.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDownloadRaport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDownloadRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadRaport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDownloadRaport.Location = new System.Drawing.Point(220, 372);
            this.buttonDownloadRaport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownloadRaport.Name = "buttonDownloadRaport";
            this.buttonDownloadRaport.Size = new System.Drawing.Size(586, 52);
            this.buttonDownloadRaport.TabIndex = 63;
            this.buttonDownloadRaport.Text = "Download Raport";
            this.buttonDownloadRaport.UseVisualStyleBackColor = false;
            this.buttonDownloadRaport.Click += new System.EventHandler(this.buttonDownloadRaport_Click);
            // 
            // UC_DownloadRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDownloadRaport);
            this.Controls.Add(this.comboBoxPilihSiswa);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_DownloadRaport";
            this.Size = new System.Drawing.Size(1026, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxPilihSiswa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonDownloadRaport;
    }
}
