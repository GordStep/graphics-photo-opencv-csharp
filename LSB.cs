using OpenCvSharp.Flann;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_photo_opencv
{
    internal class LSB
    {
        public static string ImageToStr(Image image)
        {
            string result = "";

            if (image == null) return result;

            Bitmap bmp = new Bitmap(image);

            string message = "";
            //string buff = "011000110110000101110100"; // cat
            string buff = "";

            int i, j;
            Color color;
            MessageBox.Show($"start");
            // Проходим по изображению и добавляем 1 в R, G, B по индексу оттенка
            for (i = 0; i < bmp.Height; i++)
                for (j = 0; j < bmp.Width; j++)
                {
                    color = bmp.GetPixel(j, i);

                    byte r = color.R;
                    byte g = color.G;
                    byte b = color.B;

                    var redBinary = Convert.ToString(color.R, 2).PadLeft(8, '0');
                    var greenBinary = Convert.ToString(color.G, 2).PadLeft(8, '0');
                    var blueBinary = Convert.ToString(color.B, 2).PadLeft(8, '0');

                    //MessageBox.Show($"{redBinary} {greenBinary} {blueBinary}");

                    var lBitR = redBinary.Substring(6);
                    var lBitG = greenBinary.Substring(6);
                    var lBitB = blueBinary.Substring(6);

                    buff += lBitR + lBitG + lBitB;

                    //MessageBox.Show(buff);

                    if (buff.Length >= 256)
                    {
                        //MessageBox.Show(buff);
                        for (int ind = 0; ind < buff.Length / 8; ind += 8)
                        {
                            string binChar = buff.Substring(ind, 8);
                            Char c = (Char)Convert.ToInt16(binChar, 2);
                            message += c.ToString();
                            MessageBox.Show($"{c} {(int)c} {binChar}");
                        }

                        buff = buff.Substring(255);
                    }

                    //MessageBox.Show(message);
                }
            for (int ind = 0; ind < buff.Length / 8; ind += 8)
            {
                string binChar = buff.Substring(ind, 8);
                Char c = (Char)Convert.ToInt16(binChar, 2);
                message += c.ToString();
                //MessageBox.Show($"{c} {(int)c} {binChar}");
            }


            MessageBox.Show("finish\n" + message);

            return result;
        }

        public static void GainLowBits(Image image)
        {
            Bitmap gainMap = new Bitmap(image.Width, image.Height);

            Bitmap bmp = new Bitmap(image);

            Color color;

            // Проходим по изображению и добавляем 1 в R, G, B по индексу оттенка
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    color = bmp.GetPixel(i, j);

                    var redBinary = Convert.ToString(color.R, 2).PadLeft(8, '0');
                    var greenBinary = Convert.ToString(color.G, 2).PadLeft(8, '0');
                    var blueBinary = Convert.ToString(color.B, 2).PadLeft(8, '0');

                    var lBitR = redBinary.Substring(6);
                    var lBitG = greenBinary.Substring(6);
                    var lBitB = blueBinary.Substring(6);

                    int uR = Convert.ToInt32(lBitR + "0000", 2);
                    int uG = Convert.ToInt32(lBitG + "0000", 2);
                    int uB = Convert.ToInt32(lBitB + "0000", 2);

                    gainMap.SetPixel(i, j, Color.FromArgb(uR, uG, uB));
                }

            Form2 form2 = new Form2(gainMap, "Усиление младших битов");
            form2.Show();
            gainMap.Save("GistPict.png");
        }
    }
}
