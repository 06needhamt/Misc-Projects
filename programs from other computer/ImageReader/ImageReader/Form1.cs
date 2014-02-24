using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImageReader
{
    public partial class Form1 : Form
    {
        Bitmap b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "Images|*.jpg|All Files|*.*";
            openFileDialog1.ShowDialog();
            txtPath.Text = openFileDialog1.FileName;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            b = Bitmap.FromStream(new MemoryStream(File.ReadAllBytes(txtPath.Text))) as Bitmap;

            b.Save(txtSavePath.Text, ImageFormat.Png);
            
            MessageBox.Show("Image Saved");
        }

        private void btnSaveBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.RestoreDirectory = false;
            saveFileDialog1.Filter = "JPG Image|*.jpg";
            saveFileDialog1.ShowDialog();
            txtSavePath.Text = saveFileDialog1.FileName;
        }

       
    }
}
