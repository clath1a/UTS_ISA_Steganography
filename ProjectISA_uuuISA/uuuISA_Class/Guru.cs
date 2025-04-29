using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class Guru
    {
        #region DATA MEMBER
        int idGuru;
        string nama;
        string email;
        string nomorTelp;
        DateTime tglLahir;
        string pendidikanTerakhir;
        int idAkun;

        public Guru(int idGuru, string nama, string email, string nomorTelp, DateTime tglLahir, string pendidikanTerakhir)
        {
            IdGuru = idGuru;
            Nama = nama;
            Email = email;
            NomorTelp = nomorTelp;
            TglLahir = tglLahir;
            PendidikanTerakhir = pendidikanTerakhir;
        }

        public Guru(int idGuru, string nama, string email, string nomorTelp, DateTime tglLahir, string pendidikanTerakhir, int idAkun)
        {
            IdGuru = idGuru;
            Nama = nama;
            Email = email;
            NomorTelp = nomorTelp;
            TglLahir = tglLahir;
            PendidikanTerakhir = pendidikanTerakhir;     
            IdAkun = idAkun;
        }

        public Guru()
        {

        }
        #endregion

        #region PROPERTIES
        public int IdGuru { get => idGuru; set => idGuru = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string NomorTelp { get => nomorTelp; set => nomorTelp = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string PendidikanTerakhir { get => pendidikanTerakhir; set => pendidikanTerakhir = value; }
        public int IdAkun { get => idAkun; set => idAkun = value; }
        #endregion

        public static Guru Select_DataGuru(int idAkun)
        {
            string perintah = "SELECT idGuru, nama, email, nomorTlp, tanggalLahir, pendidikanTerakhir " +
                "FROM Guru WHERE akun_idAkun = " + idAkun + "; ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            Guru guru;

            if(hasil.Read())
            {
                int idGuru = int.Parse(hasil.GetValue(0).ToString());
                string nama = hasil.GetValue(1).ToString();
                string email = hasil.GetValue(2).ToString();
                string nomorTelp = hasil.GetValue(3).ToString();
                DateTime tglLahir = DateTime.Parse(hasil.GetValue(4).ToString());
                string pendidikanTerakhir = hasil.GetValue(5).ToString();

                guru = new Guru(idGuru, nama, email,nomorTelp,tglLahir,pendidikanTerakhir);
            }
            else
            {
                throw new Exception("Data guru gagal diambil");
            }
            return guru;
        }

        public static bool Insert_Guru(string nama, string emailSekolah, string nomorTlp, DateTime tglLahir, string pendidikanTerakhir)
        {                        
            string perintah = "INSERT INTO guru (nama, email, nomorTlp, tanggalLahir, pendidikanTerakhir, akun_idakun) SELECT '" + nama + "', '" + emailSekolah + "', '" + nomorTlp + "', '" + tglLahir.ToString("yyyy-MM-dd") + "', '" + pendidikanTerakhir + "', idakun FROM akun ORDER BY idakun DESC LIMIT 1;";

            int hasil = Koneksi.JalankanPerintahDML(perintah);
            return hasil > 0;
        }
    }
}
