using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class Kelas
    {
        #region DATA MEMBER
        int idKelas;
        string nama;
        int kapasitas;
        string lantaiRuangan;
        string jenjang;
        #endregion

        #region CONSTRACTOR
        public Kelas()
        {
            this.idKelas = 1;
            this.nama = "";
            this.kapasitas = 0;
            this.lantaiRuangan = "";
            this.jenjang = "";
        }
        #endregion

        #region PROPERTIES
        public int IdKelas { get => idKelas; set => idKelas = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public string LantaiRuangan { get => lantaiRuangan; set => lantaiRuangan = value; }
        public string Jenjang { get => jenjang; set => jenjang = value; }
        #endregion

        #region METHODS
        static public List<Kelas> BacaData(string pUsername = "", string jenis = "")
        {
            string query;
            if (pUsername == "" && jenis == "")
            {
                query = "SELECT * FROM kelas";
            }
            else
            {
                query = "SELECT * FROM kelas WHERE username LIKE '%" + pUsername + "%'";

            }

            List<Kelas> listKelas = new List<Kelas>();
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            while (hasil.Read())
            {
                Kelas obj = new Kelas();
                obj.IdKelas = int.Parse(hasil.GetValue(0).ToString());
                obj.Nama = hasil.GetValue(1).ToString();
                obj.Kapasitas = int.Parse(hasil.GetValue(2).ToString());
                obj.LantaiRuangan = hasil.GetValue(3).ToString();
                obj.Jenjang = hasil.GetValue(4).ToString();

                listKelas.Add(obj);
            }
            return listKelas;
            #endregion
        }
    }
}
