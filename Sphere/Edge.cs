using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class Edge
    {
        public Vertex v1;
        public Vertex v2;
        public Pen pen;
        public float dxdy;
        public bool isParallelToScanLine;
        public Edge(Vertex v1, Vertex v2) { 
            this.v1 = v1.position.Y < v2.position.Y ? v1: v2; 
            this.v2 = v1.position.Y >= v2.position.Y ? v1 : v2;
            dxdy = (v1.position.X - v2.position.X)/ (v1.position.Y - v2.position.Y);
            isParallelToScanLine = (int)v1.position.Y == (int)v2.position.Y;
            pen = new Pen(Brushes.Black);
        }
        public void Draw(Graphics g)
        {
            g.DrawLine(pen, v1.position.X, v1.position.Y, v2.position.X, v2.position.Y);
        }
        //public float GetXMin ()
        //{
        //    return v1.position.X < v2.position.X ? v1.position.X : v2.position.X;
        //}
        //public float GetXMax()
        //{
        //    return v1.position.X > v2.position.X ? v1.position.X : v2.position.X;
        //}
        public float GetYMin()
        {
            return v1.position.Y < v2.position.Y ? v1.position.Y : v2.position.Y;
        }
        public float GetYMax()
        {
            return v1.position.Y > v2.position.Y ? v1.position.Y : v2.position.Y;
        }
    }
}
