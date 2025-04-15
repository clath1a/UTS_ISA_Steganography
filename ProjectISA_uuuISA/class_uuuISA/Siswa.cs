using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    internal class Siswa
    {
        int idSiswa;
        string nama;
        DateTime tglLahir;
        string alamatRumah;
        string emailSekolah;
        Akun idAkun;
        Kelas idKelas;

        public int IdSiswa { get => idSiswa; set => idSiswa = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string AlamatRumah { get => alamatRumah; set => alamatRumah = value; }
        public string EmailSekolah { get => emailSekolah; set => emailSekolah = value; }
        internal Akun IdAkun { get => idAkun; set => idAkun = value; }
        internal Kelas IdKelas { get => idKelas; set => idKelas = value; }
    }
}
