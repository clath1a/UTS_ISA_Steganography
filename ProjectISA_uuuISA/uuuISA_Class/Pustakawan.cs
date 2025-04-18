using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class Pustakawan
    {
        #region DATA MEMBER
        int idPustakawan;
        string nama;
        Akun idAkun;
        #endregion

        #region
        public int IdPustakawan { get => idPustakawan; set => idPustakawan = value; }
        public string Nama { get => nama; set => nama = value; }
        public Akun IdAkun { get => idAkun; set => idAkun = value; }
        #endregion
    }
}
