using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace uuuISA_Class
{
    public class RtfToPdf
    {
        private string rtfFilePath;

        public RtfToPdf(string rtfPath)
        {
            rtfFilePath = rtfPath;
        }

        public void SaveAsPdf(string outputPdfPath)
        {
            // Load RTF file into RichTextBox
            RichTextBox rtb = new RichTextBox();
            rtb.LoadFile(rtfFilePath);

            // Set up PrintDocument
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF"; // Using Microsoft Print to PDF
            printDoc.PrinterSettings.PrintToFile = true; // Enable saving as a file
            printDoc.PrinterSettings.PrintFileName = outputPdfPath;

            // Attach printing logic
            printDoc.PrintPage += (sender, e) =>
            {
                e.Graphics.DrawString(rtb.Text, new Font("Poppins", 12), Brushes.Black, e.MarginBounds);
            };

            // Trigger printing
            printDoc.Print();
        }
    }
}

