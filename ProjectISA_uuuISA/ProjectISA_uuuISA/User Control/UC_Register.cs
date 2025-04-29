using class_uuuISA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectISA_uuuISA.User_Control
{
    public partial class UC_Register : UserControl
    {
        FormUtama formUtama;
        
        public UC_Register(FormUtama formUtama)
        {
            InitializeComponent();
            this.formUtama = formUtama;
        }

        private void panelLogin_Click(object sender, EventArgs e)
        {            
            UC_Login uc_login = new UC_Login(formUtama);
            formUtama.panelUtama.Controls.Remove(this);
            formUtama.panelUtama.Controls.Add(uc_login);
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            UC_Login uc_login = new UC_Login(formUtama);
            formUtama.panelUtama.Controls.Remove(this);
            formUtama.panelUtama.Controls.Add(uc_login);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                int idRole;
                if (rdoSiswa.Checked)
                {
                    idRole = 3;
                    Akun.Register_Account(username, password, idRole);
                    Siswa.Insert_Siswa(textBoxData1.Text, dateTimePickerTglLahir.Value, textBoxData3.Text, textBoxData4.Text);

                }
                else if (rdoGuru.Checked)
                {
                    idRole = 2;
                    Akun.Register_Account(username, password, idRole);
                    Guru.Insert_Guru(textBoxData1.Text, textBoxData3.Text, textBoxData4.Text, dateTimePickerTglLahir.Value, textBoxData5.Text);
                }
                else if (rdoPustakawan.Checked)
                {
                    idRole = 4;
                    Akun.Register_Account(username, password, idRole);
                    Pustakawan.Insert_Pustakawan(textBoxData1.Text);
                }
                else
                {
                    idRole = 1;
                }

                MessageBox.Show("Berhasil membuat akun dengan username: " + username);

                Console.WriteLine("[AKUN] MEMBUAT AKUN");
                Console.WriteLine("Username: " + username + "\nRole Id: " + idRole);

                UC_Login uc_login = new UC_Login(formUtama);
                formUtama.panelUtama.Controls.Remove(this);
                formUtama.panelUtama.Controls.Add(uc_login);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void UC_Register_Load(object sender, EventArgs e)
        {
            panelDataPribadi.Enabled = false;
            rdoSiswa.Checked = true;
        }


        #region METHOD
        private void ResetTextBoxToBlank()
        {
            textBoxData1.Clear();
            textBoxData3.Clear();
            textBoxData4.Clear();
            textBoxData5.Clear();            
        }

        private void AturLabelSiswa()
        {
            ResetTextBoxToBlank();
            panelDataPribadi.Visible = true;
            panelDataPribadi.Enabled = true;
            labelData1.Text = "Nama: ";
            labelData2.Text = "TglLahir: ";
            labelData3.Text = "Alamat: ";
            labelData4.Text = "Daftar Email: ";
            labelData5.Visible = false;

            labelData2.Visible = true;
            labelData3.Visible = true;
            labelData4.Visible = true;
            labelData5.Visible = false;

            textBoxData5.Visible = false;
        }

        private void AturLabelGuru()
        {
            ResetTextBoxToBlank();
            panelDataPribadi.Visible = true;
            panelDataPribadi.Enabled = true;
            labelData1.Text = "Nama: ";
            labelData2.Text = "TglLahir: ";
            labelData3.Text = "Daftar Email: ";
            labelData4.Text = "Nomor Telp: ";
            labelData5.Text = "Pendidikan Trkhir";

            textBoxData1.Visible = true;
            textBoxData3.Visible = true;
            textBoxData4.Visible = true;
            textBoxData5.Visible = true;

            labelData2.Visible = true;
            labelData3.Visible = true;
            labelData4.Visible = true;
            labelData5.Visible = true;
        }

        private void AturLabelPustakawan()
        {
            ResetTextBoxToBlank();
            panelDataPribadi.Visible = true;
            panelDataPribadi.Enabled = true;
            labelData1.Text = "Nama: ";
            labelData2.Visible = false;
            labelData3.Visible = false;
            labelData4.Visible = false;
            labelData5.Visible = false;

            dateTimePickerTglLahir.Visible = false;
            textBoxData3.Visible = false;
            textBoxData4.Visible = false;
            textBoxData5.Visible = false;            
        }

        private void rdoSiswa_CheckedChanged(object sender, EventArgs e)
        {
            AturLabelSiswa();
        }

        private void rdoGuru_CheckedChanged(object sender, EventArgs e)
        {
            AturLabelGuru();
        }

        private void rdoPustakawan_CheckedChanged(object sender, EventArgs e)
        {
            AturLabelPustakawan();
        }
        #endregion
    }
}
