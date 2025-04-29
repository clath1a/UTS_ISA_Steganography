using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class Siswa
    {
        #region DATA MEMBER
        int idSiswa;
        string nama;
        DateTime tglLahir;
        string alamatRumah;
        int tahunMasuk;
        string emailSekolah;
        #endregion

        #region CONSTRUCTOR
        public Siswa(int idSiswa, string nama, DateTime tglLahir, string alamatRumah, int tahunMasuk, string emailSekolah)
        {
            this.IdSiswa = idSiswa;
            this.Nama = nama;
            this.TglLahir = tglLahir;
            this.AlamatRumah = alamatRumah;
            this.TahunMasuk = tahunMasuk;
            this.EmailSekolah = emailSekolah;                      
        }

        public Siswa()
        {

        }
        #endregion

        #region PROPERTIES
        public int IdSiswa { get => idSiswa; set => idSiswa = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string AlamatRumah { get => alamatRumah; set => alamatRumah = value; }
        public string EmailSekolah { get => emailSekolah; set => emailSekolah = value; }        
        public int TahunMasuk { get => tahunMasuk; set => tahunMasuk = value; }
        #endregion

        #region METHOD
        public static Siswa BacaData(int idAkun)
        {
            string perintah = "SELECT s.idsiswa, s.nama, s.tanggalLahir, s.alamatRumah, s.tahunMasuk, s.emailSekolah FROM siswa s INNER JOIN akun a ON s.akun_idAkun = a.idAkun WHERE s.akun_idAkun = "+idAkun+";";
            Console.WriteLine(perintah);
            MySqlDataReader dr = Koneksi.JalankanPerintahSelect(perintah);

            Siswa siswa;
            Console.WriteLine("PANGGIL METHOD BACA DATA SISWA");
            if(dr.Read())
            {
                Console.WriteLine("JALANKAN dr.Read()");
                int idSiswa = int.Parse(dr.GetValue(0).ToString());
                string nama = dr.GetValue(1).ToString();
                DateTime tglLahir = DateTime.Parse(dr.GetValue(2).ToString());
                string alamatRumah = dr.GetValue(3).ToString();
                int tahunMasuk = int.Parse(dr.GetValue(4).ToString());
                string email = dr.GetValue(5).ToString();

                siswa = new Siswa(idSiswa, nama, tglLahir, alamatRumah, tahunMasuk, email);
                Console.WriteLine("Data siswa berhasil diambil");
            }
            else
            {
                throw new Exception("Data siswa gagal diambil");
            }
            return siswa;
        }

        public static bool Insert_Siswa(string nama, DateTime tglLahir, string alamatRumah, string emailSekolah)
        {
            int kelas = GetRandomNumber1to3();

            string perintah = "INSERT INTO siswa (nama, tanggalLahir, alamatRumah, tahunMasuk, emailSekolah, akun_idakun, kelas_idkelas) SELECT '" + nama + "', '" + tglLahir.ToString("yyyy-MM-dd") + "', '" + alamatRumah + "', " + DateTime.Now.Year + ", '" + emailSekolah + "@frateran.ac.id', idakun, " + kelas + " FROM akun ORDER BY idakun DESC LIMIT 1;";
            int hasil = Koneksi.JalankanPerintahDML(perintah);
            return hasil > 0;
        }

        private static int GetRandomNumber1to3()
        {
            //untuk merandom kelas secara acak (sementara)
            Random rand = new Random();
            return rand.Next(1, 4);
        }
        #endregion
    }
}
