using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class Nisbi
    {
        #region DATA MEMBER
        int idNisbi;
        string nama;
        string deskripsi;
        double batasNilaiAtas;
        double batasNilaiBawah;
        #endregion

        #region PROPERTIES
        public int IdNisbi { get => idNisbi; set => idNisbi = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public double BatasNilaiAtas { get => batasNilaiAtas; set => batasNilaiAtas = value; }
        public double BatasNilaiBawah { get => batasNilaiBawah; set => batasNilaiBawah = value; }
        #endregion
    }
}
