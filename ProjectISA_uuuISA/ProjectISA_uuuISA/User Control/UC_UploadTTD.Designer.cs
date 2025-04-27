namespace ProjectISA_uuuISA.User_Control
{
    partial class UC_UploadTTD
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
            this.buttonUploadTTD = new System.Windows.Forms.Button();
            this.labelImagePath = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHiddenMessage = new System.Windows.Forms.Label();
            this.labelUploadFoto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(251, 198);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(523, 55);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "Upload Tanda Tangan";
            // 
            // buttonUploadTTD
            // 
            this.buttonUploadTTD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUploadTTD.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonUploadTTD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonUploadTTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadTTD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUploadTTD.Location = new System.Drawing.Point(345, 344);
            this.buttonUploadTTD.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUploadTTD.Name = "buttonUploadTTD";
            this.buttonUploadTTD.Size = new System.Drawing.Size(447, 39);
            this.buttonUploadTTD.TabIndex = 64;
            this.buttonUploadTTD.Text = "Upload Foto";
            this.buttonUploadTTD.UseVisualStyleBackColor = false;
            this.buttonUploadTTD.Click += new System.EventHandler(this.buttonUploadTTD_Click);
            // 
            // labelImagePath
            // 
            this.labelImagePath.AutoSize = true;
            this.labelImagePath.Location = new System.Drawing.Point(200, 498);
            this.labelImagePath.Name = "labelImagePath";
            this.labelImagePath.Size = new System.Drawing.Size(91, 20);
            this.labelImagePath.TabIndex = 65;
            this.labelImagePath.Text = "Image Path";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 299);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 26);
            this.textBox1.TabIndex = 66;
            // 
            // lblHiddenMessage
            // 
            this.lblHiddenMessage.AutoSize = true;
            this.lblHiddenMessage.Location = new System.Drawing.Point(202, 299);
            this.lblHiddenMessage.Name = "lblHiddenMessage";
            this.lblHiddenMessage.Size = new System.Drawing.Size(137, 20);
            this.lblHiddenMessage.TabIndex = 67;
            this.lblHiddenMessage.Text = "Hidden Message: ";
            // 
            // labelUploadFoto
            // 
            this.labelUploadFoto.AutoSize = true;
            this.labelUploadFoto.Location = new System.Drawing.Point(202, 355);
            this.labelUploadFoto.Name = "labelUploadFoto";
            this.labelUploadFoto.Size = new System.Drawing.Size(105, 20);
            this.labelUploadFoto.TabIndex = 68;
            this.labelUploadFoto.Text = "Upload Foto: ";
            // 
            // UC_UploadTTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelUploadFoto);
            this.Controls.Add(this.lblHiddenMessage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelImagePath);
            this.Controls.Add(this.buttonUploadTTD);
            this.Controls.Add(this.labelTitle);
            this.Name = "UC_UploadTTD";
            this.Size = new System.Drawing.Size(1026, 720);
            this.Load += new System.EventHandler(this.UC_UploadTTD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonUploadTTD;
        private System.Windows.Forms.Label labelImagePath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHiddenMessage;
        private System.Windows.Forms.Label labelUploadFoto;
    }
}
