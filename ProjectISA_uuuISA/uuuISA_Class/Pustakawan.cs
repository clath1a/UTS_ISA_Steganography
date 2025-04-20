using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class Pustakawan
    {
        #region DATA MEMBER
        int idPustakawan;
        string namaPustakawan;
        Akun idAkun;
        #endregion

        #region CONSTRUCTOR
        public Pustakawan(int idPustakawan, string namaPustakawan, Akun idAkun)
        {
            IdPustakawan = idPustakawan;
            NamaPustakawan = namaPustakawan;
            IdAkun = idAkun;
        }

        public Pustakawan()
        {
            
        }

        #endregion

        #region PROPERTIES
        public int IdPustakawan { get => idPustakawan; set => idPustakawan = value; }
        public string NamaPustakawan { get => namaPustakawan; set => namaPustakawan = value; }
        public Akun IdAkun { get => idAkun; set => idAkun = value; }

        #endregion

        #region METHODS
        public static List<Pustakawan> BacaData(string pFilter, string pData)
        {
            string perintah = "";

            if (pFilter != "" && pData != "")
            {
                perintah = "SELECT * FROM pustakawan WHERE " + pFilter + " = '" + pData + "'";
            }
            else
            {
                perintah = "SELECT * FROM pustakwan";
            }

            List<Pustakawan> listPustakawan = new List<Pustakawan>();
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            while (hasil.Read())
            {
                Pustakawan p = new Pustakawan();
                p.IdPustakawan = int.Parse(hasil.GetValue(0).ToString());
                p.NamaPustakawan = hasil.GetValue(1).ToString();
                p.IdAkun = Akun.BacaData(pData)[0];
                listPustakawan.Add(p);
            }
            return listPustakawan;
        }
        #endregion
    }
}
