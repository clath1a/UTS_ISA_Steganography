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
    public partial class UC_LogPeminjaman : UserControl
    {
        public UC_LogPeminjaman()
        {
            InitializeComponent();
        }

        private void dataGridViewLogPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_LogPeminjaman_Load(object sender, EventArgs e)
        {
            List<RiwayatPeminjaman> listRiwayat = RiwayatPeminjaman.BacaData();
            dataGridViewLogPeminjaman.DataSource = listRiwayat;
        }
    }
}
