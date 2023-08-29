using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class Polygon
    {
        public List<Vertex> vertices;
        public List<Edge> edges;
        public Bitmap bitmap;
        
        public Polygon(List<Vertex> vertices, Bitmap bitmap)
        {
            this.vertices = vertices;
            this.edges = new List<Edge>();

            for (int i = 0; i < vertices.Count - 1; i++)
            {
                this.edges.Add(new Edge(vertices[i], vertices[i + 1]));
            }
            this.edges.Add(new Edge(vertices[0], vertices[^1]));
            this.bitmap = bitmap;
        }
        public int GetYMin()
        {
            int ymin = int.MaxValue;
            foreach (Vertex v in vertices)
            {
                if (v.position.Y < ymin) ymin = (int)v.position.Y;
            }
            return ymin;
        }
        public int GetYMax()
        {
            int ymax = 0;
            foreach (Vertex v in vertices)
            {
                if (v.position.Y > ymax) ymax = (int)v.position.Y;
            }
            return ymax;
        }
        public void Draw(Graphics g)
        {
            foreach (var e in this.edges) e.Draw(g);
        }
        public void FillPolygon(Graphics g)
        {
            var min = GetYMin();
            var max = GetYMax();
            var curr = min;
            List<BucketEdge>[] buckets = new List<BucketEdge>[max - min + 1];
            List<BucketEdge> AET = new List<BucketEdge>();

            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<BucketEdge>();
            }
            foreach (var e in edges)
            {
                if (!e.isParallelToScanLine) buckets[(int)e.GetYMin() - min].Add(new BucketEdge(e));
            }

            //scanlinia
            for (int i = min; i < max + 1; i++)
            {
                if (buckets[i - min].Count > 0)
                {
                    foreach (var ae in buckets[i - min]) AET.Add(ae);
                }
                if (AET.Count > 1)
                {
                    AET.Sort((x, y) => x.xmin > y.xmin ? 1 : x.xmin < y.xmin ? -1 : 0);
                }

                //wypełnianie
                if (AET.Count > 1)
                {
                    for (int k = 0; k < AET.Count; k += 2)
                    {
                        for (int j = (int)AET[k].xmin + 1; j <= AET[k + 1].xmin + 1; j++)
                        {
                            Color color = Color.White;
                            if (Calculations.interpolationFlagColor)
                            {
                                //wyznaczany tylko w wierzchołkach trójkątów a potem interpolowany 'do wnętrza'
                                var colors = new Color[3];
                                var normals = vertices.Select(p => p.normal).ToArray();
                                for(int l = 0; l < 3; l++)
                                {
                                    if (Form1.map != null)
                                    {
                                       normals[l] = Calculations.CalculateNormal(normals[l], Form1.map.GetPixel(j, curr));

                                    }
                                    colors[l] = Calculations.CalculateColor(normals[l]);
                                }
                                var bari = Baricentric(j, curr);
                                var R = colors[0].R * bari.X + colors[1].R * bari.Y + colors[2].R * bari.Z; 
                                var G = colors[0].G * bari.X + colors[1].G * bari.Y + colors[2].G * bari.Z;
                                var B = colors[0].B * bari.X + colors[1].B * bari.Y + colors[2].B * bari.Z;

                                R = R < 0 ? 0 : R > 255 ? 255 : R;
                                G = G < 0 ? 0 : G > 255 ? 255 : G;
                                B = B < 0 ? 0 : B > 255 ? 255 : B;
                                color = Color.FromArgb((int)R, (int)G, (int)B);
                            }
                            else
                            {
                                //wyznaczany dokładnie w punkcie interpolując wektory normalne 'do wnętrza'
                                var normals = vertices.Select(p => p.normal).ToArray();
                                var bari = Baricentric(j, curr);
                                var X = normals[0].X * bari.X + normals[1].X * bari.Y + normals[2].X * bari.Z;
                                var Y = normals[0].Y * bari.X + normals[1].Y * bari.Y + normals[2].Y * bari.Z;
                                var Z = normals[0].Z * bari.X + normals[1].Z * bari.Y + normals[2].Z * bari.Z;
                                var vec = new Vector3(X, Y, Z);
                                if (Form1.map != null)
                                {
                                    vec = Calculations.CalculateNormal(vec, Form1.map.GetPixel(j, curr));
                                    
                                }
                                color = Calculations.CalculateColor(vec);
                            }
                            if(Form1.texture != null)
                            {
                                Color tp = Form1.texture.GetPixel(j, curr);
                                bitmap.SetPixel(j, curr, Color.FromArgb(color.R * tp.R / 255, color.G * tp.G / 255, color.B * tp.B / 255));
                            }
                            else
                            {
                                bitmap.SetPixel(j, curr, color);
                            }
                        }
                    }

                    foreach (var ae in AET)
                    {
                        ae.xmin += ae.dxdy <= int.MaxValue ? ae.dxdy : 0;
                    }

                }
                curr++;

                //usuwanie z aet
                for (int j = AET.Count - 1; j >= 0; j--)
                {
                    if (AET[j].ymax == curr)
                    {
                        AET.Remove(AET[j]);
                    }
                }

            }


        }
        public Vector3 Baricentric(int x, int y)
        {
            //https://codeplea.com/triangular-interpolation
            var p = vertices.Select(p => p.position).ToArray();
            float w1 = ((p[1].Y - p[2].Y) * (x - p[2].X) + (p[2].X - p[1].X) * (y - p[2].Y)) /
                ((p[1].Y - p[2].Y) * (p[0].X - p[2].X) + (p[2].X - p[1].X) * (p[0].Y - p[2].Y));
            float w2 = ((p[2].Y - p[0].Y) * (x - p[2].X) + (p[0].X - p[2].X) * (y - p[2].Y)) /
            ((p[1].Y - p[2].Y) * (p[0].X - p[2].X) + (p[2].X - p[1].X) * (p[0].Y - p[2].Y));
            float w3 = 1 - w1 - w2;
            return new Vector3(w1, w2, w3);
        }
    }
    public class BucketEdge
    {
        public int ymax;
        public float xmin;
        public float dxdy;
        public Edge e;
        public BucketEdge(Edge e)
        {
            ymax = (int)Math.Max(e.v1.position.Y, e.v2.position.Y);
            xmin = (int)e.v1.position.X;
            dxdy = e.dxdy;
            this.e = e;
        }
    }
}
