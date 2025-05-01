using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uuuISA_Class;

namespace ProjectISA_uuuISA
{
    public class Penilaian
    {
        #region DATA MEMBER
        private int idMataPelajaran;
        private int idRapot;
        private double nilai;
        private string semester;
        private int tahunAjaran;
        private string deskripsi;
        private int idNisbi;
        #endregion

        #region CONSTRUCTOR
        public Penilaian(int idMataPelajaran, int idRapot, double nilai, string semester, int tahunAjaran, string deskripsi, int idNisbi)
        {
            IdMataPelajaran = idMataPelajaran;
            IdRapot = idRapot;
            Nilai = nilai;
            Semester = semester;
            TahunAjaran = tahunAjaran;
            Deskripsi = deskripsi;
            IdNisbi = idNisbi;
        }

        public Penilaian(int nilai, string deskripsi_penilaian)
        {
            this.Nilai = nilai;
            this.Deskripsi = deskripsi_penilaian;
        }

        public Penilaian()
        {
            this.Semester = "ganjil";
            this.TahunAjaran = DateTime.Now.Year;
        }
        #endregion

        #region PROPERTIES
        public int IdMataPelajaran { get => idMataPelajaran; set => idMataPelajaran = value; }
        public int IdRapot { get => idRapot; set => idRapot = value; }
        public double Nilai { get => nilai; set => nilai = value; }
        public string Semester { get => semester; set => semester = value; }
        public int TahunAjaran { get => tahunAjaran; set => tahunAjaran = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public int IdNisbi { get => idNisbi; set => idNisbi = value; }
        #endregion

        #region METHOD

        public static bool Update_NilaiRapot(int nilaiBaru, string semester, int tahunAjaran, string deskripsiBaru, int idNisbi, int idMataPelajaran, int idRapot)
        {
            string perintah = "UPDATE `uuuisa`.`penilaian` SET `nilai` = '"+nilaiBaru+ "', `semester` = '"+semester+"', `tahun_ajaran` = '" + tahunAjaran+"', " +
                "`deskripsi_penilaian` = '" + deskripsiBaru+"', `nisbi_idnisbi` = '"+idNisbi+"' " +
                "WHERE (`idmataPelajaran` = '"+idMataPelajaran+"') and (`idRapot` = '"+idRapot+"');";
            int hasil = Koneksi.JalankanPerintahDML(perintah);
            if (hasil > 0)
            {
                return true;
            }
            return false;
        }

        public static void Cetak(string pNamaFile, Font pTipeFont, int idSiswa)
        {            
            List<DownloadRapot> listRapot = DownloadRapot.BacaData(idSiswa);
            if (listRapot.Count != 0)
            {
                //proses menulis filetext
                StreamWriter fileCetak = new StreamWriter(pNamaFile);
                fileCetak.WriteLine("RAPOT");
                fileCetak.WriteLine("Laporan Rapot");
                fileCetak.WriteLine("Nama Siswa: " + listRapot[0].NamaSiswa.ToUpper());
                fileCetak.WriteLine("Kelas: " + listRapot[0].Kelas.ToUpper());
                fileCetak.WriteLine("Guru: " + listRapot[0].WaliKelas.ToUpper());
                fileCetak.WriteLine("-----------------------------------------------------------------------------------");
                fileCetak.WriteLine("");
                fileCetak.WriteLine("Tahun Ajaran\t|\tSemester\t|\tMata Pelajaran\t|\tGuru Pengampu\t|\tNilai\t|\tNisbi");

                for (int i = 0; i < listRapot.Count; i++)
                {
                    fileCetak.WriteLine("  " + listRapot[i].TahunAjaran + "\t|\t" +
                        listRapot[i].Semester + "\t|\t" +
                        listRapot[i].NamaMataPelajaran + "\t|\t" +
                        listRapot[i].NamaGuruMataPelajaran + "\t|\t" +
                        listRapot[i].Nilai.ToString() + "\t|\t" +
                        listRapot[i].Nisbi
                    );
                }

                fileCetak.WriteLine();
                fileCetak.WriteLine("-----------------------------------------------------------------------------------");
                fileCetak.WriteLine("");
                fileCetak.WriteLine("Deskripsi: " + listRapot[0].Deskripsi);
                fileCetak.WriteLine("-----------------------------------------------------------------------------------");
                fileCetak.WriteLine("");
                fileCetak.WriteLine(listRapot[0].WaliKelas.ToUpper());
                //Gambarnya TTD yang sudah di stegano
                fileCetak.Close();

                //proses mencetak ke printer
                CustomPrint p = new CustomPrint(pTipeFont, pNamaFile, 100, 50, 50, 50);
                p.KirimKePrinter();
            }
            else
            {
                throw new Exception("Belum ada data rapot");
            }
        }

        public static void CetakRTF(string pNamaFile, Font pTipeFont, int idSiswa)
        {
            List<DownloadRapot> listRapot = DownloadRapot.BacaData(idSiswa);
            if (listRapot.Count != 0)
            {
                using (StreamWriter fileCetak = new StreamWriter(pNamaFile))
                {
                    // Header RTF
                    fileCetak.WriteLine(@"{\rtf1\ansi\deff0{\fonttbl{\f0 " + pTipeFont.Name + ";}}");
                    fileCetak.WriteLine(@"\b RAPOT \b0");
                    fileCetak.WriteLine(@"\line Laporan Rapot");
                    fileCetak.WriteLine(@"\line Nama Siswa: " + listRapot[0].NamaSiswa.ToUpper());
                    fileCetak.WriteLine(@"\line Kelas: " + listRapot[0].Kelas.ToUpper());
                    fileCetak.WriteLine(@"\line Guru: " + listRapot[0].WaliKelas.ToUpper());
                    fileCetak.WriteLine(@"\line -------------------------------------------------------------------------------");
                    fileCetak.WriteLine(@"\line ");
                    fileCetak.WriteLine(@"\b Tahun Ajaran\t Semester\t Mata Pelajaran\t Guru Pengampu\t Nilai\t Nisbi \b0");

                    // Isi data rapot
                    foreach (var rapot in listRapot)
                    {
                        fileCetak.WriteLine(@"\line   " + rapot.TahunAjaran + "\t " +
                                            rapot.Semester + "\t " +
                                            rapot.NamaMataPelajaran + "\t " +
                                            rapot.NamaGuruMataPelajaran + "\t " +
                                            rapot.Nilai.ToString() + "\t " +
                                            rapot.Nisbi);
                    }

                    // Deskripsi dan footer
                    fileCetak.WriteLine(@"\line ");
                    fileCetak.WriteLine(@"\line -------------------------------------------------------------------------------");
                    fileCetak.WriteLine(@"\line ");
                    fileCetak.WriteLine(@"\line Deskripsi: " + listRapot[0].Deskripsi);
                    fileCetak.WriteLine(@"\line -------------------------------------------------------------------------------");
                    fileCetak.WriteLine(@"\line ");
                    fileCetak.WriteLine(@"\line " + listRapot[0].WaliKelas.ToUpper());
                    fileCetak.WriteLine(@"\line {\pict\pngblip\picw1000\pich1000 " + Convert.ToBase64String(File.ReadAllBytes(listRapot[0].TtdWaliKelas)) + "}");
                    fileCetak.WriteLine(@"}");
                }

                // Proses mencetak ke printer
                CustomPrint p = new CustomPrint(pTipeFont, pNamaFile, 100, 50, 50, 50);
                p.KirimKePrinter();
            }
            else
            {
                throw new Exception("Belum ada data rapot");
            }   
        }
        #endregion
    }
}
