using OpenCvSharp.Flann;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_photo_opencv
{
    internal class LSB
    {
        public static void ImageToStr(Image image)
        {
            if (image == null) throw new Exception("image is null");

            Bitmap bmp = new Bitmap(image);

            string message = "";
            string buff = "";

            int i, j;
            Color color;

            File.Delete("output.txt");
            StreamWriter output = new StreamWriter(@"output.txt", true);
            
            // Проходим по изображению и добавляем 1 в R, G, B по индексу оттенка
            for (i = 0; i < bmp.Height; i++)
                for (j = 0; j < bmp.Width; j++)
                {
                    color = bmp.GetPixel(j, i); // Получаем пиксель

                    // Переводим значение каждого оттенка в бинарный вид, который запишем с помощью строки
                    var redBinary = Convert.ToString(color.R, 2).PadLeft(8, '0');
                    var greenBinary = Convert.ToString(color.G, 2).PadLeft(8, '0');
                    var blueBinary = Convert.ToString(color.B, 2).PadLeft(8, '0');

                    // Выделяем младшие биты каждого цвета
                    var lBitR = redBinary.Substring(6); 
                    var lBitG = greenBinary.Substring(6);
                    var lBitB = blueBinary.Substring(6);

                    buff += lBitR + lBitG + lBitB; // Добавляем в буфер младшие биты текущего пикселя

                    //MessageBox.Show(buff);

                    // При заполнении буфера 16ю символами обрабатываем их и добавляем с строке
                    if (buff.Length >= 36 * 8 * 2)
                    {
                        int ind;
                        for (ind = 0; ind < buff.Length / 8; ind += 8)
                        {
                            string binChar = buff.Substring(ind, 8); // выделяем подстроку в 8 бит (1 символ)
                            Char c = (Char)Convert.ToInt16(binChar, 2); // выделяем подстроку в 8 бит (1 символ)
                            message += c.ToString();
                            //MessageBox.Show($"{c} {(int)c} {binChar}");
                        }

                        buff = buff.Substring(ind);
                    }


                    // Чтобы не работать с большой строкой, мы записываем в файл информацию строками длиной 1000 символов
                    if (message.Length >= 1000)
                    {
                        output.Write(message);
                        message = ""; // Зануляем строку
                    }

                }

            // Обрабатываем оставшийся буффер символов
            for (int ind = 0; ind < buff.Length / 8; ind += 8)
            {
                string binChar = buff.Substring(ind, 8); // выделяем подстроку в 8 бит (1 символ)
                Char c = (Char)Convert.ToInt16(binChar, 2); // переводим двоичную строку в число 
                message += c.ToString();

                //MessageBox.Show($"{c} {(int)c} {binChar}"); // проверка работы
            }

            // Дозаписываем остаток данных в файл
            output.Write(message);
            output.Close();
            
            MessageBox.Show("Расшифровка завершена, результат записан в файл output.txt", "Завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            FormImageViewer FormImageViewer = new FormImageViewer(gainMap, "Усиление младших битов");
            FormImageViewer.Show();
            gainMap.Save("GainLowBitsPict.png");
        }
    }
}
