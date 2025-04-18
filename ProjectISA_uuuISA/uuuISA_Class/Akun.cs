using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_uuuISA;
using MySql.Data.MySqlClient;

namespace ProjectISA_uuuISA
{
    public class Akun
    {
        #region DATA MEMBER
        private int idAkun;
        private string username;
        private string password;
        private List<Siswa> listSiswa;
        private List<Guru> listGuru;
        private List<Pustakawan> listPustakawan;


        #endregion

        #region CONSTRACTOR
        public Akun()
        {

        }
        public Akun(int idAkun, string username, string password)
        {
            this.idAkun = idAkun;
            this.username = username;
            this.password = password;
        }
        #endregion

        #region PROPERTIES
        public int IdAkun { get => idAkun; set => idAkun = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region METHOD
        static public List<Akun> BacaData(string pUsername = "", string jenis = "")
        {
            string query;
            if (pUsername == "" && jenis == "")
            {
                query = "SELECT * FROM akun";
            }
            else
            {
                query = "SELECT * FROM akun WHERE username LIKE '%" + pUsername + "%'";

            }

            List<Akun> listAkun = new List<Akun>();
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            while (hasil.Read())
            {
                Akun obj = new Akun();
                obj.Username = hasil.GetValue(0).ToString();
                obj.Password = hasil.GetValue(1).ToString();
                obj.listSiswa = new List<Siswa>();
                obj.listGuru = new List<Guru>();
                obj.listPustakawan = new List<Pustakawan>();

                listAkun.Add(obj);
            }
            return listAkun;

            #endregion
        }
    }
}
