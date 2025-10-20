using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Image = System.Drawing.Image;

namespace graphics_photo_opencv
{
    public partial class Histogram : Form
    {
        Image selectImage;
        public Histogram(Image selectImage)
        {
            InitializeComponent();
            this.selectImage = selectImage;
        }

        private void Histogram_Load(object sender, EventArgs e)
        {
            if (this.selectImage != null)
            {
                Bitmap bmp = new Bitmap(selectImage);

                int[] X = new int[256];
                for (int k = 0; k < 256; k++) X[k] = k;

                int[] R = new int[256];
                int[] G = new int[256];
                int[] B = new int[256];

                int i, j;
                Color color;

                // Проходим по изображению и добавляем 1 в массивы R, G, B по индексу оттенка соответсвующего цвета
                for (i = 0; i < bmp.Width; i++) 
                    for (j = 0; j < bmp.Height; j++)
                    {
                        color = bmp.GetPixel(i, j);
                        ++R[color.R];
                        ++G[color.G];
                        ++B[color.B];
                    }

                // Создание множест точек по данным
                Series seriesR = new Series("Red");
                seriesR.Points.DataBindXY(X, R);
                seriesR.ChartType = SeriesChartType.Line;

                Series seriesG = new Series("Green");
                seriesG.Points.DataBindXY(X, G);
                seriesG.ChartType = SeriesChartType.Line;

                Series seriesB = new Series("Blue");
                seriesB.Points.DataBindXY(X, B);
                seriesB.ChartType = SeriesChartType.Line;

                chart1.Series.Clear();
                chart2.Series.Clear();
                chart3.Series.Clear();

                // добавление точек на графики
                chart1.Series.Add(seriesR);
                chart2.Series.Add(seriesG);
                chart3.Series.Add(seriesB);

                chart1.ResetAutoValues();
                chart2.ResetAutoValues();
                chart3.ResetAutoValues();

                // задаем оси, заголовок, сетку графика
                chart1.Titles.Clear();
                chart1.Titles.Add($"Гистограмма изображения");
                chart1.ChartAreas[0].AxisX.Title = "Насыщенность пикселя";
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Title = "Колличество пикселей";
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;

                // задаем оси, заголовок, сетку графика
                chart2.Titles.Clear();
                chart2.Titles.Add($"Гистограмма изображения");
                chart2.ChartAreas[0].AxisX.Title = "Насыщенность пикселя";
                chart2.ChartAreas[0].AxisX.Minimum = 0;
                chart2.ChartAreas[0].AxisY.Title = "Колличество пикселей";
                chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;

                // задаем оси, заголовок, сетку графика
                chart3.Titles.Clear();
                chart3.Titles.Add($"Гистограмма изображения");
                chart3.ChartAreas[0].AxisX.Title = "Насыщенность пикселя";
                chart3.ChartAreas[0].AxisX.Minimum = 0;
                chart3.ChartAreas[0].AxisY.Title = "Колличество пикселей";
                chart3.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart3.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;

                // При наведении отобразим значения в точке по x и y
                chart1.Series[0].ToolTip = "Количесто=#VALY\nНасыщенность=#VALX";
                chart2.Series[0].ToolTip = "Количесто=#VALY\nНасыщенность=#VALX";
                chart3.Series[0].ToolTip = "Количесто=#VALY\nНасыщенность=#VALX";

                // Задаём отображение точек на графике, как кружочки
                chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
                chart2.Series[0].MarkerStyle = MarkerStyle.Circle;
                chart3.Series[0].MarkerStyle = MarkerStyle.Circle;

                chart1.Series[0].MarkerSize = 2;
                chart1.Series[0].MarkerColor = Color.Red;

                chart2.Series[0].MarkerSize = 2;
                chart2.Series[0].MarkerColor = Color.Green;

                chart3.Series[0].MarkerSize = 2;
                chart3.Series[0].MarkerColor = Color.Blue;

                // Задаём цвет линий
                chart1.Series[0].Color = Color.Red;
                chart2.Series[0].Color = Color.Green;
                chart3.Series[0].Color = Color.Blue;
            }
            else
            {
                MessageBox.Show("Изображение не найдено");
            }
        }
    }
}
