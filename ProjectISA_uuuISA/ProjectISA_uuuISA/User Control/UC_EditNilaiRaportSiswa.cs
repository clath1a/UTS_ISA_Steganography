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
    public partial class UC_EditNilaiRaportSiswa : UserControl
    {
        UC_EditNilaiRaport uc_edit;
        int idKelas;
        public UC_EditNilaiRaportSiswa(UC_EditNilaiRaport uc_edit, int idKelas)
        {
            InitializeComponent();
            this.uc_edit = uc_edit;
            this.idKelas = idKelas;
        }

        private void UC_EditNilaiRaportSiswa_Load(object sender, EventArgs e)
        {
            DisplayOnLoad();
        }

        private void DisplayOnLoad()
        {
            List<NilaiMataPelajaran> listNilai = NilaiMataPelajaran.Select_NilaiMataPelajaranSiswa(FormUtama.guru.IdGuru, false, this.idKelas);
            dataGridNilai.DataSource = listNilai;

            if(dataGridNilai.Columns.Count == 7 )
            {
                DataGridViewButtonColumn btnEditNilai = new DataGridViewButtonColumn();
                btnEditNilai.Text = "Edit";
                btnEditNilai.HeaderText = "EDIT NILAI";
                btnEditNilai.UseColumnTextForButtonValue = true;
                btnEditNilai.Name = "btnEditNilai";
                dataGridNilai.Columns.Add(btnEditNilai);
            }
        }
    }
}
