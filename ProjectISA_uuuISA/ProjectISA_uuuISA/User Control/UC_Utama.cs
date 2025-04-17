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
    public partial class UC_Utama : UserControl
    {
        FormUtama formUtama;
        public static string role = "";
        public UC_Utama(FormUtama formUtama)
        {
            InitializeComponent();
            this.formUtama = formUtama;
        }

        private void UC_Utama_Load(object sender, EventArgs e)
        {
            UC_Home uc_Home = new UC_Home();
            this.panelMain.Controls.Add(uc_Home);

            DetermineRole();
        }

        #region Navigation
        private void panelButtonHome_Click(object sender, EventArgs e)
        {
            UC_Home uc_Home = new UC_Home();
            AddUserControl(uc_Home);
            ResetNavigationBar();
            panelButtonHome.BackColor = Color.White;
            labelbuttonHome.ForeColor = SystemColors.WindowFrame;
        }

        private void labelbuttonHome_Click(object sender, EventArgs e)
        {
            UC_Home uc_Home = new UC_Home();
            AddUserControl(uc_Home);
            ResetNavigationBar();
            panelButtonHome.BackColor = Color.White;
            labelbuttonHome.ForeColor = SystemColors.WindowFrame;
        }        

        private void panelButton2_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent2 sesuai dengan fitur role

            //NOTED: SEMENTARA
            Console.WriteLine("clicked :" + role);
            if(role == "siswa")
            {
                MessageBox.Show("Di sini siswa");
            }
            else if(role == "guru")
            {
                MessageBox.Show("Di sini guru");
            }
            else if(role == "kepala sekolah")
            {
                MessageBox.Show("Di sini kepsek");
            }

            ResetNavigationBar();
            panelButton2.BackColor = Color.White;
            labelContent2.ForeColor = SystemColors.WindowFrame;
        }

        private void labelContent2_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent2 sesuai dengan fitur role
            ResetNavigationBar();
            panelButton2.BackColor = Color.White;
            labelContent2.ForeColor = SystemColors.WindowFrame;
        }

        private void panelButton3_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent3 sesuai dengan fitur role

            //NOTED: SEMENTARA
            Console.WriteLine("clicked :" + role);
            if (role == "siswa")
            {
                MessageBox.Show("Di sini siswa");
            }
            else if (role == "guru")
            {
                MessageBox.Show("Di sini guru");
            }
            else if (role == "kepala sekolah")
            {
                MessageBox.Show("Di sini kepsek");
            }
            ResetNavigationBar();
            panelButton3.BackColor = Color.White;
            labelContent3.ForeColor = SystemColors.WindowFrame;
        }

        private void labelContent3_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent3 sesuai dengan fitur role
            ResetNavigationBar();
            panelButton3.BackColor = Color.White;
            labelContent3.ForeColor = SystemColors.WindowFrame;
        }

        private void panelButton4_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent4 sesuai dengan fitur role

            //NOTED: SEMENTARA
            Console.WriteLine("clicked :" + role);
            if (role == "siswa")
            {
                MessageBox.Show("Di sini siswa");
            }
            else if (role == "guru")
            {
                MessageBox.Show("Di sini guru");
            }
            else if (role == "kepala sekolah")
            {
                MessageBox.Show("Di sini kepsek");
            }
            ResetNavigationBar();
            panelButton4.BackColor = Color.White;
            labelContent4.ForeColor = SystemColors.WindowFrame;
        }        

        private void labelContent4_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent4 sesuai dengan fitur role
            ResetNavigationBar();
            panelButton4.BackColor = Color.White;
            labelContent4.ForeColor = SystemColors.WindowFrame;
        }
        #endregion

        #region Method
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ResetNavigationBar()
        {
            panelButtonHome.BackColor = Color.Transparent;
            labelbuttonHome.ForeColor = Color.White;
            panelButton2.BackColor = Color.Transparent;
            labelContent2.ForeColor = Color.White;
            panelButton3.BackColor = Color.Transparent;
            labelContent3.ForeColor = Color.White;
            panelButton4.BackColor = Color.Transparent;
            labelContent4.ForeColor = Color.White;
        }

        //Sementara
        public int GetRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 4); // 4 tidak termasuk, jadi hasilnya 1, 2, atau 3
        }

        public string DetermineRole()
        {
            int num = GetRandomNumber();
            if (num == 1)
            {
                role = "siswa";
            }
            else if (num == 2)
            {
                role = "guru";
            }
            else
            {
                role = "kepala sekolah";
            }
            Console.WriteLine("= " + role);
            return role;
        }
        #endregion
    }
}
