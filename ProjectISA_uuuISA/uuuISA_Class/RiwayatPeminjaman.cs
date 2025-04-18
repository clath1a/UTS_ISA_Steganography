using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class RiwayatPeminjaman
    {
        #region DATA MEMBER
        Siswa idSiswa;
        Buku idBuku;
        DateTime tanggalPeminjaman;
        DateTime tanggalPengembalian;
        Pustakawan idPustakawan;
        #endregion

        #region PROPERTIES
        public DateTime TanggalPeminjaman { get => tanggalPeminjaman; set => tanggalPeminjaman = value; }
        public DateTime TanggalPengembalian { get => tanggalPengembalian; set => tanggalPengembalian = value; }
        public Siswa IdSiswa { get => idSiswa; set => idSiswa = value; }
        public Buku IdBuku { get => idBuku; set => idBuku = value; }
        public Pustakawan IdPustakawan { get => idPustakawan; set => idPustakawan = value; }
        #endregion


    }
}
