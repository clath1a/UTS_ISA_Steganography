using ProjectISA_uuuISA.User_Control;
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

namespace ProjectISA_uuuISA
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            /*this.Visible = false;
            try
            {
                //koneksi database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi ke Database Gagal : \n" + ex.Message);
            }*/
            this.Visible = true;

            UC_Login uC = new UC_Login(this);
            panelUtama.Controls.Add(uC);

            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            try
            {
                Koneksi koneksi = new Koneksi(db.Default.DbServer, db.Default.DbName ,db.Default.DbUsername, db.Default.DbPassword);
                MessageBox.Show("Koneksi berhasil", "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal. Pesan Kesalahan: " + ex);
            }
        }

        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelUtama.Controls.Clear();
            panelUtama.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panelUtama_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
