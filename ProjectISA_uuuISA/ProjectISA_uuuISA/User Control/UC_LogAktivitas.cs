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
    public partial class UC_LogAktivitas : UserControl
    {
        public UC_LogAktivitas()
        {
            InitializeComponent();
        }

        private void UC_LogAktivitas_Load(object sender, EventArgs e)
        {
            List<RiwayatAktivitas> listRiwayat = RiwayatAktivitas.BacaData();
            dataGridViewLogAktivitas.DataSource = listRiwayat;
        }

        private void dataGridViewLogAktivitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
