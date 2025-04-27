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
        public UC_Utama(FormUtama formUtama)
        {
            InitializeComponent();
            this.formUtama = formUtama;
        }

        private void UC_Utama_Load(object sender, EventArgs e)
        {            
            DisplayOnLoad();            
        }

        #region Navigation       

        private void panelButton2_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent2 sesuai dengan fitur role           
            if (FormUtama.current_user.Role.NamaRole == "Admin")
            {
                panelMain.Controls.Clear();
                UC_LogAktivitas uc = new UC_LogAktivitas();
                panelMain.Controls.Add(uc);
            }
            else if (FormUtama.current_user.Role.NamaRole == "Guru")
            {
                panelMain.Controls.Clear();
                UC_InputNilaiRaport uc = new UC_InputNilaiRaport(this);
                panelMain.Controls.Add(uc);
            }
            else if(FormUtama.current_user.Role.NamaRole == "Pustakawan")
            {
                panelMain.Controls.Clear();
                UC_KonfirmasiPeminjamanBuku uc = new UC_KonfirmasiPeminjamanBuku();
                panelMain.Controls.Add(uc);
            }
            else if(FormUtama.current_user.Role.NamaRole == "Siswa")
            {
                panelMain.Controls.Clear();
                UC_DownloadRaport uc = new UC_DownloadRaport();
                panelMain.Controls.Add(uc);
            }

            ResetNavigationBar();
            panelButton2.BackColor = Color.White;
            labelContent2.ForeColor = SystemColors.WindowFrame;
        }

        
        private void labelContent2_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent2 sesuai dengan fitur role
            if (FormUtama.current_user.Role.NamaRole == "Admin")
            {
                panelMain.Controls.Clear();
                UC_LogAktivitas uc = new UC_LogAktivitas();
                panelMain.Controls.Add(uc);
            }
            else if (FormUtama.current_user.Role.NamaRole == "Guru")
            {
                panelMain.Controls.Clear();
                UC_InputNilaiRaport uc = new UC_InputNilaiRaport(this);
                panelMain.Controls.Add(uc);
            }
            else if (FormUtama.current_user.Role.NamaRole == "Pustakawan")
            {
                panelMain.Controls.Clear();
                UC_KonfirmasiPeminjamanBuku uc = new UC_KonfirmasiPeminjamanBuku();
                panelMain.Controls.Add(uc);
            }
            else if (FormUtama.current_user.Role.NamaRole == "Siswa")
            {
                panelMain.Controls.Clear();
                UC_DownloadRaport uc = new UC_DownloadRaport();
                panelMain.Controls.Add(uc);
            }

            ResetNavigationBar();
            panelButton2.BackColor = Color.White;
            labelContent2.ForeColor = SystemColors.WindowFrame;
            
        }

        private void panelButton3_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent3 sesuai dengan fitur role
            if (FormUtama.current_user.Role.NamaRole == "Admin")
            {
                panelMain.Controls.Clear();
                UC_DownloadRaport uc = new UC_DownloadRaport();
                panelMain.Controls.Add(uc);
            }
            else if (FormUtama.current_user.Role.NamaRole == "Guru")
            {
                panelMain.Controls.Clear();
                UC_EditNilaiRaport uc = new UC_EditNilaiRaport(this);
                panelMain.Controls.Add(uc);
            }
            else if (FormUtama.current_user.Role.NamaRole == "Pustakawan")
            {
                panelMain.Controls.Clear();
                UC_LogPeminjaman uc = new UC_LogPeminjaman();
                panelMain.Controls.Add(uc);
            }
            else if (FormUtama.current_user.Role.NamaRole == "Siswa")
            {
                panelMain.Controls.Clear();
                UC_PeminjamanBuku uc = new UC_PeminjamanBuku();
                panelMain.Controls.Add(uc);
            }

            ResetNavigationBar();
            panelButton3.BackColor = Color.White;
            labelContent3.ForeColor = SystemColors.WindowFrame;
            
        }

        private void labelContent3_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent3 sesuai dengan fitur role
            if (FormUtama.current_user.Role.NamaRole == "Admin")
            {

                panelMain.Controls.Clear();
                UC_DownloadRaport uc = new UC_DownloadRaport();
                panelMain.Controls.Add(uc);
            }

            else if (FormUtama.current_user.Role.NamaRole == "Guru")
            {

                panelMain.Controls.Clear();
                UC_EditNilaiRaport uc = new UC_EditNilaiRaport(this);
                panelMain.Controls.Add(uc);
            }
            else if (FormUtama.current_user.Role.NamaRole == "Pustakawan")
            {

                panelMain.Controls.Clear();
                UC_LogPeminjaman uc = new UC_LogPeminjaman();
                panelMain.Controls.Add(uc);
            }
            else if (FormUtama.current_user.Role.NamaRole == "Siswa")
            {

                panelMain.Controls.Clear();
                UC_PeminjamanBuku uc = new UC_PeminjamanBuku();
                panelMain.Controls.Add(uc);
            }

            ResetNavigationBar();
            panelButton3.BackColor = Color.White;
            labelContent3.ForeColor = SystemColors.WindowFrame;            
        }

        private void panelButton4_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent4 sesuai dengan fitur role
            if (FormUtama.current_user.Role.NamaRole == "Guru")
            {
                panelMain.Controls.Clear();
                UC_DownloadRaport uc = new UC_DownloadRaport();
                panelMain.Controls.Add(uc);
            }

            ResetNavigationBar();
            panelButton4.BackColor = Color.White;
            labelContent4.ForeColor = SystemColors.WindowFrame;
            
            
        }        

        private void labelContent4_Click(object sender, EventArgs e)
        {
            //pengecekan role --> labelContent4 sesuai dengan fitur role\
            if (FormUtama.current_user.Role.NamaRole == "Guru")
            {
                panelMain.Controls.Clear();
                UC_DownloadRaport uc = new UC_DownloadRaport();
                panelMain.Controls.Add(uc);
            }

            ResetNavigationBar();
            panelButton4.BackColor = Color.White;
            labelContent4.ForeColor = SystemColors.WindowFrame;
            
        }
        #endregion

        #region Method
        private void DisplayOnLoad()
        {
            this.labelUsername.Text = FormUtama.current_user.Username.ToString();            
            this.labelRole.Text = FormUtama.current_user.Role.NamaRole.ToString();
            Console.WriteLine(FormUtama.current_user.Username.ToString());
            Console.WriteLine(FormUtama.current_user.Role.NamaRole.ToString());

            if (FormUtama.current_user.Role.NamaRole == "Admin")
            {
                SetPanelButtonItem("Log Aktivitas", "Download Raport");
                UC_LogAktivitas uc = new UC_LogAktivitas();
                panelMain.Controls.Add(uc);
            }
            else if (FormUtama.current_user.Role.NamaRole == "Guru")
            {
                SetPanelButtonItem("Isi nilai", "Edit Nilai", "Download Raport");
                UC_InputNilaiRaport uc = new UC_InputNilaiRaport(this);
                panelMain.Controls.Add(uc);
            }
            else if(FormUtama.current_user.Role.NamaRole == "Pustakawan")
            {
                SetPanelButtonItem("Konfirmasi Pinjam", "Log Peminjaman");
                UC_KonfirmasiPeminjamanBuku uc = new UC_KonfirmasiPeminjamanBuku();
                panelMain.Controls.Add(uc);
            }
            else if(FormUtama.current_user.Role.NamaRole == "Siswa")
            {
                SetPanelButtonItem("Download Raport", "Pinjam Buku");
                UC_DownloadRaport uc = new UC_DownloadRaport();
                panelMain.Controls.Add(uc);
            }

            
        }

        private void SetPanelButtonItem(string label1, string label2)
        {
            //Untuk role Admin & Pustakawan
            labelContent2.Text = label1;
            labelContent3.Text = label2;
            panelButton4.Visible = false;
        }

        private void SetPanelButtonItem(string label1, string label2, string label3)
        {
            //Untuk role Guru & Siswa
            labelContent2.Text = label1;
            labelContent3.Text = label2;
            labelContent4.Text = label3;
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ResetNavigationBar()
        {            
            panelButton2.BackColor = Color.Transparent;
            labelContent2.ForeColor = Color.White;
            panelButton3.BackColor = Color.Transparent;
            labelContent3.ForeColor = Color.White;
            panelButton4.BackColor = Color.Transparent;
            labelContent4.ForeColor = Color.White;
        }
        #endregion

        private void panelButton2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
