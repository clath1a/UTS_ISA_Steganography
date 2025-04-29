using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class RiwayatAktivitas
    {
        #region DATA MEMBER        
        DateTime waktuMasuk;
        DateTime waktuKeluar;
        string durasiWaktu;
        int idAkun;
        #endregion

        #region CONSTRUCTOR
        public RiwayatAktivitas(DateTime waktuMasuk, DateTime waktuKeluar, string durasiWaktu, int idAkun)
        {           
            WaktuMasuk = waktuMasuk;
            WaktuKeluar = waktuKeluar;
            DurasiWaktu = durasiWaktu;
            IdAkun = idAkun;
        }

        public RiwayatAktivitas()
        {

        }
        #endregion

        #region PROPERTIES
        public DateTime WaktuMasuk { get => waktuMasuk; set => waktuMasuk = value; }
        public DateTime WaktuKeluar { get => waktuKeluar; set => waktuKeluar = value; }
        public string DurasiWaktu { get => durasiWaktu; set => durasiWaktu = value; }
        public int IdAkun { get => idAkun; set => idAkun = value; }
        #endregion

        public static List<RiwayatAktivitas> BacaData()
        {
            string perintah = "SELECT waktu_masuk, waktu_keluar, durasi_aktif, akun_idAkun FROM uuuisa.riwayat_aktivitas;";

            MySqlDataReader dr = Koneksi.JalankanPerintahSelect(perintah);

            List<RiwayatAktivitas> listRiwayat = new List<RiwayatAktivitas>();
            RiwayatAktivitas riwayat;
            while (dr.Read())
            {
                DateTime waktuMasuk = DateTime.Parse(dr.GetValue(0).ToString());
                DateTime waktuKeluar = DateTime.Parse(dr.GetValue(1).ToString());
                string durasiStr = dr.GetValue(2).ToString(); // Bisa disimpan sebagai string atau TimeSpan
                int idAkun = int.Parse(dr.GetValue(3).ToString());

                riwayat = new RiwayatAktivitas(waktuMasuk, waktuKeluar, durasiStr, idAkun);
                listRiwayat.Add(riwayat);
            }            
            return listRiwayat;
        }

        public static int Select_Latest_IdRiwayat_Aktivitas()
        {
            string perintah = "select idriwayat_aktivitas from riwayat_aktivitas ORDER BY idriwayat_aktivitas DESC LIMIT 1";
            MySqlDataReader dr = Koneksi.JalankanPerintahSelect(perintah);
            int idRiwayat;
            if(dr.Read())
            {
                idRiwayat = int.Parse(dr.GetValue(0).ToString());
            }
            else
            {
                throw new Exception("Belum ada riwayat aktivitas");
            }
            return idRiwayat;
        }

        public static bool Insert_LoginTime(DateTime waktu_masuk, DateTime waktu_keluar, string durasi_aktif, int idAkun)
        {
            string perintah = "INSERT INTO `uuuisa`.`riwayat_aktivitas` (`waktu_masuk`, `waktu_keluar`, `durasi_aktif`, `akun_idAkun`) VALUES ('" + waktu_masuk.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + waktu_keluar.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + durasi_aktif + "', '" + idAkun + "');";
            int hasil = Koneksi.JalankanPerintahDML(perintah);
            return hasil > 0;
        }

        public static bool Update_LogoutTimt(DateTime waktu_keluar, string durasi_aktif, int idRiwayat_aktivitas)
        {
            string perintah = "UPDATE `riwayat_aktivitas` SET `waktu_keluar` = '" + waktu_keluar.ToString("yyyy-MM-dd HH:mm:ss") + "', `durasi_aktif` = '" + durasi_aktif + "' WHERE `idriwayat_aktivitas` = '" + idRiwayat_aktivitas + "';";
            int hasil = Koneksi.JalankanPerintahDML(perintah);
            return hasil > 0;
        }
    }
}
