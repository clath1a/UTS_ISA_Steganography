using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class MataPelajaran
    {
        #region DATA MEMBER
        int idMataPelajaran;
        string nama;
        int durasi;
        string status;

        #endregion

        #region CONSTRUCTOR
        public MataPelajaran(int idMataPelajaran, string nama, int durasi, string status)
        {
            IdMataPelajaran = idMataPelajaran;
            Nama = nama;
            Durasi = durasi;
            Status = status;
        }

        public MataPelajaran()
        {
            
        }
        #endregion

        #region PROPERTIES
        public int IdMataPelajaran { get => idMataPelajaran; set => idMataPelajaran = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public string Status { get => status; set => status = value; }
        #endregion

        #region METHODS
        public static List<MataPelajaran> BacaData()
        {
            string perintah = "SELECT * FROM matapelajaran;";

            List<MataPelajaran> listMataPelajaran = new List<MataPelajaran>();
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            MataPelajaran mataPelajaran;

            while (hasil.Read())
            {
                int idMataPelajaran = int.Parse(hasil.GetValue(0).ToString());
                string nama = hasil.GetValue(1).ToString();
                int durasi = int.Parse(hasil.GetValue(2).ToString());
                string status = hasil.GetValue(3).ToString();

                mataPelajaran = new MataPelajaran(idMataPelajaran, nama, durasi, status);
                listMataPelajaran.Add(mataPelajaran);
            }
            return listMataPelajaran;
        }
        #endregion
    }
}
