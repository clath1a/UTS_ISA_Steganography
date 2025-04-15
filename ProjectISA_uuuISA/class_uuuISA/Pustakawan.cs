using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    internal class Pustakawan
    {
        int idPustakawan;
        string nama;
        Akun idAkun;

        public int IdPustakawan { get => idPustakawan; set => idPustakawan = value; }
        public string Nama { get => nama; set => nama = value; }
        internal Akun IdAkun { get => idAkun; set => idAkun = value; }
    }
}
