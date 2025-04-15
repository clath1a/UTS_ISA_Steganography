using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    internal class Guru
    {
        int idGuru;
        string nama;
        string email;
        string nomorTelp;
        DateTime tglLahir;
        string pendidikanTerakhir;
        Akun idAkun;

        public int IdGuru { get => idGuru; set => idGuru = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string NomorTelp { get => nomorTelp; set => nomorTelp = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string PendidikanTerakhir { get => pendidikanTerakhir; set => pendidikanTerakhir = value; }
        internal Akun IdAkun { get => idAkun; set => idAkun = value; }
    }
}
