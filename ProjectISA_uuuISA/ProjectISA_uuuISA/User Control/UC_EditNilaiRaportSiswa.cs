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
    public partial class UC_EditNilaiRaportSiswa : UserControl
    {
        UC_EditNilaiRaport uc_edit;
        int idSiswa;
        public UC_EditNilaiRaportSiswa(UC_EditNilaiRaport uc_edit, int idSiswa)
        {
            InitializeComponent();
            this.uc_edit = uc_edit;
            this.idSiswa = idSiswa; //diganti query update nilai raport
        }
    }
}
