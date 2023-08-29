using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ColorReducer
{
    public static class ErrorDitheringAlgorithm
    {
        public static (int[,] filter, int divider, int start) FloydSteinberg = (new int[,] {
            {0, 0, 7},
            {3, 5, 1}}, 16, 1);

        public static (int[,] filter, int divider, int start) Burkes = (new int[,] {
            { 0, 0, 0, 8, 4},
            { 2, 4, 8, 4, 2} }, 32, 2);

        public static (int[,] filter, int divider, int start) Stucky = (new int[,] {
            { 0, 0, 0, 8, 4},
            { 2, 4, 8, 4, 2},
            { 1, 2, 4, 2, 1} }, 42, 2);

        public static int ColorNormalize(int x)
        {
            return x < 0 ? 0 : x > 255 ? 255 : x;
        }
        public static void AddError(int x, int y, DirectBitmap directBitmap, int errorR, int errorG, int errorB, int l, int m)
        {
            var pixel = directBitmap.GetPixel(x, y);
            var color = Color.FromArgb(ColorNormalize(pixel.R + errorR * l / m), ColorNormalize(pixel.G + errorG * l / m), ColorNormalize(pixel.B + errorB * l / m));
            directBitmap.SetPixel(x, y, color);
        }
        public static DirectBitmap ErrorDithering((int[,] filter, int divider, int start) matrix, DirectBitmap original, int f)
        {
            // inspo https://www.cyotek.com/blog/dithering-an-image-using-the-burkes-algorithm-in-csharp

            DirectBitmap directBitmap = new DirectBitmap(original.Bitmap, original.Width, original.Height);
            int w = directBitmap.Width;
            int h = directBitmap.Height;

            for (int j = 0; j < h; j++)
            {
                for (int i = 0; i < w; i++)
                {
                    var oldPixel = directBitmap.GetPixel(i, j);

                    var newPixelR = (int)Math.Round((double)f * oldPixel.R / 255) * (255 / f);
                    var newPixelG = (int)Math.Round((double)f * oldPixel.G / 255) * (255 / f);
                    var newPixelB = (int)Math.Round((double)f * oldPixel.B / 255) * (255 / f);

                    var errorR = oldPixel.R - newPixelR;
                    var errorG = oldPixel.G - newPixelG;
                    var errorB = oldPixel.B - newPixelB;

                    directBitmap.SetPixel(i, j, Color.FromArgb(newPixelR, newPixelG, newPixelB));

                    for (int row = 0; row < matrix.filter.GetLength(0); row++)
                    {
                        int offsetY = j + row;

                        for (int col = 0; col < matrix.filter.GetLength(1); col++)
                        {
                            int coefficient = matrix.filter[row, col];
                            int offsetX = i + (col - matrix.start); //tu ta dwojka

                            if (coefficient != 0 && offsetX >= 0 && offsetX < w && offsetY >= 0 && offsetY < h)
                            {
                                AddError(offsetX, offsetY, directBitmap, errorR, errorG, errorB, coefficient, matrix.divider);
                            }
                        }
                    }

                }
            }
            return directBitmap;
        }
    }
    public static class PopularityAlgorithm { 
        public static Color[] kColorPalette(DirectBitmap directBitmap, int k)
        {
            var m = new int[256 * 256 * 256];
            Array.Fill(m, 0);
            for (int j = 0; j < directBitmap.Height; j++)
            {
                for (int i = 0; i < directBitmap.Width; i++)
                {
                    var p = directBitmap.GetPixel(i, j);
                    m[p.R * 256 * 256 + p.G * 256 + p.B]++;
                }
            }
            var c = new Color[k];
            for (int i = 0; i < k; i++)
            {
                var q = Array.IndexOf(m, m.Max());
                m[q] = 0;
                c[i] = Color.FromArgb((q / 256) / 256, (q / 256) % 256, (q % 256) % 256);
            }
            return c;
        }
        public static Color bestColor(Color[] kPalette, Color color)
        {
            Color bestC = Color.White;
            double minDistance = double.MaxValue;

            foreach (var c in kPalette)
            {
                var d = getDistance(c, color);
                if (d < minDistance)
                {
                    bestC = c;
                    minDistance = d;
                }
            }
            return bestC;
        }
        public static double getDistance(Color c1, Color c2)
        {
            return Math.Pow((double)c1.R - c2.R, 2) + Math.Pow((double)c1.G - c2.G, 2) + Math.Pow((double)c1.B - c2.B, 2);
        }
        public static DirectBitmap popularityAlgorithm(DirectBitmap original, int k)
        {
            DirectBitmap directBitmap = new DirectBitmap(original.Bitmap, original.Width, original.Height);
            Color[] palette = kColorPalette(directBitmap, k);
            for (int x = 0; x < directBitmap.Width; x++)
            {
                for (int y = 0; y < directBitmap.Height; y++)
                {
                    directBitmap.SetPixel(x, y, bestColor(palette, directBitmap.GetPixel(x, y)));
                }
            }
            return directBitmap;
        }
       
    }
}
