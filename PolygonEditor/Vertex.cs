using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
     public class Vertex
    {
        public PointF p;
        public Polygon daddy;
        public SolidBrush brush;
        public int radius;
        public Vertex(PointF p, Polygon daddy)
        {
            this.p = p;
            this.brush = new SolidBrush(Color.Black);
            this.daddy = daddy;
            radius = 8;
        }
        public Vertex((int x, int y) p, Polygon daddy)
        {
            this.p = new PointF(p.x, p.y);
            this.brush = new SolidBrush(Color.Black);
            this.daddy = daddy;
            radius = 8;
        }
        public Vertex()
        {
            p = new PointF(-1, -1);
            this.brush = new SolidBrush(Color.Black);
            this.daddy = new Polygon();
            radius = 0;
        }
        public void Draw(Graphics g)
        {
            PointF point = new PointF(p.X - radius, p.Y - radius);
            Size size = new Size(2 * radius, 2 * radius);
            g.FillEllipse(brush, p.X - radius, p.Y - radius, 2 * radius, 2 * radius);
        }
    }
}
