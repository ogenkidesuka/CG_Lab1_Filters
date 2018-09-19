using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace LabOne_Filter
{
    abstract class Filter
    {
        protected abstract Color CalcNewPixelColor(Bitmap SourceImage, int x, int y);

        public int Clamp(int value,int min,int max)

        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        public virtual Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);

            for (int i = 0; i < SourceImage.Width; i++) 
            {
                worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < SourceImage.Height; j++) 
                {
                    ResultImage.SetPixel(i, j, CalcNewPixelColor(SourceImage, i, j));
                }
            }

            return ResultImage;
        }
    }

    class InvertFilter : Filter
    {
        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            Color SourceColor = SourceImage.GetPixel(x, y);
            Color ResultColor = Color.FromArgb(255 - SourceColor.R, 255 - SourceColor.G, 255 - SourceColor.B);
            return ResultColor;
        }
    }
    class SaltPepperFilter : Filter
    {
        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            Random rnd = new Random();
            Color SourceColor = SourceImage.GetPixel(x, y);
            Color ResultColor;
            double u = rnd.NextDouble();
            if (u < 0.4)
            {
                int col = rnd.Next(1);
                ResultColor = Color.FromArgb(col, col, col);
            }
            else
                ResultColor = SourceColor;

            return ResultColor;
        }
    }
    class GrayScaleFilter : Filter
    {
        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            Color SourceColor = SourceImage.GetPixel(x, y);
            int Intensity = (int)((0.36 * SourceColor.R) + (0.53 * SourceColor.G) + (0.11 * SourceColor.B));
            return Color.FromArgb(Intensity, Intensity, Intensity);
        }
    }

    class SepiaFilter : Filter
    {
        public int sepia_k;
        public SepiaFilter(int _sepia_k) { sepia_k = _sepia_k; }
        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            int R, G, B;
            Color SourceColor = SourceImage.GetPixel(x, y);
            int Intensity = (int)((0.36 * SourceColor.R) + (0.53 * SourceColor.G) + (0.11 * SourceColor.B));
            R = Intensity + 2 * sepia_k;
            G = (int)(Intensity + 0.5f * sepia_k);
            B = Intensity - 1 * sepia_k;
            return Color.FromArgb(Clamp(R, 0, 255), Clamp(G, 0, 255), Clamp(B, 0, 255));
        }
    }

    class BrightFilter : Filter
    {
        public int bright_k;

        public BrightFilter(int _bright_K) { bright_k = _bright_K; }

        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            Color color = SourceImage.GetPixel(x, y);
            return Color.FromArgb(Clamp(color.R + bright_k, 0, 255), Clamp(color.G + bright_k, 0, 255), Clamp(color.B + bright_k, 0, 255));
        }
    }

    class TransferFilter : Filter
    {
        public int trans_x = 0, trans_y = 0;

        public TransferFilter(int _trans_x, int _trans_y) { trans_x = _trans_x;trans_y = _trans_y; }

        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            
            Color color = SourceImage.GetPixel(x, y);
            return color;
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);

            if (trans_x > 0)
            {
                for (int i = 0; i < SourceImage.Width - trans_x; i++)
                {
                    worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                    if (worker.CancellationPending) return null;

                    for (int j = 0; j < SourceImage.Height; j++)
                    {
                        ResultImage.SetPixel(i, j, CalcNewPixelColor(SourceImage, i + trans_x, j));
                    }
                }
            }
            else
            {
                for (int i = 0; i < SourceImage.Width - trans_x; i++)
                {
                    worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                    if (worker.CancellationPending) return null;

                    for (int j = 0; j < SourceImage.Height; j++)
                    {
                        ResultImage.SetPixel(i+trans_x, j, CalcNewPixelColor(SourceImage, i, j));
                    }
                }
            }

            return ResultImage;
        }
    }

    class RollFilter : Filter
    {
        public int rad = 0; // угол поворота
        public int center_x = 0;
        public int center_y = 0;

        public RollFilter(int _rad) { rad = _rad; }

        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {

            Color color = SourceImage.GetPixel(x, y);
            return color;
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);

            center_x = SourceImage.Width / 2;
            center_y = SourceImage.Height / 2;

            for (int i = 0; i < SourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    ResultImage.SetPixel(i, j, CalcNewPixelColor(SourceImage, 
                        (int)((i - center_x) * Math.Cos(rad) - (j - center_y) * Math.Sin(rad) + center_x), 
                        (int)((i - center_x) * Math.Sin(rad) + (j - center_y) * Math.Cos(rad) + center_y) ) );
                }
            }

            return ResultImage;
        }
    }

    class WindowFilter : Filter
    {
        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {

            Color color = SourceImage.GetPixel(x, y);
            return color;
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);

            Random rnd = new Random();

            for (int i = 0; i < SourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                if (worker.CancellationPending) return null;

                for (int j = 0; j < SourceImage.Height; j++)
                {
                    ResultImage.SetPixel(i, j, SourceImage.GetPixel(i, j));
                    ResultImage.SetPixel(Clamp((int)(i + (rnd.NextDouble() - 0.5) * 10.0), 0, SourceImage.Width - 1),
                                         Clamp((int)(j + (rnd.NextDouble() - 0.5) * 10.0), 0, SourceImage.Height - 1),
                                         SourceImage.GetPixel(i, j));
                }
            }

            return ResultImage;
        }

    }

    class LinearSize : Filter
    {
        int YminR, YminG, YminB;
        int YmaxR, YmaxG, YmaxB;
        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {

            Color color = SourceImage.GetPixel(x, y);
            return color;
        }

        private int Func(int y, int y_max, int y_min)
        {
            return Clamp((y - y_min) * ((255 - 0) / (y_max - y_min)), 0, 255);
        }

        private void FindY(Bitmap pict)
        {
            YminR = pict.GetPixel(0, 0).R;
            YminG = pict.GetPixel(0, 0).G;
            YminB = pict.GetPixel(0, 0).B;

            YmaxR = pict.GetPixel(0, 0).R;
            YmaxG = pict.GetPixel(0, 0).G;
            YmaxB = pict.GetPixel(0, 0).B;

            Color Color;

            for (int i = 0; i < pict.Width; i++)
            {
                for (int j = 0; j < pict.Height; j++)
                {
                    Color = pict.GetPixel(i, j);

                    if (YminR > Color.R) YminR = Color.R;
                    if (YminG > Color.G) YminG = Color.G;
                    if (YminB > Color.B) YminB = Color.B;

                    if (YmaxR < Color.R) YmaxR = Color.R;
                    if (YmaxG < Color.G) YmaxG = Color.G;
                    if (YmaxB < Color.B) YmaxB = Color.B;

                }
            }
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            FindY(SourceImage);
            Color color;
            for (int i = 0; i < SourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    color = SourceImage.GetPixel(i, j);
                    ResultImage.SetPixel(i, j, Color.FromArgb(Func(Convert.ToInt32(color.R), YmaxR, YminR),
                        Func(Convert.ToInt32(color.G), YmaxG, YminG),
                        Func(Convert.ToInt32(color.B), YmaxB, YminB)));
                }
            }

            return ResultImage;
        }

    }

    class GrayWorld : Filter
    {
        int mid_R = 0, mid_G = 0, mid_B = 0;
        int avg = 0;

        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            return SourceImage.GetPixel(x, y);
        }


        private void CalcMiddle(Bitmap Pict)
        {
            int N = Pict.Width * Pict.Height;
            for (int i = 0; i < Pict.Width; i++)
            {
                for (int j = 0; j < Pict.Height; j++)
                {
                    mid_R += Pict.GetPixel(i, j).R;
                    mid_G += Pict.GetPixel(i, j).G;
                    mid_B += Pict.GetPixel(i, j).B;
                }
            }
            mid_R /= N;
            mid_G /= N;
            mid_B /= N;
            avg = (mid_R + mid_G + mid_B) / 3;
        }
        private  int CalcNewColor(int color, int mid_color, int avg)
        {
            return Clamp(color * avg / mid_color, 0, 255);
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            Color color;
            CalcMiddle(SourceImage);
            for (int i = 0; i < SourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    color = SourceImage.GetPixel(i, j);
                    ResultImage.SetPixel(i, j, Color.FromArgb(CalcNewColor(color.R, mid_R, avg),
                        CalcNewColor(color.G, mid_G, avg),
                        CalcNewColor(color.B, mid_B, avg)));
                }
            }
            return ResultImage;
        }

    }

    class SupportColor : Filter
    {
        int R = 0, G = 0, B = 0;
        int R_ideal = 0, G_ideal = 0, B_ideal = 0;
        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            return SourceImage.GetPixel(x, y);
        }

        public SupportColor(int _R, int _G, int _B)
        {
            R = Clamp(_R, 0, 255);
            G = Clamp(_G, 0, 255);
            B = Clamp(_B, 0, 255);
        }

        private Color GetIdealColor(Color SourceColor)
        {
            //int Intensity = (int)((0.36 * SourceColor.R) + (0.53 * SourceColor.G) + (0.11 * SourceColor.B));
            int Intensity = 100;
            return Color.FromArgb(Intensity, Intensity, Intensity);
        }

        private int CalcNewColor(int color, int ideal, int destination)
        {
            return Clamp(color * destination / ideal, 0, 255);
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            Color color, ideal_color;
            for (int i = 0; i < SourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    color = SourceImage.GetPixel(i, j);
                    ideal_color = GetIdealColor(color);
                    ResultImage.SetPixel(i, j, Color.FromArgb(CalcNewColor(color.R, ideal_color.R, R),
                        CalcNewColor(color.G, ideal_color.G, G),
                        CalcNewColor(color.B, ideal_color.B, B)));
                }
            }
            return ResultImage;

        }
    }

    class IdealReflect : Filter
    {

        int R_max = 0, G_max = 0, B_max = 0;

        private void CalcMax(Bitmap Image)
        {
            for (int i = 0; i < Image.Width; i++)
            {
                for (int j = 0; j < Image.Height; j++)
                {
                    if (Image.GetPixel(i, j).R > R_max) R_max = Image.GetPixel(i, j).R;
                    if (Image.GetPixel(i, j).G > G_max) G_max = Image.GetPixel(i, j).G;
                    if (Image.GetPixel(i, j).B > B_max) B_max = Image.GetPixel(i, j).B;
                }
            }
        }
        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            return SourceImage.GetPixel(x, y);
        }

        private int CalcNewColor(int color, int max)
        {
            return Clamp(color * 255 / max, 0, 255);
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            Color color;
            CalcMax(SourceImage);
            for (int i = 0; i < SourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    color = SourceImage.GetPixel(i, j);
                    ResultImage.SetPixel(i, j, Color.FromArgb(CalcNewColor(color.R, R_max),
                        CalcNewColor(color.G, G_max),
                        CalcNewColor(color.B, B_max)));
                }
            }
            return ResultImage;
        }

    }

    class StatCorFilter : Filter
    {
        private Bitmap PalleteImage;
        public StatCorFilter(Bitmap im)
        {
            PalleteImage = im;
        }
        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            return SourceImage.GetPixel(x, y);
        }
        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            Color color;

            #region подсчет матожиданий и среднеквадратичного отклонения исходного изображения

            double n_s = PalleteImage.Width * PalleteImage.Height;
            double expValR_s = 0, expValG_s = 0, expValB_s = 0;
            double varianceR_s = 0, varianceG_s = 0, varianceB_s = 0;

            for (int i = 0; i < PalleteImage.Width; i++)
            {
                for (int j = 0; j < PalleteImage.Height; j++)
                {
                    expValR_s += PalleteImage.GetPixel(i, j).R;
                    expValG_s += PalleteImage.GetPixel(i, j).G;
                    expValB_s += PalleteImage.GetPixel(i, j).B;
                }
            }
            expValR_s = expValR_s / n_s;
            expValG_s = expValG_s / n_s;
            expValB_s = expValB_s / n_s;

            for (int i = 0; i < PalleteImage.Width; i++)
            {
                for (int j = 0; j < PalleteImage.Height; j++)
                {
                    varianceR_s += Math.Pow(PalleteImage.GetPixel(i, j).R - expValR_s, 2);
                    varianceG_s += Math.Pow(PalleteImage.GetPixel(i, j).G - expValG_s, 2);
                    varianceB_s += Math.Pow(PalleteImage.GetPixel(i, j).B - expValB_s, 2);
                }
            }
            varianceR_s = Math.Sqrt(varianceR_s / n_s);
            varianceG_s = Math.Sqrt(varianceG_s / n_s);
            varianceB_s = Math.Sqrt(varianceB_s / n_s);
            #endregion

            #region подсчет матожиданий и среднеквадратичного отклонения целевого изображения

            double n_t = SourceImage.Width * SourceImage.Height;
            double expValR_t = 0, expValG_t = 0, expValB_t = 0;
            double varianceR_t = 0, varianceG_t = 0, varianceB_t = 0;

            for (int i = 0; i < SourceImage.Width; i++)
            {
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    expValR_t += SourceImage.GetPixel(i, j).R;
                    expValG_t += SourceImage.GetPixel(i, j).G;
                    expValB_t += SourceImage.GetPixel(i, j).B;
                }
            }
            expValR_t = expValR_t / n_t;
            expValG_t = expValG_t / n_t;
            expValB_t = expValB_t / n_t;

            for (int i = 0; i < SourceImage.Width; i++)
            {
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    varianceR_t += Math.Pow(SourceImage.GetPixel(i, j).R - expValR_t, 2);
                    varianceG_t += Math.Pow(SourceImage.GetPixel(i, j).G - expValG_t, 2);
                    varianceB_t += Math.Pow(SourceImage.GetPixel(i, j).B - expValB_t, 2);
                }
            }
            varianceR_t = Math.Sqrt(varianceR_t / n_t);
            varianceG_t = Math.Sqrt(varianceG_t / n_t);
            varianceB_t = Math.Sqrt(varianceB_t / n_t);
            #endregion

            for (int i = 0; i < SourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    color = SourceImage.GetPixel(i, j);
                    int rch = Clamp(Convert.ToInt32(expValR_s) + (color.R - Convert.ToInt32(expValR_t)) * Convert.ToInt32(varianceR_s) / Convert.ToInt32(varianceR_t), 0, 255);
                    int gch = Clamp(Convert.ToInt32(expValG_s) + (color.G - Convert.ToInt32(expValG_t)) * Convert.ToInt32(varianceG_s) / Convert.ToInt32(varianceG_t), 0, 255);
                    int bch = Clamp(Convert.ToInt32(expValB_s) + (color.B - Convert.ToInt32(expValB_t)) * Convert.ToInt32(varianceB_s) / Convert.ToInt32(varianceB_t), 0, 255);
                    ResultImage.SetPixel(i, j, Color.FromArgb(rch,gch,bch));
                }
            }

            return ResultImage;
        }
    }

    class MatrixFilter : Filter
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] _kernel)
        {
            kernel = _kernel;
        }

        protected int GetRadius()
        {
            int radius = kernel.GetLength(0);
            radius = (radius - 1) / 2;
            return radius;
        }

        protected float GetNorma()
        {
            float Norma = 0;
            int Radius = GetRadius();
            for (int i = -Radius; i <= Radius; i++)
            {
                for (int j = -Radius; j <= Radius; j++)
                {
                    Norma += kernel[i + Radius, j + Radius];
                }
            }
            return Norma;
        }

        protected void ToNorm()
        {
            float Norma = GetNorma();
            int Size = kernel.GetLength(0);
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    kernel[i, j] /= Norma;
                }
            }
        }


        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {

            int RadiusX = kernel.GetLength(0) / 2;
            int RadiusY = kernel.GetLength(1) / 2;

            float ResultR = 0;
            float ResultG = 0;
            float ResultB = 0;
            for (int l = -RadiusY; l <= RadiusY; l++) 
            {
                for (int k = -RadiusX; k <= RadiusX; k++) 
                {
                    int idX = Clamp(x + k, 0, SourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, SourceImage.Height - 1);
                    Color NeighbourColor = SourceImage.GetPixel(idX, idY);
                    ResultR += NeighbourColor.R * kernel[k + RadiusX, l + RadiusY];
                    ResultG += NeighbourColor.G * kernel[k + RadiusX, l + RadiusY];
                    ResultB += NeighbourColor.B * kernel[k + RadiusX, l + RadiusY];
                }
            }
            return Color.FromArgb(Clamp((int)ResultR, 0, 255), Clamp((int)ResultG, 0, 255), Clamp((int)ResultB, 0, 255));
        }
    }

    class MedianFilter : MatrixFilter
    {
        protected int radius;
        public MedianFilter(int _radius)
        {
            if (_radius < 0) radius = 1;
            else radius = _radius;
        }
        protected override Color CalcNewPixelColor(Bitmap SourсeImage, int x, int y)
        {
            int size = 2 * radius + 1;
            int[] Intensity = new int[size * size]; //intensity at point
            Color[] Color = new Color[size * size]; //color at point
            for (int l = -radius; l <= radius; l++)
            {
                for (int k = -radius; k <= radius; k++)
                {
                    int idX = Clamp(x + k, 0, SourсeImage.Width - 1);
                    int idY = Clamp(y + l, 0, SourсeImage.Height - 1);
                    Color Neighbor = SourсeImage.GetPixel(idX, idY);
                    Color[(l + radius) * size + (k + radius)] = Neighbor;
                    Intensity[(l + radius) * size + (k + radius)] = (int)(0.36 * Neighbor.R + 0.53 * Neighbor.G + 0.11 * Neighbor.B);
                }
            }
            Array.Sort(Intensity, Color);
            //Array.Sort(color)
            return Color[size * size / 2];
        }
    }

    class SharpFilter : MatrixFilter
    {
        public SharpFilter()
        {
            kernel = new float[3, 3];
            kernel[0, 0] = kernel[0, 2] = kernel[2, 0] = kernel[2, 2] = 0;
            kernel[0, 1] = kernel[1, 0] = kernel[1, 2] = kernel[2, 1] = -1;
            kernel[1, 1] = 5;
        }
    }

    class StampingFilter : MatrixFilter
    {
        public StampingFilter()
        {
            kernel = new float[3, 3];
            ToNorm();
            kernel[0, 0] = kernel[0, 2] = kernel[2, 0] = kernel[2, 2] = kernel[1, 1] = 0;
            kernel[0, 1] = kernel[1, 0] = 1;
            kernel[1, 2] = kernel[2, 1] = -1;
        }
    }

    class BlurFilter : MatrixFilter
    {
        public BlurFilter()
        {
            int SizeX = 3;
            int SizeY = 3;
            kernel = new float[SizeX, SizeY];
            for (int i = 0; i < SizeX; i++) 
            {
                for (int j = 0; j < SizeY; j++) 
                {
                    kernel[i, j] = 1.0f / (float)(SizeX * SizeY);
                }
            }
        }
    }

    class MotionBlurFilter : MatrixFilter
    {
        private int n = 3;
        private float N;

        public MotionBlurFilter(int _count_n)
        {
            n = _count_n;
            N = (float)_count_n;
            kernel = new float[n + 1, n + 1];
            for (int i = 0, j = 0; i <= n; i++, j++)
                kernel[i, j] = 1.0F / N;
        }
    }

    class GaussianFilter : MatrixFilter
    {
        private void CreateGaussianKernel(int Radius, float Sigma)
        {
            // define size of kernel
            int Size = 2 * Radius + 1;
            // create kernel of filter
            kernel = new float[Size, Size];
            // coeff Norm of kernel
            float Norma = 0;
            // compute kernel of linear filter
            for (int i = -Radius; i <= Radius; i++) 
            {
                for (int j = -Radius; j <= Radius; j++) 
                {
                    kernel[i + Radius, j + Radius] = (float)(Math.Exp(-(i * i + j * j) / (Sigma * Sigma)));
                    Norma += kernel[i + Radius, j + Radius];
                }
            }
            // To norm kernel
            ToNorm();
        }
        public GaussianFilter()
        {
            CreateGaussianKernel(3, 2);
        }

        
    }

    class SobelX : MatrixFilter
    {
        public SobelX()
        {
            kernel = new float[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
        }
    }

    class SobelY : MatrixFilter
    {
        public SobelY()
        {
            kernel = new float [,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
        }
    }

    class SobelFilter : MatrixFilter
    {

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            int R, G, B;
            int R_x, G_x, B_x;
            int R_y, G_y, B_y;
            SobelX filterX = new SobelX();
            SobelY filterY = new SobelY();
            Bitmap Gx, Gy;
            Gx = filterX.ProcessImage(SourceImage, worker);
            Gy = filterY.ProcessImage(SourceImage, worker);
            for (int i = 0; i < SourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    R_x = (int)Gx.GetPixel(i, j).R;
                    G_x = (int)Gx.GetPixel(i, j).G;
                    B_x = (int)Gx.GetPixel(i, j).B;

                    R_y = (int)Gy.GetPixel(i, j).R;
                    G_y = (int)Gy.GetPixel(i, j).G;
                    B_y = (int)Gy.GetPixel(i, j).B;


                    R = Clamp((int)Math.Sqrt(Math.Pow(R_x, 2) + Math.Pow(R_y, 2)), 0, 255);
                    G = Clamp((int)Math.Sqrt(Math.Pow(G_x, 2) + Math.Pow(G_y, 2)), 0, 255);
                    B = Clamp((int)Math.Sqrt(Math.Pow(B_x, 2) + Math.Pow(B_y, 2)), 0, 255);

                    ResultImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            return ResultImage;
        }

    }

    class SharrX : MatrixFilter
    {
        public SharrX()
        {
            kernel = new float[,] { { 3, 10, 3 }, { 0, 0, 0 }, { -3, -10, -3 } };
        }
    }

    class SharrY : MatrixFilter
    {
        public SharrY()
        {
            kernel = new float[,] { { 3, 0, -3 }, { 10, 0, -10 }, { 3, 0, -3 } };
        }
    }

    class SharrFilter : MatrixFilter
    {
        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            int R, G, B;
            int R_x, G_x, B_x;
            int R_y, G_y, B_y;
            SharrX filterX = new SharrX();
            SharrY filterY = new SharrY();
            Bitmap Gx, Gy;
            Gx = filterX.ProcessImage(SourceImage, worker);
            Gy = filterY.ProcessImage(SourceImage, worker);
            for (int i = 0; i < SourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    R_x = (int)Gx.GetPixel(i, j).R;
                    G_x = (int)Gx.GetPixel(i, j).G;
                    B_x = (int)Gx.GetPixel(i, j).B;

                    R_y = (int)Gy.GetPixel(i, j).R;
                    G_y = (int)Gy.GetPixel(i, j).G;
                    B_y = (int)Gy.GetPixel(i, j).B;


                    R = Clamp((int)Math.Sqrt(Math.Pow(R_x, 2) + Math.Pow(R_y, 2)), 0, 255);
                    G = Clamp((int)Math.Sqrt(Math.Pow(G_x, 2) + Math.Pow(G_y, 2)), 0, 255);
                    B = Clamp((int)Math.Sqrt(Math.Pow(B_x, 2) + Math.Pow(B_y, 2)), 0, 255);

                    ResultImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            return ResultImage;
        }
    }

    class PrewitteX : MatrixFilter
    {
        public PrewitteX()
        {
            kernel = new float[,] { { -1, 1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
        }
    }

    class PrewitteY : MatrixFilter
    {
        public PrewitteY()
        {
            kernel = new float[,] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
        }
    }

    class PrewitteFilter : MatrixFilter
    {
        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            int R, G, B;
            int R_x, G_x, B_x;
            int R_y, G_y, B_y;
            PrewitteX filterX = new PrewitteX();
            PrewitteY filterY = new PrewitteY();
            Bitmap Gx, Gy;
            Gx = filterX.ProcessImage(SourceImage, worker);
            Gy = filterY.ProcessImage(SourceImage, worker);
            for (int i = 0; i < SourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / ResultImage.Width * 100));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    R_x = (int)Gx.GetPixel(i, j).R;
                    G_x = (int)Gx.GetPixel(i, j).G;
                    B_x = (int)Gx.GetPixel(i, j).B;

                    R_y = (int)Gy.GetPixel(i, j).R;
                    G_y = (int)Gy.GetPixel(i, j).G;
                    B_y = (int)Gy.GetPixel(i, j).B;

                    R = Clamp((int)Math.Sqrt(Math.Pow(R_x, 2) + Math.Pow(R_y, 2)), 0, 255);
                    G = Clamp((int)Math.Sqrt(Math.Pow(G_x, 2) + Math.Pow(G_y, 2)), 0, 255);
                    B = Clamp((int)Math.Sqrt(Math.Pow(B_x, 2) + Math.Pow(B_y, 2)), 0, 255);

                    ResultImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            return ResultImage;
        }
    }

    class DilationFilter : MatrixFilter
    {
        public DilationFilter(float[,] _kernel)
        {
            kernel = _kernel;
        }
        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            int Max = 0;
            Color ResultColor = Color.Black;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    if (kernel[k + radiusX, l + radiusY] > 0)
                    {
                        int idX = Clamp(x + k, 0, SourceImage.Width - 1);
                        int idY = Clamp(y + l, 0, SourceImage.Height - 1);
                        Color NeighborColor = SourceImage.GetPixel(idX, idY);
                        int Intensity = (int)(0.36 * NeighborColor.R + 0.53 * NeighborColor.G + 0.11 * NeighborColor.B);
                        if (Intensity > Max)
                        {
                            Max = Intensity;
                            ResultColor = NeighborColor;
                        }
                    }
                }
            }
            return ResultColor;
        }
    }

    class ErosionFilter : MatrixFilter
    {
        public ErosionFilter(float[,] _kernel)
        {
            kernel = _kernel;
        }
        protected override Color CalcNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            int Min = 255 + 255 + 255;
            Color ResultColor = Color.Black;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    if (kernel[k + radiusX, l + radiusY] > 0)
                    {
                        int idX = Clamp(x + k, 0, SourceImage.Width - 1);
                        int idY = Clamp(y + l, 0, SourceImage.Height - 1);
                        Color NeighborColor = SourceImage.GetPixel(idX, idY);
                        int Intensity = (int)(0.36 * NeighborColor.R + 0.53 * NeighborColor.G + 0.11 * NeighborColor.B);
                        if (Intensity < Min)
                        {
                            Min = Intensity;
                            ResultColor = NeighborColor;
                        }
                    }
                }
            }
            return ResultColor;
        }
    }

    class OpeningFilter : MatrixFilter
    {
        public OpeningFilter(float [,]_kernel)
        {
            kernel = _kernel;
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            Filter erosion = new ErosionFilter(kernel);
            Filter dilation = new DilationFilter(kernel);
            ResultImage = erosion.ProcessImage(SourceImage, worker);
            ResultImage = dilation.ProcessImage(ResultImage, worker);

            return ResultImage;
        }
    }
    class ClosingFilter : MatrixFilter
    {
        public ClosingFilter(float[,] _kernel)
        {
            kernel = _kernel;
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            Filter erosion = new ErosionFilter(kernel);
            Filter dilation = new DilationFilter(kernel);

            ResultImage = dilation.ProcessImage(SourceImage, worker);
            ResultImage = erosion.ProcessImage(ResultImage, worker);

            return ResultImage;
        }
    }

    class GradFilter : MatrixFilter
    {
        public GradFilter(float[,] _kernel)
        {
            kernel = _kernel;
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            DilationFilter dilation = new DilationFilter(kernel);
            ErosionFilter erosion = new ErosionFilter(kernel);

            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);

            Bitmap ImageDilation = dilation.ProcessImage(SourceImage, worker);
            Bitmap ImageErosion = erosion.ProcessImage(SourceImage, worker);

            int R, G, B;
            for (int i = 0; i < SourceImage.Width; i++)
            {
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    Color ColorDilation = ImageDilation.GetPixel(i, j);
                    Color ColorErosion = ImageErosion.GetPixel(i, j);

                    R = Clamp(ColorDilation.R - ColorErosion.R, 0, 255);
                    G = Clamp(ColorDilation.G - ColorErosion.G, 0, 255);
                    B = Clamp(ColorDilation.B - ColorErosion.B, 0, 255);

                    ResultImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            return ResultImage;
        }

    }

    class TopHat : MatrixFilter
    {
        public TopHat(float[,] _kernel)
        {
            kernel = _kernel;
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            ClosingFilter closing = new ClosingFilter(kernel);

            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            Bitmap WorkImage = closing.ProcessImage(SourceImage, worker);

            int R, G, B;

            for (int i = 0; i < SourceImage.Width; i++)
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    Color SourceColor = SourceImage.GetPixel(i, j);
                    Color ClosingColor = WorkImage.GetPixel(i, j);

                    R = Clamp(ClosingColor.R - SourceColor.R, 0, 255);
                    G = Clamp(ClosingColor.G - SourceColor.G, 0, 255);
                    B = Clamp(ClosingColor.B - SourceColor.B, 0, 255);

                    ResultImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                }

            return ResultImage;
        }
    }

    class BlackHat : MatrixFilter
    {
        public BlackHat(float[,] _kernel)
        {
            kernel = _kernel;
        }

        public override Bitmap ProcessImage(Bitmap SourceImage, BackgroundWorker worker)
        {
            ClosingFilter closing = new ClosingFilter(kernel);

            Bitmap ResultImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            Bitmap WorkClosingImage = closing.ProcessImage(SourceImage, worker);

            int R, G, B;

            for (int i = 0; i < SourceImage.Width; i++)
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    Color SourceColor = SourceImage.GetPixel(i, j);
                    Color ClosingColor = WorkClosingImage.GetPixel(i, j);

                    R = Clamp(ClosingColor.R - SourceColor.R, 0, 255);
                    G = Clamp(ClosingColor.G - SourceColor.G, 0, 255);
                    B = Clamp(ClosingColor.B - SourceColor.B, 0, 255);

                    ResultImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                }

            return ResultImage;
        }

    }



}
