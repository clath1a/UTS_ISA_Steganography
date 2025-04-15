using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    internal class Kelas
    {
        int idKelas;
        string nama;
        int kapasitas;
        string lantaiRuangan;
        string jenjang;

        public int IdKelas { get => idKelas; set => idKelas = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public string LantaiRuangan { get => lantaiRuangan; set => lantaiRuangan = value; }
        public string Jenjang { get => jenjang; set => jenjang = value; }
    }
}
