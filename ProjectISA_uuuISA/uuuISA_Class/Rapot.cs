using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uuuISA_Class;

namespace ProjectISA_uuuISA
{
    public class Rapot
    {
        #region DATA MEMBER
        int idRapot;
        Siswa idSiswa;
        #endregion

        #region PROPERTIES
        public int IdRapot { get => idRapot; set => idRapot = value; }
        public Siswa IdSiswa { get => idSiswa; set => idSiswa = value; }
        #endregion
    }
}
