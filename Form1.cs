using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_photo_opencv
{
    public partial class Form1 : Form
    {
        Image select_image;
        bool isCliked = false;
        public Form1(Image image)
        {
            InitializeComponent();
            select_image = image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //select_image = Properties.Resources.image;
            pictureBox1.Image = select_image;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            this.Size = select_image.Size;

            pictureBox1_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            select_image.Save("OriginalImage.PNG");
            Mat imageRGB = new Mat("OriginalImage.PNG");

            Mat grayIm = imageRGB;
            Cv2.CvtColor(imageRGB, grayIm, ColorConversionCodes.BGR2GRAY);

            Image grayImage = MatToBitmap(grayIm);
            grayImage.Save("GrayImage.PNG");

            if (!isCliked)
            { 
                Form2 form2 = new Form2(grayImage, "Серое изображение");
                form2.Show();

                Histogram histogram = new Histogram(select_image);
                histogram.Show();

                LSB.ImageToStr(select_image);

                isCliked = true; 
            }
        }

        private static Bitmap MatToBitmap(Mat mat)
        {
            using (var ms = mat.ToMemoryStream())
            {
                return (Bitmap)Image.FromStream(ms);
            }
        }
    }
}
