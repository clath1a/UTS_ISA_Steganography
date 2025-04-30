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
        public UC_UploadTTD()
        {
            InitializeComponent();
        }

        private void UC_UploadTTD_Load(object sender, EventArgs e)
        {

        }

        private void buttonUploadTTD_Click(object sender, EventArgs e)
        {
            string pesan = "Ini pesan rahasia dari aplikasi.";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Select a File";
                dialog.Filter = "PNG Image|*.png";
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = dialog.FileName;
                    string fileExtension = System.IO.Path.GetExtension(selectedFilePath).ToLower();

                    pictureBoxTTD.ImageLocation = selectedFilePath;
                    SimpanPathKeDatabase(FormUtama.guru.IdGuru, selectedFilePath);
                    MessageBox.Show("Gambar berhasil di upload");
                }


                //Bitmap hasilEmbed = Steganography_Raport.EmbedText(pesan, uploadedImage);

                //SaveFileDialog saveDialog = new SaveFileDialog();
                //saveDialog.Filter = "PNG Image|*.png";
                //saveDialog.Title = "Simpan gambar dengan pesan tersembunyi";
                //saveDialog.FileName = "hasil_embed.png";



                //if (saveDialog.ShowDialog() == DialogResult.OK)
                //{
                //    string savedPath = saveDialog.FileName;
                //    hasilEmbed.Save(savedPath, ImageFormat.Png);
                //    MessageBox.Show("Pesan berhasil disisipkan dan gambar disimpan.");

                //    // Simpan ke database
                //    SimpanPathKeDatabase(FormUtama.guru.IdGuru, selectedFilePath);// pastikan kamu punya idGuru
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyisipkan pesan: " + ex.Message);
            }


        }

        private void btnSimpanTTD_Click(object sender, EventArgs e)
        {
            if (uploadedImage == null)
            {
                MessageBox.Show("Silakan upload gambar terlebih dahulu.");
                return;
            }

            string pesan = "Ini pesan rahasia dari aplikasi.";

            try
            {
                Bitmap hasilEmbed = Steganography_Raport.EmbedText(pesan, uploadedImage);


                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PNG Image|*.png";
                saveDialog.Title = "Simpan gambar dengan pesan tersembunyi";
                saveDialog.FileName = "hasil_embed.png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    hasilEmbed.Save(saveDialog.FileName, ImageFormat.Png);
                    MessageBox.Show("Pesan berhasil disisipkan dan gambar disimpan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyisipkan pesan: " + ex.Message);
            }
        }

        private void SimpanPathKeDatabase(int idGuru, string pathTTD)
        {
            string connectionString = "server=localhost;user=root;password=;database=namadatabase;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE guru SET ttd = @path WHERE id_guru = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@path", pathTTD);
                        cmd.Parameters.AddWithValue("@id", idGuru);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Path TTD berhasil disimpan ke database.");
                        }
                        else
                        {
                            MessageBox.Show("Gagal menyimpan ke database. ID tidak ditemukan.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

    }
}
