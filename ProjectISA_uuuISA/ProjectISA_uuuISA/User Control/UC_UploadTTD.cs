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
        OpenFileDialog fileDialog;
        Bitmap uploadedImage;
        private const string SecretMessage = "Ini pesan rahasia dari aplikasi.";
        public UC_UploadTTD()
        {
            InitializeComponent();
        }

        private void UC_UploadTTD_Load(object sender, EventArgs e)
        {
            //pictureBoxTTD.Image = null;
        }

        private void buttonUploadTTD_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
            openDialog.InitialDirectory = @"C:\Users\metech\Desktop";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text  = openDialog.FileName.ToString();
                pictureBoxTTD.ImageLocation = textBox1.Text;
            }
            /*try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Title = "Pilih Gambar TTD";
                    dialog.Filter = "PNG Image|*.png";
                    dialog.Multiselect = false;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // Dispose previous image if exists
                        if (uploadedImage != null)
                        {
                            uploadedImage.Dispose();
                        }

                        if (uploadedImage == null || uploadedImage.Width == 0 || uploadedImage.Height == 0)
                        {
                            MessageBox.Show("Invalid image. Please upload again.");
                            return;
                        }

                        string selectedFilePath = dialog.FileName;
                        uploadedImage = new Bitmap(selectedFilePath);
                        pictureBoxTTD.Image = uploadedImage;

                        MessageBox.Show("Gambar berhasil diunggah.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengunggah gambar: " + ex.Message);
            }*/

        }

        private void btnSimpanTTD_Click(object sender, EventArgs e)
        {
            ProcessAndSaveSignature("TTD");

        }

        private void btnUpploadFoto_Click(object sender, EventArgs e)
        {
            ProcessAndSaveSignature("Foto");

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
                        FormUtama.guru.Ttd = savedPath;
                        bool berhasil = FormUtama.guru.SimpanTTDKeDatabase();

                        MessageBox.Show(berhasil
                            ? $"Path {signatureType} berhasil disimpan ke database."
                            : $"Gagal menyimpan path {signatureType} ke database.");
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (uploadedImage != null)
                {
                    uploadedImage.Dispose();
                    uploadedImage = null;
                }
            }
            base.Dispose(disposing);
        }


    }
}
