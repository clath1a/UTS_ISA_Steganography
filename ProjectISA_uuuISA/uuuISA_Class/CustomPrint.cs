using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace uuuISA_Class
{
    public class CustomPrint
    {
        private Font tipeFont;
        private StreamReader namaFile;
        private float kanan, kiri, atas, bawah;

        public CustomPrint(Font tipeFont, string namaFile, float kanan, float kiri, float atas, float bawah)
        {
            TipeFont = tipeFont;
            NamaFile = new StreamReader(namaFile);
            Kanan = kanan;
            Kiri = kiri;
            Atas = atas;
            Bawah = bawah;
        }

        public Font TipeFont { get => tipeFont; set => tipeFont = value; }
        public StreamReader NamaFile { get => namaFile; set => namaFile = value; }
        public float Kanan { get => kanan; set => kanan = value; }
        public float Kiri { get => kiri; set => kiri = value; }
        public float Atas { get => atas; set => atas = value; }
        public float Bawah { get => bawah; set => bawah = value; }

        private void Cetak(object sender, PrintPageEventArgs e)
        {
            float tinggiFont = TipeFont.GetHeight(e.Graphics);
            float y;
            float x = kiri;
            int jumlahBarisSaatIni = 0;
            int maxBarisDalamHalaman = (int)((e.MarginBounds.Height - Atas - Bawah) / tinggiFont);

            //mengambil 1 baris isi file text
            string textCetak = NamaFile.ReadLine();

            while (jumlahBarisSaatIni < maxBarisDalamHalaman && textCetak != null)
            {
                y = Atas + (jumlahBarisSaatIni * tinggiFont);
                //menulis ke memory
                e.Graphics.DrawString(textCetak, TipeFont, Brushes.DarkBlue, x, y);

                jumlahBarisSaatIni++;
                //mengambil 1 baris berikutnya
                textCetak = namaFile.ReadLine();
            }

            if (textCetak != null)
            {
                //jika isi filetext belum habis namun halaman sudah penuh, pindah ke halaman berikutnya
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

        }

        public void KirimKePrinter()
        {
            //proses mencetak ke printer
            PrintDocument p = new PrintDocument();
            p.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            //menulis kke memory untuk tiap halaman
            p.PrintPage += new PrintPageEventHandler(Cetak);
            p.Print();

            NamaFile.Close();
        }

        public void KirimKePrinterRTF()
        {
            //proses mencetak ke printer
            PrintDocument p = new PrintDocument();
            p.PrinterSettings.PrinterName = "Microsoft Print to RTF";

            //menulis kke memory untuk tiap halaman
            p.PrintPage += new PrintPageEventHandler(Cetak);
            p.Print();

            NamaFile.Close();
        }
    }
}
