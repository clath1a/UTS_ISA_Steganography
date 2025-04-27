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
        UC_InputNilaiRaport uc_input;
        int idKelas;
        public UC_InputNilaiRaportSiswa(UC_InputNilaiRaport uc_input, int idKelas)
        {
            InitializeComponent();
            this.uc_input = uc_input;
            this.idKelas = idKelas;
        }

        private void UC_InputNilaiRaportSiswa_Load(object sender, EventArgs e)
        {
            DisplayOnLoad();
        }

        private void DisplayOnLoad()
        {
            List<NilaiMataPelajaran> listNilai = NilaiMataPelajaran.Select_NilaiMataPelajaranSiswa(FormUtama.guru.IdGuru, true, this.idKelas);
            dataGridNilai.DataSource = listNilai;

            if (dataGridNilai.Columns.Count == 7)
            {
                DataGridViewButtonColumn btnInputNilai = new DataGridViewButtonColumn();
                btnInputNilai.Text = "Input";
                btnInputNilai.HeaderText = "INPUT NILAI";
                btnInputNilai.UseColumnTextForButtonValue = true;
                btnInputNilai.Name = "btnInputNilai";
                dataGridNilai.Columns.Add(btnInputNilai);
            }
        }
    }
}
