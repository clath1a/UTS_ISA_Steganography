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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHiddenMessage = new System.Windows.Forms.Label();
            this.labelUploadFoto = new System.Windows.Forms.Label();
            this.pictureBoxTTD = new System.Windows.Forms.PictureBox();
            this.btnSimpanTTD = new System.Windows.Forms.Button();
            this.btnUpploadFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTTD)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(241, 72);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(523, 55);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "Upload Tanda Tangan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 26);
            this.textBox1.TabIndex = 66;
            // 
            // lblHiddenMessage
            // 
            this.lblHiddenMessage.AutoSize = true;
            this.lblHiddenMessage.Location = new System.Drawing.Point(192, 173);
            this.lblHiddenMessage.Name = "lblHiddenMessage";
            this.lblHiddenMessage.Size = new System.Drawing.Size(137, 20);
            this.lblHiddenMessage.TabIndex = 67;
            this.lblHiddenMessage.Text = "Hidden Message: ";
            // 
            // labelUploadFoto
            // 
            this.labelUploadFoto.AutoSize = true;
            this.labelUploadFoto.Location = new System.Drawing.Point(192, 229);
            this.labelUploadFoto.Name = "labelUploadFoto";
            this.labelUploadFoto.Size = new System.Drawing.Size(105, 20);
            this.labelUploadFoto.TabIndex = 68;
            this.labelUploadFoto.Text = "Upload Foto: ";
            // 
            // pictureBoxTTD
            // 
            this.pictureBoxTTD.Location = new System.Drawing.Point(335, 212);
            this.pictureBoxTTD.Name = "pictureBoxTTD";
            this.pictureBoxTTD.Size = new System.Drawing.Size(336, 280);
            this.pictureBoxTTD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTTD.TabIndex = 69;
            this.pictureBoxTTD.TabStop = false;
            // 
            // btnSimpanTTD
            // 
            this.btnSimpanTTD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSimpanTTD.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSimpanTTD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSimpanTTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpanTTD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSimpanTTD.Location = new System.Drawing.Point(166, 598);
            this.btnSimpanTTD.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpanTTD.Name = "btnSimpanTTD";
            this.btnSimpanTTD.Size = new System.Drawing.Size(691, 39);
            this.btnSimpanTTD.TabIndex = 70;
            this.btnSimpanTTD.Text = "Simpan Tanda Tangan";
            this.btnSimpanTTD.UseVisualStyleBackColor = false;
            this.btnSimpanTTD.Click += new System.EventHandler(this.btnSimpanTTD_Click);
            // 
            // btnUpploadFoto
            // 
            this.btnUpploadFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpploadFoto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpploadFoto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpploadFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpploadFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpploadFoto.Location = new System.Drawing.Point(335, 508);
            this.btnUpploadFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpploadFoto.Name = "btnUpploadFoto";
            this.btnUpploadFoto.Size = new System.Drawing.Size(336, 39);
            this.btnUpploadFoto.TabIndex = 71;
            this.btnUpploadFoto.Text = "Upload Foto";
            this.btnUpploadFoto.UseVisualStyleBackColor = false;
            this.btnUpploadFoto.Click += new System.EventHandler(this.btnUpploadFoto_Click);
            // 
            // UC_UploadTTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpploadFoto);
            this.Controls.Add(this.btnSimpanTTD);
            this.Controls.Add(this.pictureBoxTTD);
            this.Controls.Add(this.labelUploadFoto);
            this.Controls.Add(this.lblHiddenMessage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "UC_UploadTTD";
            this.Size = new System.Drawing.Size(1026, 720);
            this.Load += new System.EventHandler(this.UC_UploadTTD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHiddenMessage;
        private System.Windows.Forms.Label labelUploadFoto;
        private System.Windows.Forms.PictureBox pictureBoxTTD;
        private System.Windows.Forms.Button btnSimpanTTD;
        private System.Windows.Forms.Button btnUpploadFoto;
    }
}
