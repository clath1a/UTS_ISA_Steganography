using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    internal class Buku
    {
        int idBuku;
        string judul;
        string jenis;
        int jumlahHalaman;
        int jumlahBuku;
        string lokasi;
        string bahasa;
        string pengarang;

        public int IdBuku { get => idBuku; set => idBuku = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Jenis { get => jenis; set => jenis = value; }
        public int JumlahHalaman { get => jumlahHalaman; set => jumlahHalaman = value; }
        public int JumlahBuku { get => jumlahBuku; set => jumlahBuku = value; }
        public string Lokasi { get => lokasi; set => lokasi = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public string Pengarang { get => pengarang; set => pengarang = value; }
    }
}
