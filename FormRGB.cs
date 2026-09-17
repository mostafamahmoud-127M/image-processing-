using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessing
{
  
    public partial class FormRGB : Form
    {
        Image sourceImage;
        public FormRGB()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG|*JPG|Bitmap|*.bmp|All|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sourceImage = Image.FromFile(openFileDialog1.FileName);
                    picSourceImage.Image = sourceImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Image sourceImage2=picSourceImage.Image ;
            
            int width = sourceImage2.Width;
            int height = sourceImage2.Height;
            int r;
            Bitmap bmpImg = (Bitmap)sourceImage;
            Bitmap redImage=bmpImg;
            

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);
                    r = pixelColor.R;
                    Color red = Color.FromArgb(r, 0, 0);
                    
                    redImage.SetPixel(i, j, red);
                }
            }
            picBoxRed.Image = (Image)redImage;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Image sourceImage3 = picSourceImage.Image;

            int width = sourceImage3.Width;
            int height = sourceImage3.Height;
            int g;
            Bitmap bmpImg = (Bitmap)sourceImage;
            Bitmap greenImage = bmpImg;


            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    g = pixelColor.G;

                    Color green = Color.FromArgb(0, g, 0);


                    greenImage.SetPixel(i, j, green);

                }
            }

            picBoxGreen.Image = (Image)greenImage;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Image sourceImage4 = picSourceImage.Image; ;
            int width = sourceImage4.Width;
            int height = sourceImage4.Height;
            int b;
            Bitmap bmpImg = (Bitmap)sourceImage;
            Bitmap BlueImage = bmpImg;


            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);
                    b = pixelColor.B;
                    Color blue = Color.FromArgb(0, 0, b);

                    BlueImage.SetPixel(i, j, blue);

                }
            }

            picBoxBlue.Image = (Image)BlueImage;
        
        }
    }
}
