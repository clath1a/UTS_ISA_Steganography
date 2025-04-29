using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_uuuISA;

namespace ProjectISA_uuuISA.User_Control
{
    public partial class UC_Login : UserControl
    {
        FormUtama formUtama;
        public UC_Login(FormUtama formUtama)
        {
            InitializeComponent();
            this.formUtama = formUtama;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int idAkun = int.Parse(textBoxUsername.Text);
                string password = textBoxPassword.Text;
                Console.WriteLine(idAkun + ": " + password);

                //login method
                Akun.User_Login(idAkun, password);
                FormUtama.current_user = Akun.User_Login(idAkun, password);
                Console.WriteLine("Current user: " + FormUtama.current_user.Username);
                MessageBox.Show("LOGIN BERHASIL");

                LoadRoleData(idAkun);

                Load_UC_Utama();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #region METHOD
        private void LoadRoleData(int idAkun)
        {
            //LOAD DATA BEDASARKAN ROLE YANG LOGIN
            if (FormUtama.current_user.Role.NamaRole.ToString() == "Siswa")
            {
                FormUtama.siswa = Siswa.BacaData(idAkun);
            }
            else if (FormUtama.current_user.Role.NamaRole.ToString() == "Guru")
            {
                FormUtama.guru = Guru.Select_DataGuru(idAkun);
            }
            else if (FormUtama.current_user.Role.NamaRole.ToString() == "Admin")
            {

            }
            else if (FormUtama.current_user.Role.NamaRole.ToString() == "Pustakawan")
            {
                FormUtama.pustakawan = Pustakawan.BacaData2(idAkun);
            }
        }

        private void Load_UC_Utama()
        {
            formUtama.panelUtama.Controls.Remove(this);
            UC_Utama uC_Utama = new UC_Utama(formUtama);
            formUtama.panelUtama.Controls.Add(uC_Utama);
        }
        #endregion

        private void panelRegister_Click(object sender, EventArgs e)
        {
            UC_Register uC_Register = new UC_Register(formUtama);
            formUtama.panelUtama.Controls.Remove(this);
            formUtama.panelUtama.Controls.Add(uC_Register);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UC_Register uC_Register = new UC_Register(formUtama);
            formUtama.panelUtama.Controls.Remove(this);
            formUtama.panelUtama.Controls.Add(uC_Register);
        }

        private void UC_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
