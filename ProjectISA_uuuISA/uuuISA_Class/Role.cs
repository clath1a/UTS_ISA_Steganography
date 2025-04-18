using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class Role
    {
        #region DATA MEMBER
        int idRole;
        string namaRole;
        private Akun akun;
        #endregion

        #region Constructor
        public Role()
        {
            this.idRole = 1;
            this.namaRole = "";
            Akun = new Akun();
        }

        public Role(int id, string namaRole)
        {
            this.idRole= id;
            this.namaRole = namaRole;
        }
        #endregion

        #region PROPERTIES
        public int IdRole { get => idRole; set => idRole = value; }
        public string NamaRole { get => namaRole; set => namaRole = value; }
        public Akun Akun { get => akun; set => akun = value; }
        #endregion

        #region Method
        public static List<Role> BacaDataRole(string pFilter, string pData)
        {
            string query = "";

            if (pFilter != "" && pData != "")
            {
                query = "SELECT * FROM role WHERE " + pFilter + " = '" + pData + "'";
            }
            else
            {
                query = "SELECT * FROM role";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<Role> listRole = new List<Role>();

            while (hasil.Read())
            {
                Role r = new Role();
                r.IdRole = int.Parse(hasil.GetValue(0).ToString());
                r.NamaRole = hasil.GetValue(1).ToString();
                r.Akun = Akun.BacaData(pData)[0];
                listRole.Add(r);
            }

            return listRole;
        }
        #endregion
    }
}
