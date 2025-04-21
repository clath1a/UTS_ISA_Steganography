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
    public partial class UC_KonfirmasiPeminjamanBuku : UserControl
    {
        public UC_KonfirmasiPeminjamanBuku()
        {
            InitializeComponent();
        }

        private void UC_KonfirmasiPeminjamanBuku_Load(object sender, EventArgs e)
        {
            DisplayPeminjamanMasuk();
            //Console.WriteLine("JUMLAH KOLOM: " + dataGridViewKonfirmasiPeminjamanBuku.Columns.Count);            
            if (dataGridViewKonfirmasiPeminjamanBuku.Columns.Count == 6)
            {
                DataGridViewButtonColumn btnPinjam = new DataGridViewButtonColumn();
                btnPinjam.Text = "TERIMA";
                btnPinjam.HeaderText = "TERIMA";
                btnPinjam.UseColumnTextForButtonValue = true;
                btnPinjam.Name = "btnTerimaPeminjaman";
                dataGridViewKonfirmasiPeminjamanBuku.Columns.Add(btnPinjam);

                DataGridViewButtonColumn btnTolak = new DataGridViewButtonColumn();
                btnTolak.Text = "TOLAK";
                btnTolak.HeaderText = "TOLAK";
                btnTolak.UseColumnTextForButtonValue = true;
                btnTolak.Name = "btnTolakPeminjaman";
                dataGridViewKonfirmasiPeminjamanBuku.Columns.Add(btnTolak);
            }
        }

        private void DisplayPeminjamanMasuk()
        {
            List<RiwayatPeminjaman> riwayatPeminjaman = RiwayatPeminjaman.BacaData();
            dataGridViewKonfirmasiPeminjamanBuku.DataSource = riwayatPeminjaman;
        }

        private void dataGridViewKonfirmasiPeminjamanBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                int idPustakawan = FormUtama.pustakawan.IdPustakawan;
                int idSiswa = (int)(dataGridViewKonfirmasiPeminjamanBuku.CurrentRow.Cells["idSiswa"].Value);
                int idBuku = (int)(dataGridViewKonfirmasiPeminjamanBuku.CurrentRow.Cells["idbuku"].Value);
                
                if (e.ColumnIndex == dataGridViewKonfirmasiPeminjamanBuku.Columns["btnTerimaPeminjaman"].Index)
                {                    
                    DialogResult result = MessageBox.Show("Anda akan menerima permintaan peminjaman buku" + idBuku, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        RiwayatPeminjaman.Update_KonfirmasiPeminjamanBuku(idPustakawan, 2, idSiswa, idBuku);
                        MessageBox.Show("Permintaan diterima");
                    }
                }
                else if(e.ColumnIndex == dataGridViewKonfirmasiPeminjamanBuku.Columns["btnTolakPeminjaman"].Index)
                {
                    DialogResult result = MessageBox.Show("Anda akan menolak permintaan peminjaman buku" + idBuku, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        RiwayatPeminjaman.Update_KonfirmasiPeminjamanBuku(idPustakawan, 3, idSiswa, idBuku);
                        MessageBox.Show("Permintaan ditolak");
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
