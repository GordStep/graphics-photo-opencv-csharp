using OpenCvSharp;
using System;
using System.Drawing;
using System.IO;
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

            try
            {
                File.Delete("OriginalImage.PNG");
            } catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }

            Mat grayIm = imageRGB;
            Cv2.CvtColor(imageRGB, grayIm, ColorConversionCodes.BGR2GRAY); // Преобразование изображния с помощью библитеки OpenCV

            Image grayImage = MatToBitmap(grayIm);
            grayImage.Save("GrayImage.png");

            // Отображаем серое фото
            FormImageViewer formGray = new FormImageViewer(grayImage, "Серое изображение");
            formGray.Show();

            LabelLogShow("Серое изображение сохранено в файл \"GrayImage.png\"");
        }

        private void buttonGist_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(pictureBox1.Image);
            histogram.Show();
        }
        private void buttonLSB_Click(object sender, EventArgs e)
        {
            LSB.ImageToStr(pictureBox1.Image);

            LabelLogShow("Рассшифрованный текст сохранен в файл \"output.txt\"");
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

            LabelLogShow("Изображение с усиленными младшими битами сохранено в файл \"GainLowBitsPict.png\"");
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

                labelLog.Visible = false;
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

                labelSize.Text = $"Размер фото: {pictureBox1.Image.Width}, {pictureBox1.Image.Height}";

                labelFile.Text = $"Название файла: {ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\') + 1)}";

                // Включаем кнопки и убираем лог запись
                if (pictureBox1.Image != null)
                {
                    buttonGist.Enabled = true;
                    buttonLSB.Enabled = true;
                    buttonLSBGraf.Enabled = true;
                    buttonGray.Enabled = true;
                    buttonOrigImage.Enabled = true;

                    labelLog.Visible = false;
                }
            }
        }

        private void LabelLogShow(string message)
        {
            labelLog.Text = message;
            labelLog.Visible = true;
        }
    }
}