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
        private int idRapot;
        private string namaSiswa;       
        private string namaMataPelajaran;
        private double nilai;
        private string semester;
        private int tahunAjaran;
        private string deskripsi;
        private string nisbi;
        private string kelas;
        private string namaGuruMataPelajaran;
        private string waliKelas;
        private string ttdWaliKelas;
        #endregion  

        #region CONSTRUCTOR
        public DownloadRapot(string namaSiswa, string namaMataPelajaran, int idRapot, double nilai, string semester, int tahunAjaran, string deskripsi, string nisbi, string kelas, string namaGuruMataPelajaran, string waliKelas, string ttdWaliKelas)
        {
            NamaSiswa = namaSiswa;
            NamaMataPelajaran = namaMataPelajaran;
            IdRapot = idRapot;
            Nilai = nilai;
            Semester = semester;
            TahunAjaran = tahunAjaran;
            Deskripsi = deskripsi;
            Nisbi = nisbi;
            Kelas = kelas;
            NamaGuruMataPelajaran = namaGuruMataPelajaran;
            WaliKelas = waliKelas;
            TtdWaliKelas = ttdWaliKelas;
        }
        #endregion

        #region PROPERTIES
        public int IdRapot { get => idRapot; set => idRapot = value; }
        public string NamaSiswa { get => namaSiswa; set => namaSiswa = value; }
        public string NamaMataPelajaran { get => namaMataPelajaran; set => namaMataPelajaran = value; }
        public double Nilai { get => nilai; set => nilai = value; }
        public string Semester { get => semester; set => semester = value; }
        public int TahunAjaran { get => tahunAjaran; set => tahunAjaran = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public string Nisbi { get => nisbi; set => nisbi = value; }
        public string Kelas { get => kelas; set => kelas = value; }
        public string NamaGuruMataPelajaran { get => namaGuruMataPelajaran; set => namaGuruMataPelajaran = value; }
        public string WaliKelas { get => waliKelas; set => waliKelas = value; }
        public string TtdWaliKelas { get => ttdWaliKelas; set => ttdWaliKelas = value; }
        #endregion

        #region METHOD
        //yg baru
        public static List<DownloadRapot> BacaData(int idSiswa)
        {
            string perintah = "";
            perintah = "SELECT r.idRapot, s.nama AS nama_siswa, mp.namaMataPelajaran, p.nilai, p.semester, p.tahun_ajaran, p.deskripsi_penilaian, n.nama AS nisbi, k.namaKelas, g.nama AS guru_pengampu, wg.nama AS wali_kelas, wg.ttd AS ttd_wali_kelas " +
                        "FROM siswa s " +
                        "INNER JOIN Rapot r ON s.idsiswa = r.siswa_idsiswa " +
                        "INNER JOIN penilaian p ON r.idRapot = p.idRapot " + 
                        "INNER JOIN matapelajaran mp ON p.idmataPelajaran = mp.idmataPelajaran " +
                        "INNER JOIN nisbi n ON p.nisbi_idnisbi = n.idnisbi " +
                        "INNER JOIN kelas k ON s.kelas_idkelas = k.idkelas " +
                        "INNER JOIN kelas_has_guru kg ON k.idkelas = kg.kelas_idkelas " +
                        "INNER JOIN guru g ON kg.guru_idGuru = g.idGuru " +
                        "LEFT JOIN guru wg ON k.walikelas = wg.idGuru " +
                        "WHERE s.idsiswa = "+idSiswa+";" ;

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<DownloadRapot> listRapot = new List<DownloadRapot>();
            while (hasil.Read())
            {
                int idRapot = int.Parse(hasil.GetValue(0).ToString());
                string namaSiswa = hasil.GetValue(1).ToString();
                string namaMataPelajaran = hasil.GetValue(2).ToString();
                double nilai = double.Parse(hasil.GetValue(3).ToString());
                string semester = hasil.GetValue(4).ToString();
                int tahunAjaran = int.Parse(hasil.GetValue(5).ToString());
                string deskripsi = hasil.GetValue(6).ToString();
                string nisbi = hasil.GetValue(7).ToString();
                string kelas = hasil.GetValue(8).ToString();
                string namaGuruMataPelajaran = hasil.GetValue(9).ToString();
                string waliKelas = hasil.GetValue(10).ToString();
                string ttdWaliKelas = hasil.GetValue(11).ToString();

                DownloadRapot tampung = new DownloadRapot(namaSiswa, namaMataPelajaran, idRapot, nilai, semester,
                    tahunAjaran, deskripsi, nisbi, kelas, namaGuruMataPelajaran, waliKelas, ttdWaliKelas);

                listRapot.Add(tampung);
            }
            return listRapot;
        }
        #endregion
    }
}
