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
    public partial class UC_PeminjamanBuku : UserControl
    {
        public UC_PeminjamanBuku()
        {
            InitializeComponent();
        }

        private void DisplayBuku()
        {
            List<Buku> listBuku = Buku.BacaData();
            dataGridViewDaftarBuku.DataSource = listBuku;            
        }

        private void UC_PeminjamanBuku_Load(object sender, EventArgs e)
        {
            DisplayBuku();
            //Console.WriteLine("JUMLAH KOLOM: " + dataGridViewDaftarBuku.Columns.Count);
            if(dataGridViewDaftarBuku.Columns.Count == 8)
            {
                DataGridViewButtonColumn btnPinjam = new DataGridViewButtonColumn();
                btnPinjam.Text = "PINJAM BUKU";
                btnPinjam.HeaderText = "PINJAM";
                btnPinjam.UseColumnTextForButtonValue = true;
                btnPinjam.Name = "btnPinjamBuku";
                dataGridViewDaftarBuku.Columns.Add(btnPinjam);
            }
        }

        private void dataGridViewDaftarBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex == dataGridViewDaftarBuku.Columns["btnPinjamBuku"].Index)
            {
                
            }
        }
    }
}
