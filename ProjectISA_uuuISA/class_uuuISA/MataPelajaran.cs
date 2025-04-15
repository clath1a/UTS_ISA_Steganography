using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    internal class MataPelajaran
    {
        int idMataPelajaran;
        string nama;
        int durasi;
        string status;

        public int IdMataPelajaran { get => idMataPelajaran; set => idMataPelajaran = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public string Status { get => status; set => status = value; }
    }
}
