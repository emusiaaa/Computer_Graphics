using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3DScene
{
    public class Polygon
    {
        public List<Vertex> vertices;
        public List<Edge> edges;
        public Color[] gourandColors; 
        public Polygon(List<Vertex> vertices)
        {
            this.vertices = vertices;
            gourandColors = new Color[vertices.Count];
            edges = new List<Edge>();

            for (int i = 0; i < vertices.Count - 1; i++)
            {
                edges.Add(new Edge(vertices[i], vertices[i + 1]));
            }
            edges.Add(new Edge(vertices[0], vertices[^1]));
        }
        public int GetYMin()
        {
            int ymin = int.MaxValue;
            foreach (Vertex v in vertices)
            {
                if (v.viewPosition.Y < ymin) ymin = (int)v.viewPosition.Y;
            }
            return ymin;
        }
        public int GetYMax()
        {
            int ymax = 0;
            foreach (Vertex v in vertices)
            {
                if (v.viewPosition.Y > ymax) ymax = (int)v.viewPosition.Y;
            }
            return ymax;
        }
        public void FillPolygon(Graphics g, DirectBitmap dirBitmap, Color obj)
        {
            //var ver = vertices.Select(p => p.viewPosition);
            //if (ver.Any(p => p.X < 0 || p.Y < 0 || p.Y >= 1123 || p.X >= 809)) return;
            Color color= Color.White;
            if (Properties.shading == 0)
            {
                var bari = Baricentric((int)vertices[0].worldPosition.X, (int)vertices[0].worldPosition.Y);
                color = Properties.CalculateConst(vertices, bari, obj);
            }
            else if(Properties.shading == 1)
            {
                Properties.initialGourand(this, obj);
            }
               
            var min = Math.Max(GetYMin(),0);
            min = Math.Min(min, Properties.bitmapHeight - 1);
            var max = Math.Min(GetYMax(), Properties.bitmapHeight-1);
            var curr = min;
            if (max - min + 1 < 0) return;
            List<BucketEdge>[] buckets = new List<BucketEdge>[max - min + 1];
            List<BucketEdge> AET = new List<BucketEdge>();

            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<BucketEdge>();
            }
            foreach (var e in edges)
            {
                e.dxdy = (e.v1.viewPosition.X - e.v2.viewPosition.X) / (e.v1.viewPosition.Y - e.v2.viewPosition.Y);
                //check if it's parallel to scan line
                int ymin = (int)Math.Min(e.GetYMin(), Properties.bitmapHeight - 1);
                if ((int)e.v1.viewPosition.Y != (int)e.v2.viewPosition.Y && ymin!= Properties.bitmapHeight - 1) buckets[ymin - min].Add(new BucketEdge(e));
                
            }

            //scanlinia
            for (int i = min; i <= max; i++)
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
                        var xmin = Math.Max((int)AET[k].xmin, 0);
                        var xmax = Math.Min((int)AET[k + 1].xmin, Properties.bitmapWidth - 1);
                        for (int j = xmin; j <=xmax; j++)
                        {
                            var bari = Baricentric(j, curr);

                            float z = bari.X * vertices[0].viewPosition.Z + bari.Y * vertices[1].viewPosition.Z + bari.Z * vertices[2].viewPosition.Z;

                            //Color color = Properties.CalculateGourand(vertices, bari);
                           
                            if (Properties.shading == 1)
                                color = Properties.CalculateGourand(bari, this.gourandColors);
                            else if (Properties.shading == 2)
                                color = Properties.CalculateColor2(vertices, bari, obj);
                            //color = Properties.CalculatePhong(vertices, bari, obj);
                            //else
                            //    color = Properties.CalculateConst(vertices, bari, obj);
                            if ( (j < 1124 && j >= 0 && curr < 810 && curr >= 0) && z <= Properties.zbuffer.Zbuffer[j, curr])
                            {
                                dirBitmap.SetPixel(j, curr, color);
                                Properties.zbuffer.Zbuffer[j, curr] = z;
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
            var p = vertices.Select(p => p.viewPosition).ToArray();
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
            ymax = (int)Math.Max(e.v1.viewPosition.Y, e.v2.viewPosition.Y);
            xmin = e.v1.viewPosition.Y < e.v2.viewPosition.Y ? e.v1.viewPosition.X : e.v2.viewPosition.X;
            dxdy = e.dxdy;
            this.e = e;
        }
    }
}
