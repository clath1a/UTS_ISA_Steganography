using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_uuuISA;
using MySql.Data.MySqlClient;
using uuuISA_Class;

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
        private Role role;


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

        public Akun(int idAkun, string username, string password, Role role)
        {
            this.idAkun = idAkun;
            this.username = username;
            this.password = password;
            this.role = role;
        }
        #endregion

        #region PROPERTIES
        public int IdAkun { get => idAkun; set => idAkun = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Role Role { get => role; set => role = value; }
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

        }
        #endregion

        public static Akun User_Login(int idAkun, string password)
        {
            string perintah = "SELECT * FROM akun a INNER JOIN role r ON a.role_idrole = r.idrole " +
                      "WHERE a.idAkun = '" + idAkun + "';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read())
            {
                string storedHash = hasil.GetValue(2).ToString();
                bool isValid = Hashing.VerifyPassword(password, storedHash);
                if (isValid)
                {
                    int id = int.Parse(hasil.GetValue(0).ToString());
                    string username = hasil.GetValue(1).ToString();
                    string pw = hasil.GetValue(2).ToString();

                    // Menyimpan Role
                    int idRole = int.Parse(hasil.GetValue(4).ToString());  // FIXED
                    string namaRole = hasil.GetValue(5).ToString();        // FIXED

                    // Buat objek role
                    Role role = new Role(idRole, namaRole);

                    return new Akun(id, username, pw, role);
                }
            }
            return null; // Return null jika login gagal
        }

        public static bool Register_Account(string username, string password, int idRole)
        {
            string hashed = Hashing.HashPassword(password);
            System.Diagnostics.Debug.WriteLine("[DEBUG] Encrypted Password: " + hashed);
            string perintah = "INSERT INTO `uuuisa`.`akun` (`username`, `password`, `role_idrole`) VALUES ('" + username + "', '" + hashed + "', '" + idRole + "');";
            System.Diagnostics.Debug.WriteLine("[DEBUG] Perintah SQL: " + perintah);

            int hasil = Koneksi.JalankanPerintahDML(perintah);
            if (hasil > 0)
            {
                return true;
            }
            return false;
        }
    }
}
