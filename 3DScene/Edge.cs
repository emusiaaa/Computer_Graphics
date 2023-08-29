using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DScene
{
    public class Edge
    {
        public Vertex v1;
        public Vertex v2;
        public float dxdy;
        //public bool isParallelToScanLine;
        public Edge(Vertex v1, Vertex v2)
        {
            this.v1 = v1.modelPosition.Y < v2.modelPosition.Y ? v1 : v2;
            this.v2 = v1.modelPosition.Y >= v2.modelPosition.Y ? v1 : v2;
            dxdy = (v1.modelPosition.X - v2.modelPosition.X) / (v1.modelPosition.Y - v2.modelPosition.Y);
           // isParallelToScanLine = (int)v1.modelPosition.Y == (int)v2.modelPosition.Y;
        }
        public void Draw(Graphics g)
        {
            g.DrawLine(Pens.Black, v1.modelPosition.X, v1.modelPosition.Y, v2.modelPosition.X, v2.modelPosition.Y);
        }
        public float GetYMin()
        {
            var y = Math.Min(v1.viewPosition.Y, v2.viewPosition.Y);

            return Math.Max(y,0);
        }
        
    }
}
