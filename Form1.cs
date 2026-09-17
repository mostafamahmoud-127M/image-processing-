using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using openCV;
using System.IO;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Image sourceImage;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpBoxFilters.Visible = true;
            btnLoadImage.Visible = true;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = new Bitmap(sourceImage);
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap newImage = bmpImg;
            Bitmap testImg = bmpImg;

            if (radbtnAverageFilter.Checked)
            {
                int[,] averageFilter = {{1,1,1}
                                       ,{1,1,1}
                                       ,{1,1,1}};


                decimal red, green, blue;

                for (int i = 1; i < width - 1; i++)
                {

                    for (int j = 1; j < height - 1; j++)
                    {
                        red = 0;
                        green = 0;
                        blue = 0;

                        // 
                        for (int w = i - 1; w <= i + 1; w++)
                        {
                            for (int z = j - 1; z <= j + 1; z++)
                            {
                                Color pixelColor = bmpImg.GetPixel(w, z);

                                red += pixelColor.R;
                                green += pixelColor.G;
                                blue += pixelColor.B;

                            }
                        }

                        red = red / 9;
                        green = green / 9;
                        blue = blue / 9;

                        Color newColor = Color.FromArgb((int)red, (int)green, (int)blue);
                        newImage.SetPixel(i, j, newColor);
                    }
                }


            }
            else if (radbtnSharpFilter.Checked)
            {
                int countX = 0, countY = 0;
                int[,] sharpeningFilter = {{0,-1,0}
                                          ,{-1,4,-1}
                                          ,{0,-1,0}};
                decimal red, green, blue;

                for (int i = 1; i < width - 1; i++)
                {

                    for (int j = 1; j < height - 1; j++)
                    {
                        red = 0;
                        green = 0;
                        blue = 0;
                        countY = 0;
                        // 
                        for (int w = i - 1; w <= i + 1; w++)
                        {
                            for (int z = j - 1; z <= j + 1; z++)
                            {
                                Color pixelColor = bmpImg.GetPixel(w, z);

                                red += (pixelColor.R * sharpeningFilter[countX, countY]);
                                green += (pixelColor.G * sharpeningFilter[countX, countY]); ;
                                blue += (pixelColor.B * sharpeningFilter[countX, countY]); ;
                                countX++;

                            }
                            countY++;
                            countX = 0;
                        }

                        red = red % 255;
                        green = green % 255;
                        blue = blue % 255;

                        if (red < 0)
                            red = 0;
                        if (green < 0)
                            green = 0;
                        if (blue < 0)
                            blue = 0;

                        Color newColor = Color.FromArgb((int)red, (int)green, (int)blue);
                        newImage.SetPixel(i, j, newColor);
                    }
                }
            }

            /*bmpImg = (Bitmap)sourceImage;
            decimal r, g, b;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color img1 = bmpImg.GetPixel(i, j);
                    Color img2 = newImage.GetPixel(i, j);

                    r = img2.R-img1.R;
                    g = img2.G - img1.G;
                    b = img2.B - img1.B;
                    if (r < 0)
                        r = 0;
                    if (g < 0)
                        g = 0;
                    if (b < 0)
                        b = 0;


                    Color c = Color.FromArgb((int)r, (int)g, (int)b);
                    testImg.SetPixel(i, j, c);

                }
            }
            */

            //picBoxSource.Image = testImg;
            picBoxFilterdImage.Image = newImage;
            
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG|*JPG|Bitmap|*.bmp|All|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sourceImage = Image.FromFile(openFileDialog1.FileName);
                    picBoxSource.Image = sourceImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormHistogram().Show();
        }

        private void rGBSeperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new FormRGB().Show();
        }
    }
}
