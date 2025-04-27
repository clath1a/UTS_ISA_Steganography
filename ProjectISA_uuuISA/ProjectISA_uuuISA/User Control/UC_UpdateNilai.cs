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
    public partial class UC_UpdateNilai : UserControl
    {
        UC_EditNilaiRaportSiswa uc_edit;
        UC_InputNilaiRaportSiswa uc_input;
        UC_Utama uc_Utama;
        int IdRapot, IdMatapelajaran;
        public UC_UpdateNilai(UC_InputNilaiRaportSiswa uc_Input, int idRapot, int idMataPelajaran)
        {
            InitializeComponent();
            this.uc_input = uc_Input;
            this.IdRapot = idRapot;
            this.IdMatapelajaran = idMataPelajaran;
        }

        public UC_UpdateNilai(UC_EditNilaiRaportSiswa uc_Edit, int idRapot, int idMataPelajaran)
        {
            InitializeComponent();
            this.uc_edit = uc_Edit;
            this.IdRapot = idRapot;
            this.IdMatapelajaran = idMataPelajaran;
        }

        private void UC_UpdateNilai_Load(object sender, EventArgs e)
        {
            DisplayOnLoad();            
        }

        private void DisplayOnLoad()
        {
            Console.WriteLine("[LOAD] ID RAPOT: " + this.IdRapot);
            Console.WriteLine("[LOAD] ID MAPEL: " + this.IdMatapelajaran);

            this.dateTimePickerTahunAjaran.Format = DateTimePickerFormat.Custom;
            dateTimePickerTahunAjaran.CustomFormat = "yyyy";
            dateTimePickerTahunAjaran.ShowUpDown = true;

            rdoGanjil.Checked = true;            
        }

        private void buttonUpdateNilai_Click(object sender, EventArgs e)
        {            
            try
            {
                int nilaiBaru = (int)(numericUpDownNilai.Value);
                int tahunAjaran = dateTimePickerTahunAjaran.Value.Year;
                string deskripsi = richTextBoxDeskripsi.Text;
                string semester = DeterimineSemester();
                int idNisbi = DeterimineNisbiID(nilaiBaru);

                DialogResult result = MessageBox.Show("Anda akan mengubah nilai dengan Id Rapot: " + this.IdRapot, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Penilaian.Update_NilaiRapot(nilaiBaru, semester, tahunAjaran, deskripsi, idNisbi, this.IdMatapelajaran, this.IdRapot);

                    MessageBox.Show("Berhasil Memperbarui nilai");
                }
            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private int DeterimineNisbiID(int nilaiBaru)
        {
            int idNisbi;
            if (nilaiBaru > 90)
            {
                idNisbi = 1;
            }
            else if (nilaiBaru <= 89 && nilaiBaru > 79)
            {
                idNisbi = 2;
            }
            else if (nilaiBaru <= 79 && nilaiBaru > 69)
            {
                idNisbi = 3;
            }
            else if (nilaiBaru <= 69 && nilaiBaru > 59)
            {
                idNisbi = 4;
            }
            else
            {
                idNisbi = 5;
            }
            return idNisbi;
        }

        private string DeterimineSemester()
        {
            string semester="";
            if (rdoGanjil.Checked)
            {
                semester = rdoGanjil.Text;
            }
            else if (rdoGenap.Checked)
            {
                semester = rdoGenap.Text;
            }
            return semester;
        }
    }
}
