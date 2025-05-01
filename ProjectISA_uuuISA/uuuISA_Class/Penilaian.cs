using class_uuuISA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using uuuISA_Class;
using MySqlX.XDevAPI.Relational;

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

        public static void Cetak(string pNamaFile, System.Drawing.Font pTipeFont, int idSiswa)
        {            
            List<DownloadRapot> listRapot = DownloadRapot.BacaData(idSiswa);
            if (listRapot.Count != 0)
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog() { Filter = "PDF File|*.pdf", ValidateNames = true })
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            //proses menulis filetext
                            PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                            doc.Open();
                            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bf, 12);
                            iTextSharp.text.Font fontHeader1 = new iTextSharp.text.Font(bf, 20); 
                            iTextSharp.text.Font fontHeader2 = new iTextSharp.text.Font(bf, 18);

                            Paragraph heading = new Paragraph("RAPOT", fontHeader1);
                            Paragraph heading2 = new Paragraph("Laporan Rapot", fontHeader2);
                            Paragraph pembatas = new Paragraph("==================================================================================", fontNormal);
                            heading.Alignment = Element.ALIGN_CENTER;
                            heading2.Alignment = Element.ALIGN_CENTER;
                            pembatas.Alignment = Element.ALIGN_CENTER;

                            doc.Add(new Paragraph(heading));
                            doc.Add(new Paragraph(heading2));

                            doc.Add(new Paragraph(pembatas));
                            doc.Add(new Paragraph("Nama Siswa: " + listRapot[0].NamaSiswa.ToUpper(), fontNormal));
                            doc.Add(new Paragraph("Kelas: " + listRapot[0].Kelas.ToUpper(), fontNormal));
                            doc.Add(new Paragraph("Guru: " + listRapot[0].WaliKelas.ToUpper(), fontNormal));

                            doc.Add(new Paragraph(pembatas));
                            doc.Add(new Paragraph(""));

                            PdfPTable tabel = new PdfPTable(6);
                            tabel.WidthPercentage = 100;
                            string[] headers = { "Tahun Ajaran", "Semester", "Mata Pelajaran", "Guru Pengampu", "Nilai", "Nisbi" };
                            foreach(string header in headers)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(header));
                                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                                tabel.AddCell(cell);
                            }

                            foreach (var rapot in listRapot)
                            {
                                tabel.AddCell(rapot.TahunAjaran.ToString());
                                tabel.AddCell(rapot.Semester);
                                tabel.AddCell(rapot.NamaMataPelajaran);
                                tabel.AddCell(rapot.NamaGuruMataPelajaran);
                                tabel.AddCell(rapot.Nilai.ToString());
                                tabel.AddCell(rapot.Nisbi);
                            }
                            doc.Add(tabel);

                            doc.Add(new Paragraph(""));
                            doc.Add(new Paragraph(pembatas));
                            doc.Add(new Paragraph(""));
                            doc.Add(new Paragraph("Deskripsi: " + listRapot[0].Deskripsi));
                            doc.Add(new Paragraph(pembatas));
                            doc.Add(new Paragraph(""));
                            doc.Add(new Paragraph(listRapot[0].WaliKelas.ToUpper()));

                            #region Gambar TTD
                            System.Drawing.Image ttdWaliKelas = System.Drawing.Image.FromFile(listRapot[0].TtdWaliKelas);
                            iTextSharp.text.Image imgTTD = iTextSharp.text.Image.GetInstance(ttdWaliKelas, System.Drawing.Imaging.ImageFormat.Png);

                            imgTTD.Alignment = Element.ALIGN_LEFT;
                            doc.Add(imgTTD);
                            doc.Add(new Paragraph(""));
                            #endregion
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            doc.Close();
                        }
                    }
                }
                //proses mencetak ke printer
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
