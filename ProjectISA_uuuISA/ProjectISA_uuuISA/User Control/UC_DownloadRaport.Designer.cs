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
            this.comboBoxPilihSemester = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonDownloadRaport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(379, 195);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(146, 46);
            this.labelTitle.TabIndex = 47;
            this.labelTitle.Text = "Raport";
            // 
            // comboBoxPilihSemester
            // 
            this.comboBoxPilihSemester.FormattingEnabled = true;
            this.comboBoxPilihSemester.Location = new System.Drawing.Point(196, 262);
            this.comboBoxPilihSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPilihSemester.Name = "comboBoxPilihSemester";
            this.comboBoxPilihSemester.Size = new System.Drawing.Size(521, 24);
            this.comboBoxPilihSemester.TabIndex = 48;
            // 
            // buttonDownloadRaport
            // 
            this.buttonDownloadRaport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDownloadRaport.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDownloadRaport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDownloadRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadRaport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDownloadRaport.Location = new System.Drawing.Point(196, 298);
            this.buttonDownloadRaport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownloadRaport.Name = "buttonDownloadRaport";
            this.buttonDownloadRaport.Size = new System.Drawing.Size(521, 42);
            this.buttonDownloadRaport.TabIndex = 63;
            this.buttonDownloadRaport.Text = "Download Raport";
            this.buttonDownloadRaport.UseVisualStyleBackColor = false;
            this.buttonDownloadRaport.Click += new System.EventHandler(this.buttonDownloadRaport_Click);
            // 
            // UC_DownloadRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDownloadRaport);
            this.Controls.Add(this.comboBoxPilihSemester);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_DownloadRaport";
            this.Size = new System.Drawing.Size(912, 576);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxPilihSemester;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonDownloadRaport;
    }
}
