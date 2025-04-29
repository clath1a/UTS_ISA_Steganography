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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDataPribadi = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxRole = new System.Windows.Forms.GroupBox();
            this.rdoPustakawan = new System.Windows.Forms.RadioButton();
            this.rdoGuru = new System.Windows.Forms.RadioButton();
            this.rdoSiswa = new System.Windows.Forms.RadioButton();
            this.labeLTitle = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelData1 = new System.Windows.Forms.Label();
            this.labelData4 = new System.Windows.Forms.Label();
            this.labelData3 = new System.Windows.Forms.Label();
            this.labelData2 = new System.Windows.Forms.Label();
            this.textBoxData1 = new System.Windows.Forms.TextBox();
            this.textBoxData3 = new System.Windows.Forms.TextBox();
            this.textBoxData4 = new System.Windows.Forms.TextBox();
            this.dateTimePickerTglLahir = new System.Windows.Forms.DateTimePicker();
            this.textBoxData5 = new System.Windows.Forms.TextBox();
            this.labelData5 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelDataPribadi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegister.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRegister.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegister.Location = new System.Drawing.Point(38, 551);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(1150, 74);
            this.buttonRegister.TabIndex = 51;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Sudah Punya Akun?";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLogin.Location = new System.Drawing.Point(190, 14);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 20);
            this.labelLogin.TabIndex = 56;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Location = new System.Drawing.Point(483, 644);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(274, 45);
            this.panelLogin.TabIndex = 57;
            this.panelLogin.Click += new System.EventHandler(this.panelLogin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 55);
            this.label1.TabIndex = 58;
            this.label1.Text = "Data Pribadi";
            // 
            // panelDataPribadi
            // 
            this.panelDataPribadi.Controls.Add(this.textBoxData5);
            this.panelDataPribadi.Controls.Add(this.labelData5);
            this.panelDataPribadi.Controls.Add(this.dateTimePickerTglLahir);
            this.panelDataPribadi.Controls.Add(this.textBoxData4);
            this.panelDataPribadi.Controls.Add(this.textBoxData3);
            this.panelDataPribadi.Controls.Add(this.textBoxData1);
            this.panelDataPribadi.Controls.Add(this.labelData2);
            this.panelDataPribadi.Controls.Add(this.labelData3);
            this.panelDataPribadi.Controls.Add(this.labelData4);
            this.panelDataPribadi.Controls.Add(this.labelData1);
            this.panelDataPribadi.Location = new System.Drawing.Point(527, 125);
            this.panelDataPribadi.Name = "panelDataPribadi";
            this.panelDataPribadi.Size = new System.Drawing.Size(661, 409);
            this.panelDataPribadi.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxRole);
            this.panel1.Controls.Add(this.labeLTitle);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Location = new System.Drawing.Point(38, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 507);
            this.panel1.TabIndex = 60;
            // 
            // groupBoxRole
            // 
            this.groupBoxRole.Controls.Add(this.rdoPustakawan);
            this.groupBoxRole.Controls.Add(this.rdoGuru);
            this.groupBoxRole.Controls.Add(this.rdoSiswa);
            this.groupBoxRole.Location = new System.Drawing.Point(33, 348);
            this.groupBoxRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRole.Name = "groupBoxRole";
            this.groupBoxRole.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRole.Size = new System.Drawing.Size(396, 68);
            this.groupBoxRole.TabIndex = 59;
            this.groupBoxRole.TabStop = false;
            // 
            // rdoPustakawan
            // 
            this.rdoPustakawan.AutoSize = true;
            this.rdoPustakawan.Location = new System.Drawing.Point(236, 25);
            this.rdoPustakawan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoPustakawan.Name = "rdoPustakawan";
            this.rdoPustakawan.Size = new System.Drawing.Size(121, 24);
            this.rdoPustakawan.TabIndex = 2;
            this.rdoPustakawan.TabStop = true;
            this.rdoPustakawan.Text = "Pustakawan";
            this.rdoPustakawan.UseVisualStyleBackColor = true;
            this.rdoPustakawan.CheckedChanged += new System.EventHandler(this.rdoPustakawan_CheckedChanged);
            // 
            // rdoGuru
            // 
            this.rdoGuru.AutoSize = true;
            this.rdoGuru.Location = new System.Drawing.Point(128, 25);
            this.rdoGuru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoGuru.Name = "rdoGuru";
            this.rdoGuru.Size = new System.Drawing.Size(70, 24);
            this.rdoGuru.TabIndex = 1;
            this.rdoGuru.TabStop = true;
            this.rdoGuru.Text = "Guru";
            this.rdoGuru.UseVisualStyleBackColor = true;
            this.rdoGuru.CheckedChanged += new System.EventHandler(this.rdoGuru_CheckedChanged);
            // 
            // rdoSiswa
            // 
            this.rdoSiswa.AutoSize = true;
            this.rdoSiswa.Location = new System.Drawing.Point(30, 25);
            this.rdoSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoSiswa.Name = "rdoSiswa";
            this.rdoSiswa.Size = new System.Drawing.Size(76, 24);
            this.rdoSiswa.TabIndex = 0;
            this.rdoSiswa.TabStop = true;
            this.rdoSiswa.Text = "Siswa";
            this.rdoSiswa.UseVisualStyleBackColor = true;
            this.rdoSiswa.CheckedChanged += new System.EventHandler(this.rdoSiswa_CheckedChanged);
            // 
            // labeLTitle
            // 
            this.labeLTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeLTitle.AutoSize = true;
            this.labeLTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLTitle.Location = new System.Drawing.Point(23, 27);
            this.labeLTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeLTitle.Name = "labeLTitle";
            this.labeLTitle.Size = new System.Drawing.Size(406, 55);
            this.labeLTitle.TabIndex = 58;
            this.labeLTitle.Text = "Register Account";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPassword.Location = new System.Drawing.Point(33, 277);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(396, 39);
            this.textBoxPassword.TabIndex = 57;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPassword.Location = new System.Drawing.Point(27, 227);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(160, 32);
            this.labelPassword.TabIndex = 56;
            this.labelPassword.Text = "Password : ";
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelId.Location = new System.Drawing.Point(27, 121);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(52, 32);
            this.labelId.TabIndex = 55;
            this.labelId.Text = "Id :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUsername.Location = new System.Drawing.Point(33, 167);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(396, 39);
            this.textBoxUsername.TabIndex = 54;
            // 
            // labelData1
            // 
            this.labelData1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelData1.AutoSize = true;
            this.labelData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData1.Location = new System.Drawing.Point(28, 39);
            this.labelData1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelData1.Name = "labelData1";
            this.labelData1.Size = new System.Drawing.Size(57, 20);
            this.labelData1.TabIndex = 60;
            this.labelData1.Text = "Data 1";
            // 
            // labelData4
            // 
            this.labelData4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelData4.AutoSize = true;
            this.labelData4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData4.Location = new System.Drawing.Point(28, 248);
            this.labelData4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelData4.Name = "labelData4";
            this.labelData4.Size = new System.Drawing.Size(57, 20);
            this.labelData4.TabIndex = 63;
            this.labelData4.Text = "Data 4";
            // 
            // labelData3
            // 
            this.labelData3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelData3.AutoSize = true;
            this.labelData3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData3.Location = new System.Drawing.Point(28, 171);
            this.labelData3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelData3.Name = "labelData3";
            this.labelData3.Size = new System.Drawing.Size(57, 20);
            this.labelData3.TabIndex = 65;
            this.labelData3.Text = "Data 3";
            // 
            // labelData2
            // 
            this.labelData2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelData2.AutoSize = true;
            this.labelData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData2.Location = new System.Drawing.Point(28, 103);
            this.labelData2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelData2.Name = "labelData2";
            this.labelData2.Size = new System.Drawing.Size(57, 20);
            this.labelData2.TabIndex = 66;
            this.labelData2.Text = "Data 2";
            // 
            // textBoxData1
            // 
            this.textBoxData1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxData1.BackColor = System.Drawing.Color.White;
            this.textBoxData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxData1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxData1.Location = new System.Drawing.Point(150, 26);
            this.textBoxData1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxData1.Name = "textBoxData1";
            this.textBoxData1.Size = new System.Drawing.Size(484, 39);
            this.textBoxData1.TabIndex = 68;
            // 
            // textBoxData3
            // 
            this.textBoxData3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxData3.BackColor = System.Drawing.Color.White;
            this.textBoxData3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxData3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxData3.Location = new System.Drawing.Point(150, 158);
            this.textBoxData3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxData3.Name = "textBoxData3";
            this.textBoxData3.Size = new System.Drawing.Size(484, 39);
            this.textBoxData3.TabIndex = 69;
            // 
            // textBoxData4
            // 
            this.textBoxData4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxData4.BackColor = System.Drawing.Color.White;
            this.textBoxData4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxData4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxData4.Location = new System.Drawing.Point(150, 235);
            this.textBoxData4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxData4.Name = "textBoxData4";
            this.textBoxData4.Size = new System.Drawing.Size(484, 39);
            this.textBoxData4.TabIndex = 70;
            // 
            // dateTimePickerTglLahir
            // 
            this.dateTimePickerTglLahir.Location = new System.Drawing.Point(150, 97);
            this.dateTimePickerTglLahir.Name = "dateTimePickerTglLahir";
            this.dateTimePickerTglLahir.Size = new System.Drawing.Size(484, 26);
            this.dateTimePickerTglLahir.TabIndex = 74;
            // 
            // textBoxData5
            // 
            this.textBoxData5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxData5.BackColor = System.Drawing.Color.White;
            this.textBoxData5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxData5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxData5.Location = new System.Drawing.Point(150, 307);
            this.textBoxData5.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxData5.Name = "textBoxData5";
            this.textBoxData5.Size = new System.Drawing.Size(484, 39);
            this.textBoxData5.TabIndex = 76;
            // 
            // labelData5
            // 
            this.labelData5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelData5.AutoSize = true;
            this.labelData5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData5.Location = new System.Drawing.Point(28, 320);
            this.labelData5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelData5.Name = "labelData5";
            this.labelData5.Size = new System.Drawing.Size(57, 20);
            this.labelData5.TabIndex = 75;
            this.labelData5.Text = "Data 5";
            // 
            // UC_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDataPribadi);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Register";
            this.Size = new System.Drawing.Size(1242, 720);
            this.Load += new System.EventHandler(this.UC_Register_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelDataPribadi.ResumeLayout(false);
            this.panelDataPribadi.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxRole.ResumeLayout(false);
            this.groupBoxRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDataPribadi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxData4;
        private System.Windows.Forms.TextBox textBoxData3;
        private System.Windows.Forms.TextBox textBoxData1;
        private System.Windows.Forms.Label labelData2;
        private System.Windows.Forms.Label labelData3;
        private System.Windows.Forms.Label labelData4;
        private System.Windows.Forms.Label labelData1;
        private System.Windows.Forms.GroupBox groupBoxRole;
        private System.Windows.Forms.RadioButton rdoPustakawan;
        private System.Windows.Forms.RadioButton rdoGuru;
        private System.Windows.Forms.RadioButton rdoSiswa;
        private System.Windows.Forms.Label labeLTitle;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglLahir;
        private System.Windows.Forms.TextBox textBoxData5;
        private System.Windows.Forms.Label labelData5;
    }
}
