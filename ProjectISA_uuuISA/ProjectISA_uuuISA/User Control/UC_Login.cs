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
                Console.WriteLine("Current user: "+FormUtama.current_user.Username);

                MessageBox.Show("LOGIN BERHASIL");

                formUtama.panelUtama.Controls.Remove(this);

                UC_Utama uC_Utama = new UC_Utama(formUtama);
                formUtama.panelUtama.Controls.Add(uC_Utama);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
