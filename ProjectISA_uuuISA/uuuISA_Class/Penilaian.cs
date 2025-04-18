using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class Penilaian
    {
        #region DATA MEMBER
        MataPelajaran idMataPelajaran;
        Rapot idRapot;
        double nilai;
        string semester;
        int tahunAjaran;
        string deskripsi;
        Nisbi idNisbi;
        #endregion

        #region PROPERTIES
        public double Nilai { get => nilai; set => nilai = value; }
        public string Semester { get => semester; set => semester = value; }
        public int TahunAjaran { get => tahunAjaran; set => tahunAjaran = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public MataPelajaran IdMataPelajaran { get => idMataPelajaran; set => idMataPelajaran = value; }
        public Rapot IdRapot { get => idRapot; set => idRapot = value; }
        public Nisbi IdNisbi { get => idNisbi; set => idNisbi = value; }
        #endregion
    }
}
