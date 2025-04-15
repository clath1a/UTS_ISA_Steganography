using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    internal class Penilaian
    {
        MataPelajaran idMataPelajaran;
        Rapot idRapot;
        double nilai;
        string semester;
        int tahunAjaran;
        string deskripsi;
        Nisbi idNisbi;

        public double Nilai { get => nilai; set => nilai = value; }
        public string Semester { get => semester; set => semester = value; }
        public int TahunAjaran { get => tahunAjaran; set => tahunAjaran = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        internal MataPelajaran IdMataPelajaran { get => idMataPelajaran; set => idMataPelajaran = value; }
        internal Rapot IdRapot { get => idRapot; set => idRapot = value; }
        internal Nisbi IdNisbi { get => idNisbi; set => idNisbi = value; }
    }
}
