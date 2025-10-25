using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_photo_opencv
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            labelInfo.Text = "Простое приложение с реализацией\nрасшифровки" +
                " информаци методом LSB\nНаписано на C# с использованием" +
                " WinForms.\nЕсть функционал реальзованный с\nпомощью библиотеки OpenCV";

            pictureBoxIcon.Image = Properties.Resources.ImageIcon;
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;

            labelVersion.Text = $"Версия: {ProductVersion}";
        }

        private void linkLabelCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не получилось открыть ссылку.\n" + ex.Message, "Ошибка.");
            }
        }
        private void VisitLink()
        {
            // Отмечаем, что ссылка посещена
            linkLabelCode.LinkVisited = true;

            // Открываем ссылку
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "https://github.com/GordStep/graphics-photo-opencv-csharp"; // название сайта
                p.StartInfo.UseShellExecute = true;
                p.Start();
            }
        }
    }
}
