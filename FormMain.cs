using OpenCvSharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace graphics_photo_opencv
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonGray_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("OriginalImage.PNG");
            Mat imageRGB = new Mat("OriginalImage.PNG");

            Mat grayIm = imageRGB;
            Cv2.CvtColor(imageRGB, grayIm, ColorConversionCodes.BGR2GRAY);

            Image grayImage = MatToBitmap(grayIm);
            grayImage.Save("GrayImage.PNG");

            FormImageViewer formGray = new FormImageViewer(grayImage, "Серое изображение");
            formGray.Show();
        }

        private void buttonGist_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(pictureBox1.Image);
            histogram.Show();
        }
        private void buttonLSB_Click(object sender, EventArgs e)
        {
            LSB.ImageToStr(pictureBox1.Image);
        }

        private static Bitmap MatToBitmap(Mat mat)
        {
            using (var ms = mat.ToMemoryStream())
            {
                return (Bitmap)Image.FromStream(ms);
            }
        }

        private void buttonLSBGraf_Click(object sender, EventArgs e)
        {
            LSB.GainLowBits(pictureBox1.Image);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                buttonGist.Enabled = false;
                buttonLSB.Enabled = false;
                buttonLSBGraf.Enabled = false;
                buttonGray.Enabled = false;
                buttonOrigImage.Enabled = false;
            }
        }

        private void buttonOrigImage_Click(object sender, EventArgs e)
        {
            FormImageViewer formOrigImage = new FormImageViewer(pictureBox1.Image, "Оригинальное изображение");
            formOrigImage.Show();
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG|*.png|JPG|*.jpg;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                //pictureBox1.Size = pictureBox1.Image.Size;
                //label1.Visible = false;
                labelSize.Text = $"Размер фото: {pictureBox1.Image.Width}, {pictureBox1.Image.Height}";

                labelFile.Text = $"Название файла: {ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\') + 1)}";

                if (pictureBox1.Image != null)
                {
                    buttonGist.Enabled = true;
                    buttonLSB.Enabled = true;
                    buttonLSBGraf.Enabled = true;
                    buttonGray.Enabled = true;
                    buttonOrigImage.Enabled = true;
                }
            }
        }
    }
}