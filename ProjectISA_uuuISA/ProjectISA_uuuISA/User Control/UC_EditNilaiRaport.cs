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
    public partial class UC_EditNilaiRaport : UserControl
    {
        UC_Utama uc_Utama;
        public UC_EditNilaiRaport(UC_Utama uc)
        {
            InitializeComponent();
            this.uc_Utama = uc;
        }

        private void UC_EditNilaiRaport_Load(object sender, EventArgs e)
        {
            DisplayOnLoad();

            if(dataGridNamaKelas.Columns.Count == 4 )
            {
                DataGridViewButtonColumn btnPilihKelas = new DataGridViewButtonColumn();
                btnPilihKelas.Text = "Pilih";
                btnPilihKelas.HeaderText = "Pilih Kelas";
                btnPilihKelas.UseColumnTextForButtonValue = true;
                btnPilihKelas.Name = "btnPilihKelas";
                dataGridNamaKelas.Columns.Add(btnPilihKelas);
            }
        }

        private void DisplayOnLoad()
        {            
            List<Guru_MataPelajaran> list = Guru_MataPelajaran.Select_GuruPengajarBerdasarkanKelas(FormUtama.guru.IdGuru);            
            dataGridNamaKelas.DataSource = list;
        }

        private void dataGridNamaSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idKelas = int.Parse(dataGridNamaKelas.CurrentRow.Cells["idKelas"].Value.ToString());
                if (e.ColumnIndex == dataGridNamaKelas.Columns["btnPilihKelas"].Index)
                {
                    uc_Utama.panelMain.Controls.Clear();

                    UC_EditNilaiRaportSiswa uc = new UC_EditNilaiRaportSiswa(this, idKelas);
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
