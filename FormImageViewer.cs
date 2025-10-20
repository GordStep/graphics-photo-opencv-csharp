using System;
using System.Drawing;
using System.Windows.Forms;

namespace graphics_photo_opencv
{
    public partial class FormImageViewer : Form
    {
        Image selectImage;
        public FormImageViewer(Image selectImage, string windowName)
        {
            InitializeComponent();
            this.selectImage = selectImage;
            this.Text = windowName; // Название окна 
        }

        private void FormImageViewer_Load(object sender, EventArgs e)
        {
            this.Size = selectImage.Size;
            pictureBox1.Image = selectImage;
        }
    }
}
