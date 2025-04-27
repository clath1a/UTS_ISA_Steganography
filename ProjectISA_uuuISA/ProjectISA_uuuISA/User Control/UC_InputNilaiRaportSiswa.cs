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
    public partial class UC_InputNilaiRaportSiswa : UserControl
    {
        UC_Utama uc_Utama;
        UC_InputNilaiRaport uc_input;
        int idKelas;
        public UC_InputNilaiRaportSiswa(UC_InputNilaiRaport uc_input, int idKelas, UC_Utama uc_Utama)
        {
            InitializeComponent();
            this.uc_input = uc_input;
            this.idKelas = idKelas;
            this.uc_Utama = uc_Utama;
        }

        private void UC_InputNilaiRaportSiswa_Load(object sender, EventArgs e)
        {
            DisplayOnLoad();
        }

        private void DisplayOnLoad()
        {
            List<NilaiMataPelajaran> listNilai = NilaiMataPelajaran.Select_NilaiMataPelajaranSiswa(FormUtama.guru.IdGuru, true, this.idKelas);
            dataGridNilai.DataSource = listNilai;

            if (dataGridNilai.Columns.Count == 8)
            {
                DataGridViewButtonColumn btnInputNilai = new DataGridViewButtonColumn();
                btnInputNilai.Text = "Input";
                btnInputNilai.HeaderText = "INPUT NILAI";
                btnInputNilai.UseColumnTextForButtonValue = true;
                btnInputNilai.Name = "btnInputNilai";
                dataGridNilai.Columns.Add(btnInputNilai);
            }
        }

        private void dataGridNilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idRapot = (int)(dataGridNilai.CurrentRow.Cells["idRapot"].Value);
                int idMataPelajaran = (int)(dataGridNilai.CurrentRow.Cells["idMapel"].Value);
                if (e.ColumnIndex == dataGridNilai.Columns["btnInputNilai"].Index)
                {
                    uc_Utama.panelMain.Controls.Clear();

                    UC_UpdateNilai uc = new UC_UpdateNilai(this, idRapot, idMataPelajaran);
                    uc_Utama.panelMain.Controls.Remove(this);
                    uc_Utama.panelMain.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
