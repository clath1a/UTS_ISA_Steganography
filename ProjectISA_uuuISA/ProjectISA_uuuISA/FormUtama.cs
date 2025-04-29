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
using System.Diagnostics;

namespace ProjectISA_uuuISA
{
    public partial class FormUtama : Form
    {
        
        public static Akun current_user = new Akun();
        public static Siswa siswa = new Siswa();
        public static Pustakawan pustakawan = new Pustakawan();
        public static Guru guru = new Guru();

        #region LOGIN DURATION
        public Stopwatch stopwatch = new Stopwatch();
        public static DateTime waktu_masuk;
        public static DateTime waktu_keluar;
        public static int idRiwayat_aktivitas;
        #endregion

        #region AUTO LOGOUT DURATION
        private DateTime lastActivity;
        private Timer idleTimer = new Timer();
        private int idleLimitSeconds = 600;
        #endregion

        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            UC_Login uC = new UC_Login(this);
            panelUtama.Controls.Add(uC);

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
            this.Visible = true;

            lastActivity = DateTime.Now;
            RegisterActivityEvents();

            idleTimer.Interval = 1000; // 1 detik
            idleTimer.Tick += IdleTimer_Tick;
            idleTimer.Start();
            stopwatch.Start();
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

        private void FormUtama_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopwatch.Stop();
            TimeSpan durasi = stopwatch.Elapsed;
            string waktu = durasi.ToString(@"hh\:mm\:ss"); 

            RiwayatAktivitas.Update_LogoutTimt(DateTime.Now, waktu, idRiwayat_aktivitas);
            Console.WriteLine("DURASI LOGIN: "+waktu);
        }
        #region METHOD AUTO LOGOUT
        protected override void WndProc(ref Message m)
        {
            const int WM_MOUSEMOVE = 0x0200;
            const int WM_KEYDOWN = 0x0100;

            if (m.Msg == WM_MOUSEMOVE || m.Msg == WM_KEYDOWN)
            {
                lastActivity = DateTime.Now;
            }

            base.WndProc(ref m);
        }

        private void IdleTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan idleTime = DateTime.Now - lastActivity;

            if (idleTime.TotalSeconds >= idleLimitSeconds)
            {
                idleTimer.Stop(); // hentikan timer

                stopwatch.Stop();
                TimeSpan durasi = stopwatch.Elapsed;
                string waktu = durasi.ToString(@"hh\:mm\:ss");

                // update ke database
                RiwayatAktivitas.Update_LogoutTimt(DateTime.Now, waktu, idRiwayat_aktivitas);
                MessageBox.Show("Anda telah logout otomatis karena tidak ada aktivitas selama 10 menit.");

                this.Close(); // keluar dari form utama
            }
        }

        private void RegisterActivityEvents()
        {
            this.MouseMove += AnyActivity;
            this.KeyDown += AnyActivity;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.MouseMove += AnyActivity;
                ctrl.KeyDown += AnyActivity;
            }
        }

        private void AnyActivity(object sender, EventArgs e)
        {
            lastActivity = DateTime.Now;
        }
        #endregion

    }
}
