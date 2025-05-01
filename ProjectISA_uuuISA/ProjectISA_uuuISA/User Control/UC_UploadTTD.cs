using MySql.Data.MySqlClient;
using PdfSharpCore.Pdf.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace ProjectISA_uuuISA.User_Control
{
    public partial class UC_UploadTTD : UserControl
    {
        Bitmap uploadedImage;
        private const string SecretMessage = "Ini pesan rahasia dari aplikasi.";
        public UC_UploadTTD()
        {
            InitializeComponent();
        }

        private void UC_UploadTTD_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpanTTD_Click(object sender, EventArgs e)
        {
            ProcessAndSaveSignature("TTD");

        }

        private void btnUpploadFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog 
            { 
                Title = "Select a File",
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                Multiselect = false
            };
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = dialog.FileName;

                string fileExtension = System.IO.Path.GetExtension(selectedFilePath).ToLower();

                if (fileExtension == ".png")
                {
                    pictureBoxTTD.ImageLocation = selectedFilePath;
                    uploadedImage = new Bitmap(selectedFilePath);
                    MessageBox.Show("Gambar berhasil di upload, silahkan isi pesan lalu klik button Simpan");
                }
                else
                {
                    MessageBox.Show("Silahkan Upload Gambar sekali lagi");
                }
            }
        }

        private void ProcessAndSaveSignature(string signatureType)
        {
            if (uploadedImage == null)
            {
                MessageBox.Show($"Silakan upload gambar {signatureType} terlebih dahulu.");
                return;
            }

            try
            {
                Bitmap hasilEmbed = Steganography_Raport.EmbedText(SecretMessage, uploadedImage);

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PNG Image|*.png";
                    saveDialog.Title = $"Simpan gambar {signatureType} dengan pesan tersembunyi";
                    saveDialog.FileName = $"hasil_embed_{signatureType.ToLower()}.png";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string savedPath = saveDialog.FileName;
                        hasilEmbed.Save(savedPath, ImageFormat.Png);
                        MessageBox.Show("Pesan berhasil disisipkan dan gambar disimpan.");

                        // Save path to database
                        FormUtama.guru.Ttd = savedPath.Replace("\\", "\\\\");
                        try
                        {
                            Guru.SimpanTTDKeDatabase(FormUtama.guru.Ttd, FormUtama.guru.IdGuru);
                            MessageBox.Show("Path TTD berhasil disimpan ke database.");
                        } catch (Exception ex)
                        {
                            MessageBox.Show("Gagal menyimpan path TTD ke database.\n" + ex);
                        }
                    }
                }
                // Properly dispose the embedded image
                hasilEmbed.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyisipkan pesan pada {signatureType}: " + ex.Message);
            }
        }

        // Dispose pattern implementation
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (uploadedImage != null)
        //        {
        //            uploadedImage.Dispose();
        //            uploadedImage = null;
        //        }
        //    }
        //    base.Dispose(disposing);
        //}


    }
}
