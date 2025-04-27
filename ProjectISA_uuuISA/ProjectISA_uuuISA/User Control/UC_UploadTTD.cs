using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public UC_UploadTTD()
        {
            InitializeComponent();
        }

        private void UC_UploadTTD_Load(object sender, EventArgs e)
        {
            labelImagePath.Text = "";
        }

        private void buttonUploadTTD_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(fileDialog.FileName) == ".png" || Path.GetExtension(fileDialog.FileName) == ".jng")
                    {
                        Image selectedFoto = new Bitmap(fileDialog.FileName);                        
                    }   
                    else
                    {
                        MessageBox.Show("Format File tidak sesuai. Gunakan png atau jpg");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
