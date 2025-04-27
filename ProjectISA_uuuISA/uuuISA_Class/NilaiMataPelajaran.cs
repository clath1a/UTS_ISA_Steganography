using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uuuISA_Class
{
    public class NilaiMataPelajaran
    {
        private int idKelas;
        private string namaKelas;
        private int idSiswa;
        private string namaSiswa;
        private int idMapel;
        private string namaMapel;
        private int nilai;

        public NilaiMataPelajaran(int idKelas, string namaKelas, int idSiswa, string namaSiswa, int idMapel, string namaMapel, int nilai)
        {
            IdKelas = idKelas;
            NamaKelas = namaKelas;
            IdSiswa = idSiswa;
            NamaSiswa = namaSiswa;
            IdMapel = idMapel;
            NamaMapel = namaMapel;
            Nilai = nilai;
        }

        public NilaiMataPelajaran() { }

        public int IdKelas { get => idKelas; set => idKelas = value; }
        public string NamaKelas { get => namaKelas; set => namaKelas = value; }
        public int IdSiswa { get => idSiswa; set => idSiswa = value; }
        public string NamaSiswa { get => namaSiswa; set => namaSiswa = value; }
        public string NamaMapel { get => namaMapel; set => namaMapel = value; }
        public int Nilai { get => nilai; set => nilai = value; }
        public int IdMapel { get => idMapel; set => idMapel = value; }

        public static List<NilaiMataPelajaran> Select_NilaiMataPelajaranSiswa(int idGuru, Boolean nilaiNol, int filterIdKelas)
        {
            //nilainol == true --> untuk inputNilai
            //nilainol == false --> edit nilai
            string perintah;
            if(nilaiNol)
            {
                perintah = "SELECT k.idKelas, k.namaKelas, s.idsiswa, s.nama, mp.idmataPelajaran, mp.namaMataPelajaran, p.nilai " +
                    "FROM siswa s " +
                    "INNER JOIN kelas k ON s.kelas_idKelas = k.idKelas " +
                    "INNER JOIN rapot r ON s.idsiswa = r.siswa_idsiswa " +
                    "INNER JOIN penilaian p ON r.idRapot = p.idRapot " +
                    "INNER JOIN matapelajaran mp ON p.idmataPelajaran = mp.idmataPelajaran " +
                    "INNER JOIN matapelajaran_has_guru mpg ON mpg.mataPelajaran_idmataPelajaran = mp.idmataPelajaran " +
                    "INNER JOIN guru g ON mpg.guru_idGuru = g.idGuru " +
                    "WHERE g.idGuru = "+idGuru+" AND p.nilai = 0 AND k.idKelas = "+filterIdKelas+";";
            }
            else
            {
                perintah = "SELECT k.idKelas, k.namaKelas, s.idsiswa, s.nama, mp.idmataPelajaran, mp.namaMataPelajaran, p.nilai " +
                    "FROM siswa s " +
                    "INNER JOIN kelas k ON s.kelas_idKelas = k.idKelas " +
                    "INNER JOIN rapot r ON s.idsiswa = r.siswa_idsiswa " +
                    "INNER JOIN penilaian p ON r.idRapot = p.idRapot " +
                    "INNER JOIN matapelajaran mp ON p.idmataPelajaran = mp.idmataPelajaran " +
                    "INNER JOIN matapelajaran_has_guru mpg ON mpg.mataPelajaran_idmataPelajaran = mp.idmataPelajaran " +
                    "INNER JOIN guru g ON mpg.guru_idGuru = g.idGuru " +
                    "WHERE g.idGuru = " + idGuru + " AND p.nilai != 0 AND k.idKelas = " + filterIdKelas + ";";
            }
            

            List<NilaiMataPelajaran> listNilaiSiswa = new List<NilaiMataPelajaran>();
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            NilaiMataPelajaran nilaiSiswa;
            while (hasil.Read())
            {
                int idKelas = int.Parse(hasil.GetValue(0).ToString());
                string namaKelas = hasil.GetValue(1).ToString();
                int idSiswa = int.Parse(hasil.GetValue(2).ToString());
                string namaSiswa = hasil.GetValue(3).ToString();
                int idMapel = int.Parse(hasil.GetValue(4).ToString());
                string namaMapel = hasil.GetValue(5).ToString();
                int nilai = int.Parse(hasil.GetValue(6).ToString());

                nilaiSiswa = new NilaiMataPelajaran(idKelas, namaKelas,idSiswa,namaSiswa, idMapel,namaMapel, nilai);
                listNilaiSiswa.Add(nilaiSiswa);
            }
            return listNilaiSiswa;
        }

        
    }
}
