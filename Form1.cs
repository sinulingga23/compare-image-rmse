using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MetopelP6
{
    public partial class Form1 : Form
    {
        private string pathHasil1 = @"D:\HASIL\MatriksRGB_Gambar1.txt";
        private string pathHasil2 = @"D:\HASIL\MatriksRGB_Gambar2.txt";
        private OpenFileDialog ofdGambar1;
        private OpenFileDialog ofdGambar2;
        private double[,] matriks1;
        private double[,] matriks2;

        public Form1()
        {
            InitializeComponent();
            ofdGambar1 = new OpenFileDialog();
            ofdGambar2 = new OpenFileDialog();
            matriks1 = new double[5000, 5000];
            matriks2 = new double[5000, 5000];
            btn_matriks_rgb_gambar1.Enabled = false;
            btn_matriks_rgb_gambar2.Enabled = false;
        }



        private void btn_upl_gambar1_Click(object sender, EventArgs e)
        {
            ofdGambar1.Filter = "Image Files (*.jpg;*.jpeg;*.png) | *.jpg;*.jpeg;*.png";

            if (ofdGambar1.ShowDialog() == DialogResult.OK)
            {
                Image temp = Image.FromFile(ofdGambar1.FileName);
                gambar1.Image = new Bitmap(temp, gb_gambar1.Width - 10, gb_gambar1.Height - 10);
            }
            hasil_rmse.Text = "-";
        }

        private void btn_upl_gambar2_Click(object sender, EventArgs e)
        {
            ofdGambar2.Filter = "Image Files (*.jpg;*.jpeg;*.png;) | *.jpg;*.jpeg;*.png";
            if (ofdGambar2.ShowDialog() == DialogResult.OK)
            {
                Image temp = Image.FromFile(ofdGambar2.FileName);
                gambar2.Image = new Bitmap(temp, gb_gambar2.Width - 10, gb_gambar2.Height - 10);
            }
            hasil_rmse.Text = "-";
        }

        private void simpanHasilKeFile(double[,] matriks, int width, int height, string path)
        {
            string hasil = "";
            for (int i = 0; i < width; i++)
            {
                hasil += "|";
                for (int j = 0; j < height; j++)
                {
                    hasil += matriks[i, j].ToString() + "|";
                }
                hasil += "\n";
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(hasil);
            }

        }

        private void btn_bandingkan_gambar_Click(object sender, EventArgs e)
        {
            Image t1 = Image.FromFile(ofdGambar1.FileName);
            Bitmap tmp1 = new Bitmap(t1, 64, 64);

            Image t2 = Image.FromFile(ofdGambar2.FileName);
            Bitmap tmp2 = new Bitmap(t2, 64, 64);

            double rmse = 0;
            for (int i = 0; i < tmp1.Width; i++)
            {
                for (int j = 0; j < tmp1.Height; j++)
                {
                    // mendapatkan value RGB dari tiap gambar
                    double pixel_gambar1 = tmp1.GetPixel(i, j).R + tmp1.GetPixel(i, j).G + tmp1.GetPixel(i, j).B;
                    double pixel_gambar2 = tmp2.GetPixel(i, j).R + tmp2.GetPixel(i, j).G + tmp2.GetPixel(i, j).B;
 
                    // simpan nilai RGB tiap pixel ke dalam matriks
                    matriks1[i, j] = pixel_gambar1;
                    matriks2[i, j] = pixel_gambar2;

                    // menjumlahkan error yang terjadi
                    if (!double.IsNaN(pixel_gambar1))
                    {
                        if (!double.IsNaN(pixel_gambar2))
                        {
                            rmse += (pixel_gambar2 - pixel_gambar1) * (pixel_gambar2 - pixel_gambar1);
                        }
                    }

                }
            }
            rmse /= 64 * 64;
            rmse = Math.Sqrt(rmse);

            if (double.Equals(rmse, (double)0))
            {
                hasil_rmse.Text = "KEDUA GAMBAR SAMA";
            }
            else if (rmse > (double)0 && rmse <= (double)0.01)
            {
                hasil_rmse.Text = "KEDUA GAMBAR MIRIP";
            }
            else if (rmse > (double)0.01)
            {
                hasil_rmse.Text = "KEDUA GAMBAR BERBEDA";
            }

            simpanHasilKeFile(matriks1, 64, 64, pathHasil1);
            simpanHasilKeFile(matriks2, 64, 64, pathHasil2);
            btn_matriks_rgb_gambar1.Enabled = true;
            btn_matriks_rgb_gambar2.Enabled = true;

        }

        private void btn_matriks_rgb_gambar1_Click(object sender, EventArgs e)
        {
            Process.Start(pathHasil1);
        }

        private void btn_matriks_rgb_gambar2_Click(object sender, EventArgs e)
        {
            Process.Start(pathHasil2);
        }
    }
}
