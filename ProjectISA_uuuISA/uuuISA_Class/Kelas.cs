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
        int guruWaliKelas;
        #endregion

        #region CONSTRUCTOR
        public Kelas()
        {
            this.IdKelas = 1;
            this.Nama = "";
            this.Kapasitas = 0;
            this.LantaiRuangan = "";
            this.Jenjang = "";
            GuruWaliKelas = 1;
        }
        #endregion

        #region PROPERTIES
        public int IdKelas { get => idKelas; set => idKelas = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public string LantaiRuangan { get => lantaiRuangan; set => lantaiRuangan = value; }
        public string Jenjang { get => jenjang; set => jenjang = value; }
        public int GuruWaliKelas { get => guruWaliKelas; set => guruWaliKelas = value; }
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
                obj.GuruWaliKelas = int.Parse(hasil.GetValue(5).ToString());

                listKelas.Add(obj);
            }
            return listKelas;
            #endregion
        }
    }
}
