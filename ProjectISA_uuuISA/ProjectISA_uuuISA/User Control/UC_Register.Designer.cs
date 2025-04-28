namespace ProjectISA_uuuISA.User_Control
{
    partial class UC_Register
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
            this.labeLTitle = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.groupBoxRole = new System.Windows.Forms.GroupBox();
            this.rdoPustakawan = new System.Windows.Forms.RadioButton();
            this.rdoGuru = new System.Windows.Forms.RadioButton();
            this.rdoSiswa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.groupBoxRole.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeLTitle
            // 
            this.labeLTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeLTitle.AutoSize = true;
            this.labeLTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLTitle.Location = new System.Drawing.Point(373, 55);
            this.labeLTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeLTitle.Name = "labeLTitle";
            this.labeLTitle.Size = new System.Drawing.Size(342, 46);
            this.labeLTitle.TabIndex = 52;
            this.labeLTitle.Text = "Register Account";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegister.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRegister.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegister.Location = new System.Drawing.Point(315, 385);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(476, 59);
            this.buttonRegister.TabIndex = 51;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPassword.Location = new System.Drawing.Point(317, 266);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(476, 34);
            this.textBoxPassword.TabIndex = 50;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPassword.Location = new System.Drawing.Point(315, 228);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(138, 29);
            this.labelPassword.TabIndex = 49;
            this.labelPassword.Text = "Password : ";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUsername.Location = new System.Drawing.Point(312, 130);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(142, 29);
            this.labelUsername.TabIndex = 48;
            this.labelUsername.Text = "Username : ";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUsername.Location = new System.Drawing.Point(317, 167);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(476, 34);
            this.textBoxUsername.TabIndex = 47;
            // 
            // groupBoxRole
            // 
            this.groupBoxRole.Controls.Add(this.rdoPustakawan);
            this.groupBoxRole.Controls.Add(this.rdoGuru);
            this.groupBoxRole.Controls.Add(this.rdoSiswa);
            this.groupBoxRole.Location = new System.Drawing.Point(315, 314);
            this.groupBoxRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRole.Name = "groupBoxRole";
            this.groupBoxRole.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRole.Size = new System.Drawing.Size(473, 54);
            this.groupBoxRole.TabIndex = 53;
            this.groupBoxRole.TabStop = false;
            // 
            // rdoPustakawan
            // 
            this.rdoPustakawan.AutoSize = true;
            this.rdoPustakawan.Location = new System.Drawing.Point(348, 20);
            this.rdoPustakawan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoPustakawan.Name = "rdoPustakawan";
            this.rdoPustakawan.Size = new System.Drawing.Size(101, 20);
            this.rdoPustakawan.TabIndex = 2;
            this.rdoPustakawan.TabStop = true;
            this.rdoPustakawan.Text = "Pustakawan";
            this.rdoPustakawan.UseVisualStyleBackColor = true;
            // 
            // rdoGuru
            // 
            this.rdoGuru.AutoSize = true;
            this.rdoGuru.Location = new System.Drawing.Point(192, 20);
            this.rdoGuru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoGuru.Name = "rdoGuru";
            this.rdoGuru.Size = new System.Drawing.Size(56, 20);
            this.rdoGuru.TabIndex = 1;
            this.rdoGuru.TabStop = true;
            this.rdoGuru.Text = "Guru";
            this.rdoGuru.UseVisualStyleBackColor = true;
            // 
            // rdoSiswa
            // 
            this.rdoSiswa.AutoSize = true;
            this.rdoSiswa.Location = new System.Drawing.Point(25, 20);
            this.rdoSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoSiswa.Name = "rdoSiswa";
            this.rdoSiswa.Size = new System.Drawing.Size(64, 20);
            this.rdoSiswa.TabIndex = 0;
            this.rdoSiswa.TabStop = true;
            this.rdoSiswa.Text = "Siswa";
            this.rdoSiswa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Sudah Punya Akun?";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLogin.Location = new System.Drawing.Point(169, 11);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(48, 17);
            this.labelLogin.TabIndex = 56;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Location = new System.Drawing.Point(428, 459);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(244, 36);
            this.panelLogin.TabIndex = 57;
            this.panelLogin.Click += new System.EventHandler(this.panelLogin_Click);
            // 
            // UC_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.groupBoxRole);
            this.Controls.Add(this.labeLTitle);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Register";
            this.Size = new System.Drawing.Size(1104, 576);
            this.groupBoxRole.ResumeLayout(false);
            this.groupBoxRole.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeLTitle;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.GroupBox groupBoxRole;
        private System.Windows.Forms.RadioButton rdoPustakawan;
        private System.Windows.Forms.RadioButton rdoGuru;
        private System.Windows.Forms.RadioButton rdoSiswa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel panelLogin;
    }
}
