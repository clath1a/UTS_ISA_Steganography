using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    internal class RiwayatPeminjaman
    {
        Siswa idSiswa;
        Buku idBuku;
        DateTime tanggalPeminjaman;
        DateTime tanggalPengembalian;
        Pustakawan idPustakawan;

        public DateTime TanggalPeminjaman { get => tanggalPeminjaman; set => tanggalPeminjaman = value; }
        public DateTime TanggalPengembalian { get => tanggalPengembalian; set => tanggalPengembalian = value; }
        internal Siswa IdSiswa { get => idSiswa; set => idSiswa = value; }
        internal Buku IdBuku { get => idBuku; set => idBuku = value; }
        internal Pustakawan IdPustakawan { get => idPustakawan; set => idPustakawan = value; }

        
    }
}
