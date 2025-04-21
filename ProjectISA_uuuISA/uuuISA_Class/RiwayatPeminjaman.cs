using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uuuISA_Class;

namespace ProjectISA_uuuISA
{
    public class RiwayatPeminjaman
    {
        #region DATA MEMBER
        private int idSiswa;
        private int idBuku;
        private DateTime tanggalPeminjaman;
        private DateTime tanggalPengembalian;
        private int idPustakawan;
        private Status_Peminjaman statusPeminjaman;
        


        #endregion

        #region CONSTUCTOR
        public RiwayatPeminjaman(DateTime tanggalPeminjaman, int idSiswa, int idBuku, Status_Peminjaman status)
        {
            this.TanggalPeminjaman = tanggalPeminjaman;            
            this.IdSiswa = idSiswa;
            this.IdBuku = idBuku;
            this.StatusPeminjaman = status;
        }
        #endregion

        #region PROPERTIES
        public DateTime TanggalPeminjaman { get => tanggalPeminjaman; set => tanggalPeminjaman = value; }
        public DateTime TanggalPengembalian { get => tanggalPengembalian; set => tanggalPengembalian = value; }        
        public Status_Peminjaman StatusPeminjaman { get => statusPeminjaman; set => statusPeminjaman = value; }
        public int IdSiswa { get => idSiswa; set => idSiswa = value; }
        public int IdBuku { get => idBuku; set => idBuku = value; }
        public int IdPustakawan { get => idPustakawan; set => idPustakawan = value; }
        #endregion

        #region METHOD
        public static List<RiwayatPeminjaman> BacaData()
        {           
            string perintah = "SELECT r.siswa_idsiswa, r.buku_idbuku, r.tanggal_peminjaman, sp.id AS status_id, sp.status " +
                "FROM riwayat_peminjaman r  " +
                "inner join status_peminjaman sp on sp.id = r.status_peminjaman_id " +
                "WHERE status_peminjaman_id = 1;";

            MySqlDataReader dr = Koneksi.JalankanPerintahSelect(perintah);

            List<RiwayatPeminjaman> listPeminjaman = new List<RiwayatPeminjaman>();

            while(dr.Read())
            {
                int idSiswa = int.Parse(dr.GetValue(0).ToString());
                int idBuku = int.Parse(dr.GetValue(1).ToString());
                DateTime tglPeminjaman = DateTime.Parse(dr.GetValue(2).ToString());                

                int idStatus = int.Parse(dr.GetValue(3).ToString());
                string status = dr.GetValue(4).ToString();

                Status_Peminjaman statusPeminjaman = new Status_Peminjaman(idStatus, status);
                RiwayatPeminjaman rp = new RiwayatPeminjaman(tglPeminjaman, idSiswa, idBuku, statusPeminjaman);

                listPeminjaman.Add(rp);
            }
            return listPeminjaman;
        }

        public static bool Update_KonfirmasiPeminjamanBuku(int idPustakawan, int idStatus_peminjaman, int idSiswa, int idBuku)
        {
            string perintah = "UPDATE `riwayat_peminjaman` " +
                "SET `pustakawan_idpustakawan` = '" + idPustakawan + "', `status_peminjaman_id` = '" + idStatus_peminjaman + "' " +
                "WHERE (`siswa_idsiswa` = '" + idSiswa + "') and (`buku_idbuku` = '" + idBuku + "');";

            int hasil = Koneksi.JalankanPerintahDML(perintah);
            if (hasil > 0)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
