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
        /*private int idSiswa;
        private string namaSiswa;*/
        private int idKelas;
        private string matapelajaran;
        private string guruPengajar;
        private string namaKelas;

        public Guru_MataPelajaran(int idKelas, string matapelajaran, string guruPengajar, string namaKelas)
        {
            IdKelas = idKelas;
            Matapelajaran = matapelajaran;
            GuruPengajar = guruPengajar;
            NamaKelas = namaKelas;
        }

        /*public Guru_MataPelajaran(int idSiswa, string namaSiswa, string matapelajaran, string guruPengajar)
        {
            IdSiswa = idSiswa;
            NamaSiswa = namaSiswa;
            Matapelajaran = matapelajaran;
            GuruPengajar = guruPengajar;
        }*/

        public Guru_MataPelajaran()
        {

        }

        /*public int IdSiswa { get => idSiswa; set => idSiswa = value; }
        public string NamaSiswa { get => namaSiswa; set => namaSiswa = value; }*/
        public int IdKelas { get => idKelas; set => idKelas = value; }
        public string NamaKelas { get => namaKelas; set => namaKelas = value; }
        public string Matapelajaran { get => matapelajaran; set => matapelajaran = value; }
        public string GuruPengajar { get => guruPengajar; set => guruPengajar = value; }
        
        

        #region METHOD
        /*public static List<Guru_MataPelajaran> Select_GuruPengajar(int idGuru)
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
        }*/

        public static List<Guru_MataPelajaran> Select_GuruPengajarBerdasarkanKelas(int idGuru)
        {
            string perintah = "SELECT k.idKelas, k.namaKelas, m.namaMataPelajaran, g.nama " +
                "FROM kelas k INNER JOIN kelas_has_guru kg On k.idkelas = kg.kelas_idkelas " +
                "INNER JOIN guru g ON kg.guru_idGuru = g.idGuru " +
                "INNER JOIN matapelajaran_has_guru mg ON g.idGuru = mg.guru_idGuru " +
                " INNER JOIN matapelajaran m ON mg.matapelajaran_idmatapelajaran = m.idmatapelajaran " +
                " where g.idGuru = " + idGuru + ";";
            List<Guru_MataPelajaran> ListGuruPengajar = new List<Guru_MataPelajaran>();
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            Guru_MataPelajaran Guru;
            while (hasil.Read())
            {
                int idKelas = int.Parse(hasil.GetValue(0).ToString());
                string namaKelas = hasil.GetValue(1).ToString();
                string namaMataPelajaran = hasil.GetValue(2).ToString();
                string namaGuru = hasil.GetValue(3).ToString();

                Guru = new Guru_MataPelajaran(idKelas, namaKelas, namaMataPelajaran, namaGuru);
                ListGuruPengajar.Add(Guru);
            }
            return ListGuruPengajar;
        }

        #endregion
    }
}
