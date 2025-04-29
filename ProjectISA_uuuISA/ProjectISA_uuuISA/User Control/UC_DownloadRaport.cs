using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;

namespace ProjectISA_uuuISA.User_Control
{
    public partial class UC_DownloadRaport : UserControl
    {
        public UC_DownloadRaport()
        {
            InitializeComponent();
        }

        private void buttonDownloadRaport_Click(object sender, EventArgs e)
        {
            try
            {                               
                if(FormUtama.current_user.Role.NamaRole.ToString() == "Siswa")
                {
                    string namaSiswa = FormUtama.siswa.Nama.ToString();
                    int idSiswa = FormUtama.siswa.IdSiswa;
                    string namaFile = "[RAPOT] " + namaSiswa;

                    Penilaian.Cetak(namaFile, new Font("Poppins", 12), idSiswa);
                }         
                else
                {
                    MessageBox.Show("[DEV]: FEATURE IN PROGRESS, PLEASE DOWNLOAD AS SISWA");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
