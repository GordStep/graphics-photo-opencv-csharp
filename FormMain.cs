using OpenCvSharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace graphics_photo_opencv
{
    public partial class FormMain : Form
    {
        Image grayImageForSave;
        public FormMain()
        {
            InitializeComponent();
        }

        // Создание серой версии изображения
        private void buttonGray_Click(object sender, EventArgs e)
        {
            // Если не удаётся воспользоваться OpenCV, то используем .NET
            try
            {
                pictureBox1.Image.Save("OriginalImage.PNG");
                Mat imageRGB = new Mat("OriginalImage.PNG");

                try
                {
                    File.Delete("OriginalImage.PNG");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }

                Mat grayIm = imageRGB;
                Cv2.CvtColor(imageRGB, grayIm, ColorConversionCodes.BGR2GRAY); // Преобразование изображния с помощью библитеки OpenCV

                Image grayImage = MatToBitmap(grayIm);
                grayImage.Save("GrayImage.png");

                // Отображаем серое фото
                FormImageViewer formGray = new FormImageViewer(grayImage, "Серое изображение OpenCV");
                formGray.Show();

                grayImageForSave = grayImage;
            }
            catch
            { 
                // Код для серого изображения без использования OpenCV
                Bitmap grayImageBit = new Bitmap(pictureBox1.Image);

                for (int i = 0; i < grayImageBit.Width; i++)
                {
                    for (int j = 0; j < grayImageBit.Height; j++)
                    {
                        Color pixel = grayImageBit.GetPixel(i, j);
                        int intensity = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                        Color grayscaleColor = Color.FromArgb(intensity, intensity, intensity);
                        grayImageBit.SetPixel(i, j, grayscaleColor);
                    }
                }

                FormImageViewer formV = new FormImageViewer(grayImageBit, "Серое изображение .NET");
                formV.Show();

                //grayImageBit.Save("GrayImage.png");
                grayImageForSave = grayImageBit;
            }

            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            LabelLogShow("Серое изображение сохранено в файл \"GrayImage.png\"");
        }

        // Построение гистограммы изображения
        private void buttonGist_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(pictureBox1.Image);
            histogram.Show();
        }

        // Разшифровка сообщения в файле
        private void buttonLSB_Click(object sender, EventArgs e)
        {
            try
            {
                LSB.ImageToStr(pictureBox1.Image, this);

                setValueProgressBarMain(0);
                LabelLogShow("Рассшифрованный текст сохранен в файл \"output.txt\"");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошика!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Bitmap MatToBitmap(Mat mat)
        {
            using (var ms = mat.ToMemoryStream())
            {
                return (Bitmap)Image.FromStream(ms);
            }
        }

        // Создание графика изображения с усилением младших битов
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

                progressBar1.Visible = false;

                saveAsToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
        }

        private void buttonOrigImage_Click(object sender, EventArgs e)
        {
            FormImageViewer formOrigImage = new FormImageViewer(pictureBox1.Image, "Оригинальное изображение");
            formOrigImage.Show();
        }

        //private void buttonPhoto_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.Filter = "PNG|*.png|JPG|*.jpg;*.jpeg";

        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        pictureBox1.Image = Image.FromFile(ofd.FileName);
        //        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        //        labelSize.Text = $"Размер фото: {pictureBox1.Image.Width}, {pictureBox1.Image.Height}";

        //        labelFile.Text = $"Название файла: {ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\') + 1)}";

        //        // Включаем кнопки и убираем лог запись
        //        if (pictureBox1.Image != null)
        //        {
        //            buttonGist.Enabled = true;
        //            buttonLSB.Enabled = true;
        //            buttonLSBGraf.Enabled = true;
        //            buttonGray.Enabled = true;
        //            buttonOrigImage.Enabled = true;

        //            labelLog.Visible = false;
        //        }
        //    }
        //}

        private void LabelLogShow(string message)
        {
            labelLog.Text = message;
            labelLog.Visible = true;
        }

        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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

                    
                    deleteToolStripMenuItem.Enabled = true;
                }
            }
        }

        public void setValueProgressBarMain(int value)
        {
            if (value == 0 && progressBar1.Visible)
                progressBar1.Visible = false;

            if (value > 0 && progressBar1.Visible == false)
                progressBar1.Visible = true;

            progressBar1.Value = value;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string dirInfo = Directory.GetCurrentDirectory();

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.DefaultExt = "png";
            saveFileDialog.Title = "Сохранить серое изображение";
            saveFileDialog.Filter = "Файлы изображений (*.png)|*.png|(*.jpeg)|*.jpeg";
            // saveFileDialog.FileName = comboBox1.SelectedItem.ToString();
            saveFileDialog.FileName = $"GrayImage.png";


            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;// Сохранить имя файла
                grayImageForSave.Save(fileName);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            FormMain_Load(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.Show();
        }
    }
}