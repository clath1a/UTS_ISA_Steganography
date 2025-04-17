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
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            Console.WriteLine(username + ": "+password);

            //login method

            formUtama.panelUtama.Controls.Remove(this);

            UC_Utama uC_Utama = new UC_Utama(formUtama);
            formUtama.panelUtama.Controls.Add(uC_Utama);
        }
    }
}
