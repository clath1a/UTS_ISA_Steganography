using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class Buku
    {
        #region DATA MEMBER
        int idBuku;
        string judul;
        string jenis;
        int jumlahHalaman;
        int jumlahBuku;
        string lokasi;
        string bahasa;
        string pengarang;
        #endregion

        #region CONSTRUCTOR
        public Buku(int idBuku, string judul, string jenis, int jumlahHalaman, int jumlahBuku, string lokasi, string bahasa, string pengarang)
        {
            this.IdBuku = idBuku;
            this.Judul = judul;
            this.Jenis = jenis;
            this.JumlahHalaman = jumlahHalaman;
            this.JumlahBuku = jumlahBuku;
            this.Lokasi = lokasi;
            this.Bahasa = bahasa;
            this.Pengarang = pengarang;
        }

        public Buku()
        {

        }

        #endregion

        #region PROPERTIES
        public int IdBuku { get => idBuku; set => idBuku = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Jenis { get => jenis; set => jenis = value; }
        public int JumlahHalaman { get => jumlahHalaman; set => jumlahHalaman = value; }
        public int JumlahBuku { get => jumlahBuku; set => jumlahBuku = value; }
        public string Lokasi { get => lokasi; set => lokasi = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public string Pengarang { get => pengarang; set => pengarang = value; }
        #endregion

        #region METHOD
        public static List<Buku> BacaData()
        {
            string perintah = "SELECT * FROM buku;";

            List<Buku> listBuku = new List<Buku>();
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            Buku buku;

            while(hasil.Read())
            {
                int idBuku = int.Parse(hasil.GetValue(0).ToString());
                string judulBuku = hasil.GetValue(1).ToString();
                string jenisBuku = hasil.GetValue(2).ToString();
                int jumlahHalaman = int.Parse(hasil.GetValue(3).ToString());
                int jumlahBuku = int.Parse(hasil.GetValue(4).ToString());
                string lokasiBuku = hasil.GetValue(5).ToString();
                string bahasaBuku = hasil.GetValue(6).ToString();
                string pengarangBuku = hasil.GetString(7).ToString();

                buku = new Buku(idBuku, judulBuku, jenisBuku, jumlahHalaman, jumlahBuku, lokasiBuku, bahasaBuku, pengarangBuku);
                listBuku.Add(buku);
            }
            return listBuku;
        }

        public static bool Insert_PeminjamanBuku(int idSiswa, int idBuku)
        {
            string perintah = "INSERT INTO riwayat_peminjaman (`siswa_idsiswa`, `buku_idbuku`, `tanggal_peminjaman`, `status_peminjaman_id`) " +
                "VALUES ('" + idSiswa + "', '" + idBuku + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + 1 + "');";
            int hasil = Koneksi.JalankanPerintahDML(perintah);
            if(hasil > 0)
            {
                return true;                
            }
            return false;
        }
        #endregion
    }
}
