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

            if(dataGridNamaSiswa.Columns.Count == 4 )
            {
                DataGridViewButtonColumn btnEditNilai = new DataGridViewButtonColumn();
                btnEditNilai.Text = "Edit";
                btnEditNilai.HeaderText = "EDIT NILAI";
                btnEditNilai.UseColumnTextForButtonValue = true;
                btnEditNilai.Name = "btnEditNilai";
                dataGridNamaSiswa.Columns.Add(btnEditNilai);
            }
        }

        private void DisplayOnLoad()
        {
            List<Guru_MataPelajaran> list = Guru_MataPelajaran.Select_GuruPengajar(FormUtama.guru.IdGuru);
            dataGridNamaSiswa.DataSource = list;
        }

        private void dataGridNamaSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int editNilaiSiswa = int.Parse(dataGridNamaSiswa.CurrentRow.Cells["idSiswa"].Value.ToString());
                if (e.ColumnIndex == dataGridNamaSiswa.Columns["btnEditNilai"].Index)
                {
                    uc_Utama.panelMain.Controls.Clear();

                    UC_EditNilaiRaportSiswa uc = new UC_EditNilaiRaportSiswa(this, editNilaiSiswa);
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
