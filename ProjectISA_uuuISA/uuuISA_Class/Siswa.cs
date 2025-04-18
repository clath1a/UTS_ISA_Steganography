using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class Siswa
    {
        #region DATA MEMBER
        int idSiswa;
        string nama;
        DateTime tglLahir;
        string alamatRumah;
        string emailSekolah;
        Akun idAkun;
        Kelas idKelas;
        #endregion


        #region PROPERTIES
        public int IdSiswa { get => idSiswa; set => idSiswa = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string AlamatRumah { get => alamatRumah; set => alamatRumah = value; }
        public string EmailSekolah { get => emailSekolah; set => emailSekolah = value; }
        public Akun IdAkun { get => idAkun; set => idAkun = value; }
        public Kelas IdKelas { get => idKelas; set => idKelas = value; }
        #endregion
    }
}
