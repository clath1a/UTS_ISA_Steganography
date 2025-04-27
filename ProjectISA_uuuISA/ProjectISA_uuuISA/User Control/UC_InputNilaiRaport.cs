using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uuuISA_Class;

namespace ProjectISA_uuuISA.User_Control
{
    public partial class UC_InputNilaiRaport : UserControl
    {
        UC_Utama uc_Utama;
        public UC_InputNilaiRaport(UC_Utama uc_Utama)
        {
            InitializeComponent();
            this.uc_Utama = uc_Utama;
        }

        private void dataGridViewNamaSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idKelas = int.Parse(dataGridViewKelas.CurrentRow.Cells["idKelas"].Value.ToString());
                if (e.ColumnIndex == dataGridViewKelas.Columns["btnPilihKelas"].Index)
                {
                    uc_Utama.panelMain.Controls.Clear();

                    UC_InputNilaiRaportSiswa uc = new UC_InputNilaiRaportSiswa(this, idKelas, uc_Utama);
                    uc_Utama.panelMain.Controls.Remove(this);
                    uc_Utama.panelMain.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_InputNilaiRaport_Load(object sender, EventArgs e)
        {
            DisplayOnLoad();
        }

        private void DisplayOnLoad()
        {            
            List<Guru_MataPelajaran> list = Guru_MataPelajaran.Select_GuruPengajarBerdasarkanKelas(FormUtama.guru.IdGuru);
            dataGridViewKelas.DataSource = list;

            if (dataGridViewKelas.Columns.Count == 4)
            {
                DataGridViewButtonColumn btnPilihKelas = new DataGridViewButtonColumn();
                btnPilihKelas.Text = "Pilih";
                btnPilihKelas.HeaderText = "Pilih Kelas";
                btnPilihKelas.UseColumnTextForButtonValue = true;
                btnPilihKelas.Name = "btnPilihKelas";
                dataGridViewKelas.Columns.Add(btnPilihKelas);
            }
        }
    }
}
