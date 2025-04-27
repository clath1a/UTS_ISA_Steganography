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
        UC_Login uc_Login;
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
                }
                else if (rdoGuru.Checked)
                {
                    idRole = 2;
                }
                else if (rdoPustakawan.Checked)
                {
                    idRole = 4;
                }
                else
                {
                    idRole = 1;
                }

                Akun.Register_Account(username, password, idRole);
                MessageBox.Show("Berhasil membuat akun dengan username: " + username);

                Console.WriteLine("[AKUN] MEMBUAT AKUN");
                Console.WriteLine("Username: "+username+"\nRole Id:"+idRole);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
    }
}
