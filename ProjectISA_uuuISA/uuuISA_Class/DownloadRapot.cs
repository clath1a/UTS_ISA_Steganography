using class_uuuISA;
using MySql.Data.MySqlClient;
using ProjectISA_uuuISA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uuuISA_Class
{
    public class DownloadRapot
    {
        #region DATA FIELD
        private string namaSiswa;       
        private int idMataPelajaran;
        private int idRapot;
        private double nilai;
        private string semester;
        private int tahunAjaran;
        private string deskripsi;
        private int idNisbi;
        #endregion  

        #region CONSTRUCTOR
        public DownloadRapot(string namaSiswa, int idMataPelajaran, int idRapot, double nilai, string semester, int tahunAjaran, string deskripsi, int idNisbi)
        {
            NamaSiswa = namaSiswa;
            IdMataPelajaran = idMataPelajaran;
            IdRapot = idRapot;
            Nilai = nilai;
            Semester = semester;
            TahunAjaran = tahunAjaran;
            Deskripsi = deskripsi;
            IdNisbi = idNisbi;
        }
        #endregion  

        #region PROPERTIES
        public string NamaSiswa { get => namaSiswa; set => namaSiswa = value; }
        public int IdMataPelajaran { get => idMataPelajaran; set => idMataPelajaran = value; }
        public int IdRapot { get => idRapot; set => idRapot = value; }
        public double Nilai { get => nilai; set => nilai = value; }
        public string Semester { get => semester; set => semester = value; }
        public int TahunAjaran { get => tahunAjaran; set => tahunAjaran = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public int IdNisbi { get => idNisbi; set => idNisbi = value; }
        #endregion

        #region METHOD

        public static List<DownloadRapot> BacaData()
        {
            string perintah = "";
            perintah = "select s.nama, p.* " +
                       "from siswa s " +
                       "inner join Rapot r on s.idsiswa = r.siswa_idsiswa " +
                       "inner join penilaian p on r.idRapot = p.idRapot;";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<DownloadRapot> listRapot = new List<DownloadRapot>();
            while (hasil.Read())
            {
                string namaSiswa = hasil.GetValue(0).ToString();
                int idMataPelajaran = int.Parse(hasil.GetValue(1).ToString());
                int idRapot = int.Parse(hasil.GetValue(2).ToString());
                double nilai = double.Parse(hasil.GetValue(3).ToString()); ;
                string semester = hasil.GetValue(4).ToString();
                int tahunAjaran = int.Parse(hasil.GetValue(5).ToString());
                string deskripsi = hasil.GetValue(6).ToString();
                int idNisbi = int.Parse(hasil.GetValue(7).ToString());

                DownloadRapot tampung = new DownloadRapot(namaSiswa, idMataPelajaran, idRapot, nilai, semester, tahunAjaran, deskripsi, idNisbi);

                listRapot.Add(tampung);
            }
            return listRapot;
        }
        #endregion
    }
}
