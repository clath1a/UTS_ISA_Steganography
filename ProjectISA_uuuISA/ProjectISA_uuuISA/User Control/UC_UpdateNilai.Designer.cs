namespace ProjectISA_uuuISA.User_Control
{
    partial class UC_UpdateNilai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdateNilai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSemester = new System.Windows.Forms.GroupBox();
            this.rdoGenap = new System.Windows.Forms.RadioButton();
            this.rdoGanjil = new System.Windows.Forms.RadioButton();
            this.dateTimePickerTahunAjaran = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxDeskripsi = new System.Windows.Forms.RichTextBox();
            this.numericUpDownNilai = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBoxSemester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(345, 45);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(297, 55);
            this.labelTitle.TabIndex = 48;
            this.labelTitle.Text = "Update Nilai";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownNilai);
            this.panel1.Controls.Add(this.buttonUpdateNilai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBoxSemester);
            this.panel1.Controls.Add(this.dateTimePickerTahunAjaran);
            this.panel1.Controls.Add(this.richTextBoxDeskripsi);
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 606);
            this.panel1.TabIndex = 57;
            // 
            // buttonUpdateNilai
            // 
            this.buttonUpdateNilai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateNilai.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonUpdateNilai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonUpdateNilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonUpdateNilai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdateNilai.Location = new System.Drawing.Point(216, 433);
            this.buttonUpdateNilai.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateNilai.Name = "buttonUpdateNilai";
            this.buttonUpdateNilai.Size = new System.Drawing.Size(614, 74);
            this.buttonUpdateNilai.TabIndex = 64;
            this.buttonUpdateNilai.Text = "Simpan";
            this.buttonUpdateNilai.UseVisualStyleBackColor = false;
            this.buttonUpdateNilai.Click += new System.EventHandler(this.buttonUpdateNilai_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = "Deskripsi";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = "Tahun Ajaran";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nilai";
            // 
            // groupBoxSemester
            // 
            this.groupBoxSemester.Controls.Add(this.rdoGenap);
            this.groupBoxSemester.Controls.Add(this.rdoGanjil);
            this.groupBoxSemester.Location = new System.Drawing.Point(216, 101);
            this.groupBoxSemester.Name = "groupBoxSemester";
            this.groupBoxSemester.Size = new System.Drawing.Size(170, 111);
            this.groupBoxSemester.TabIndex = 60;
            this.groupBoxSemester.TabStop = false;
            this.groupBoxSemester.Text = "Semester";
            // 
            // rdoGenap
            // 
            this.rdoGenap.AutoSize = true;
            this.rdoGenap.Location = new System.Drawing.Point(25, 68);
            this.rdoGenap.Name = "rdoGenap";
            this.rdoGenap.Size = new System.Drawing.Size(83, 24);
            this.rdoGenap.TabIndex = 54;
            this.rdoGenap.TabStop = true;
            this.rdoGenap.Text = "Genap";
            this.rdoGenap.UseVisualStyleBackColor = true;
            // 
            // rdoGanjil
            // 
            this.rdoGanjil.AutoSize = true;
            this.rdoGanjil.Location = new System.Drawing.Point(25, 30);
            this.rdoGanjil.Name = "rdoGanjil";
            this.rdoGanjil.Size = new System.Drawing.Size(74, 24);
            this.rdoGanjil.TabIndex = 53;
            this.rdoGanjil.TabStop = true;
            this.rdoGanjil.Text = "Ganjil";
            this.rdoGanjil.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTahunAjaran
            // 
            this.dateTimePickerTahunAjaran.Location = new System.Drawing.Point(403, 52);
            this.dateTimePickerTahunAjaran.Name = "dateTimePickerTahunAjaran";
            this.dateTimePickerTahunAjaran.Size = new System.Drawing.Size(427, 26);
            this.dateTimePickerTahunAjaran.TabIndex = 59;
            // 
            // richTextBoxDeskripsi
            // 
            this.richTextBoxDeskripsi.Location = new System.Drawing.Point(403, 297);
            this.richTextBoxDeskripsi.Name = "richTextBoxDeskripsi";
            this.richTextBoxDeskripsi.Size = new System.Drawing.Size(427, 111);
            this.richTextBoxDeskripsi.TabIndex = 58;
            this.richTextBoxDeskripsi.Text = "";
            // 
            // numericUpDownNilai
            // 
            this.numericUpDownNilai.Location = new System.Drawing.Point(403, 243);
            this.numericUpDownNilai.Name = "numericUpDownNilai";
            this.numericUpDownNilai.Size = new System.Drawing.Size(427, 26);
            this.numericUpDownNilai.TabIndex = 65;
            // 
            // UC_UpdateNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Name = "UC_UpdateNilai";
            this.Size = new System.Drawing.Size(1026, 720);
            this.Load += new System.EventHandler(this.UC_UpdateNilai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxSemester.ResumeLayout(false);
            this.groupBoxSemester.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUpdateNilai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSemester;
        private System.Windows.Forms.RadioButton rdoGenap;
        private System.Windows.Forms.RadioButton rdoGanjil;
        private System.Windows.Forms.DateTimePicker dateTimePickerTahunAjaran;
        private System.Windows.Forms.RichTextBox richTextBoxDeskripsi;
        private System.Windows.Forms.NumericUpDown numericUpDownNilai;
    }
}
