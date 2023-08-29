using ColorReducer;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class KMeans
{
    public class DataPoint
    {
        public int R;
        public int G;
        public int B;
        public DataPoint(Color c)
        {
            R = c.R;
            G = c.G;
            B = c.B;
        }
        public DataPoint(Random rnd)
        {
            R = rnd.Next(256);
            G = rnd.Next(256);
            B = rnd.Next(256);
        }
        public static int Dist(DataPoint a, DataPoint b)
        {
            return (a.R - b.R) * (a.R - b.R) + (a.G - b.G) * (a.G - b.G) + (a.B - b.B) * (a.B - b.B);
        }
        public Color ToColor()
        {
            return Color.FromArgb(R, G, B);
        }
    }
    public static Random rnd = new Random();
    public DirectBitmap org;
    public DirectBitmap res;
    public DataPoint[] data_in;
    public DataPoint[] data_out;
    public DataPoint[] centroids;
    int clusters;
    int count;
    public KMeans(DirectBitmap org, DirectBitmap res, int clusters)
    {
        this.org = org;
        this.res = res;
        this.clusters = clusters;
        count = org.Width * org.Height;
        data_in = new DataPoint[count];
        data_out = new DataPoint[count];
        centroids = new DataPoint[clusters];
    }
    public void Init()
    {
        for (int i = 0; i < org.Height; i++)
        {
            for (int j = 0; j < org.Width; j++)
            {
                data_out[i * org.Width + j] = new DataPoint(Color.Black);
                data_in[i * org.Width + j] = new DataPoint(org.GetPixel(j, i));
            }
        }
        for (int i = 0; i < clusters; i++)
        {
            centroids[i] = new(rnd);
        }
    }
    public void Converge()
    {
        double error = new double();
        List<DataPoint>[] samples = new List<DataPoint>[clusters];

        while (true)
        {
            for (int i = 0; i < clusters; i++)
            {
                samples[i] = new List<DataPoint>();
            }

            for (int i = 0; i < count; i++)
            {
                double norm = double.MaxValue;
                int cluster = 0;

                for (int j = 0; j < clusters; j++)
                {
                    int temp = DataPoint.Dist(data_in[i], centroids[j]);
                    if (norm > temp)
                    {
                        norm = temp;
                        cluster = j;
                    }
                }
                samples[cluster].Add(data_in[i]);

                data_out[i] = centroids[cluster];
            }

            var new_centroids = new DataPoint[clusters];

            for (int i = 0; i < clusters; i++)
            {
                int Rsum = 0, Gsum = 0, Bsum = 0;
                for (int j = 0; j < samples[i].Count(); j++)
                {
                    Rsum += samples[i][j].R;
                    Gsum += samples[i][j].G;
                    Bsum += samples[i][j].B;
                }
                int div = samples[i].Count() + 1;
                new_centroids[i] = new DataPoint(Color.FromArgb(Rsum / div, Gsum / div, Bsum / div));
            }

            int new_error = 0;

            for (int i = 0; i < clusters; i++)
            {
                new_error += DataPoint.Dist(centroids[i],new_centroids[i]);
                centroids[i] = new_centroids[i];
            }

            if (error == new_error)
            {
                break;
            }
            else
            {
                error = new_error;
            }
        }
    }
    public void Apply()
    {
        for (int i = 0; i < org.Height; i++)
        {
            for (int j = 0; j < org.Width; j++)
            {
                res.SetPixel(j, i, data_out[i * org.Width + j].ToColor());
            }
        }
    }
}