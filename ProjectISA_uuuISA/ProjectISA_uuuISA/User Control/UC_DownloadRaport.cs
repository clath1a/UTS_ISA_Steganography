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
            int idAkun = FormUtama.current_user.IdAkun;
            try
            {
                
                comboBoxPilihSiswa.DataSource = Siswa.BacaSemuaData();
                comboBoxPilihSiswa.DisplayMember = "Nama";     // Yang ditampilkan di ComboBox
                comboBoxPilihSiswa.ValueMember = "IdSiswa";    // Nilai yang disimpan di balik layar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data siswa: " + ex.Message);
            }


        }

        private void buttonDownloadRaport_Click(object sender, EventArgs e)
        {
            try
            {
                if(FormUtama.current_user.Role.NamaRole == "Siswa")
                {
                    string namaFile = "[RAPOT] " + FormUtama.siswa.IdSiswa;
                    Penilaian.Cetak(namaFile, new Font("Poppins", 12), FormUtama.siswa.IdSiswa);
                }
                if (FormUtama.current_user.Role.NamaRole == "Guru" ||
                    FormUtama.current_user.Role.NamaRole == "Admin")
                {
                    if(comboBoxPilihSiswa.SelectedItem is Siswa selectedSiswa)
                    {
                        string namaFile = "[RAPOT] " + selectedSiswa.Nama;
                        Penilaian.Cetak(namaFile, new Font("Poppins", 12), selectedSiswa.IdSiswa);
                    }
                }
                else
                {
                    MessageBox.Show("Role tidak dikenali");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void comboBoxPilihSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
