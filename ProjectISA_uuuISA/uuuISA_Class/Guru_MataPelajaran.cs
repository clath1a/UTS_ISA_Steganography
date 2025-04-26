using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uuuISA_Class
{
    public class Guru_MataPelajaran
    {
        private int idSiswa;
        private string namaSiswa;
        private string matapelajaran;
        private string guruPengajar;

        public Guru_MataPelajaran(int idSiswa, string namaSiswa, string matapelajaran, string guruPengajar)
        {
            IdSiswa = idSiswa;
            NamaSiswa = namaSiswa;
            Matapelajaran = matapelajaran;
            GuruPengajar = guruPengajar;
        }

        public int IdSiswa { get => idSiswa; set => idSiswa = value; }
        public string NamaSiswa { get => namaSiswa; set => namaSiswa = value; }
        public string Matapelajaran { get => matapelajaran; set => matapelajaran = value; }
        public string GuruPengajar { get => guruPengajar; set => guruPengajar = value; }

        #region METHOD
        public static List<Guru_MataPelajaran> Select_GuruPengajar(int idGuru)
        {
            string perintah = "SELECT s.idsiswa, s.nama, mp.namaMataPelajaran, g.nama AS `Guru pengajar` " +
                "FROM siswa s INNER JOIN siswa_has_matapelajaran shm ON s.idsiswa = shm.siswa_idsiswa " +
                "INNER JOIN matapelajaran mp ON shm.mataPelajaran_idmataPelajaran = mp.idmataPelajaran " +
                "INNER JOIN matapelajaran_has_guru mpg ON mp.idmataPelajaran = mpg.mataPelajaran_idmataPelajaran " +
                "INNER JOIN guru g ON mpg.guru_idGuru = g.idGuru " +
            "WHERE g.idGuru = '" + idGuru + "';";

            List<Guru_MataPelajaran> ListGuruPengajar = new List<Guru_MataPelajaran>();
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            Guru_MataPelajaran Guru;
            while (hasil.Read())
            {
                

                int idSiswa = int.Parse(hasil.GetValue(0).ToString());
                string namaSiswa = hasil.GetValue(1).ToString();
                string namaMapel = hasil.GetValue(2).ToString();
                string namaGuru = hasil.GetValue(3).ToString();

                Guru = new Guru_MataPelajaran(idSiswa, namaSiswa, namaMapel, namaGuru);
                ListGuruPengajar.Add(Guru);
            }
            return ListGuruPengajar;
        }
        #endregion
    }
}
