using System;
using System.Drawing;
using System.Windows.Forms;

namespace graphics_photo_opencv
{
    public partial class Form2 : Form
    {
        Image selectImage;
        public Form2(Image selectImage, string windowName)
        {
            InitializeComponent();
            this.selectImage = selectImage;
            this.Text = windowName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Size = selectImage.Size;
            pictureBox1.Image = selectImage;
        }
    }
}
