using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.DataFormats;

namespace Polygons
{
    
    public abstract class Relation
    {
        public const int constraintRadius = 16;
        public static readonly StringFormat format = new StringFormat()
        {
            LineAlignment = StringAlignment.Center,
            Alignment = StringAlignment.Center
        };
        public abstract bool ContainsVertex(Vertex v);
        public abstract bool ContainsEdge((Vertex v1, Vertex v2) edge);
        public abstract void Draw(Graphics g, Font font);
        public abstract bool IsRelationValid();
        public abstract void FixRelation(Vertex constant);
        public abstract void FixRelation((Vertex v1, Vertex v2) constant);
    }
    public class LengthRelation: Relation
    {
        public Vertex v1;
        public Vertex v2;
        public double length;
        public LengthRelation(Vertex v1, Vertex v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            length = Window.Distance(v1.p, v2.p);
        }

        public override bool IsRelationValid()
        {
            return Math.Abs(length - Window.Distance(v1.p, v2.p)) < 0.01;
        }

        public override bool ContainsEdge((Vertex v1, Vertex v2) edge)
        {
            return (v1, v2) == edge || (v2, v1) == edge;
        }

        public override bool ContainsVertex(Vertex v)
        {
            return v1 == v || v2 == v;
        }

        public override void Draw(Graphics g, Font font)
        {
            var x = (v1.p.X + v2.p.X) / 2;
            var y = (v1.p.Y + v2.p.Y) / 2;
            g.FillEllipse(Brushes.Gold, x - constraintRadius, y - constraintRadius, constraintRadius * 2, constraintRadius * 2);
            g.DrawString("LR", font, Brushes.Black, x, y, format);
        }

        public override void FixRelation(Vertex constant)
        {
            Vertex move;
            if (constant == v1) move = v2;
            else if (constant == v2) move = v1;
            else return;

            double scale = length / Window.Distance(v1.p, v2.p);
            move.p.X = (float)((move.p.X - constant.p.X) * scale + constant.p.X);
            move.p.Y = (float)((move.p.Y - constant.p.Y) * scale + constant.p.Y);
        }

        public override void FixRelation((Vertex v1, Vertex v2) constant)
        {
            if(constant.v1 == this.v1 || constant.v1 == this.v2)
            {
                FixRelation(constant.v1);
            }
            else if (constant.v2 == this.v1 || constant.v2 == this.v2)
            {
                FixRelation(constant.v2);
            }
        }
    }
     public class PerpedicularRelation : Relation
    {
        public (Vertex v1, Vertex v2) edge1;
        public (Vertex v1, Vertex v2) edge2;
        private static int quantity = 1;
        public int id = 0;
        public PerpedicularRelation((Vertex v1, Vertex v2) edge1, (Vertex v1, Vertex v2) edge2)
        {
            if (edge1.v1.daddy == edge2.v1.daddy 
                && edge1.v1.daddy.vertices.IndexOf(edge1.v1)> edge1.v1.daddy.vertices.IndexOf(edge2.v1))
            {
                this.edge1 = edge2;
                this.edge2 = edge1;
            }
            else {
            this.edge1 = edge1;
            this.edge2 = edge2; 
            }
            this.id = quantity++;
        }
        public override bool ContainsVertex(Vertex v)
        {
            return edge1.v1 == v || edge1.v2 == v || edge2.v1 == v || edge2.v2 == v;
        }
        public override bool ContainsEdge((Vertex v1, Vertex v2) edge)
        {
            return edge1 == edge || edge2 == edge;
        }
        public override void Draw(Graphics g, Font font)
        {
            var x = (edge1.v1.p.X + edge1.v2.p.X) / 2;
            var y = (edge1.v1.p.Y + edge1.v2.p.Y) / 2;
            g.FillEllipse(Brushes.Lavender, x - constraintRadius, y - constraintRadius, constraintRadius * 2, constraintRadius * 2);
            g.DrawString("P"+id.ToString(), font, Brushes.Black, x, y, format);

            x = (edge2.v1.p.X + edge2.v2.p.X) / 2;
            y = (edge2.v1.p.Y + edge2.v2.p.Y) / 2;
            g.FillEllipse(Brushes.Lavender, x - constraintRadius, y - constraintRadius, constraintRadius * 2, constraintRadius * 2);
            g.DrawString("P" + id.ToString(), font, Brushes.Black, x, y, format);
        }

        public override bool IsRelationValid()
        {
            return Math.Abs((edge1.v2.p.Y - edge1.v1.p.Y) * (edge2.v2.p.X - edge2.v1.p.X) - (edge2.v2.p.Y - edge2.v1.p.Y) * (edge1.v2.p.X - edge1.v1.p.X)) < 0.01;
        }

        public override void FixRelation(Vertex constant)
        {
            Vertex move;
            Vertex constant2;
            Vertex move2;
            if (edge1.v1 == constant)
            {
                constant2 = edge1.v2;
                move = edge2.v1;
                move2 = edge2.v2;
            }
            else if (edge1.v2 == constant)
            {
                constant2 = edge1.v1;
                move = edge2.v1;
                move2 = edge2.v2;
            }
            else if (edge2.v1 == constant)
            {
                constant2 = edge2.v2;
                move = edge1.v1;
                move2 = edge1.v2;
            }
            else if (edge2.v2 == constant)
            {
                constant2 = edge2.v1;
                move = edge1.v1;
                move2 = edge1.v2;
            }
            else return;
            if(constant == move)
            {
                Vertex temp = move;
                move = move2;
                move2 = temp;
            }
            PointF p5 = new PointF(constant2.p.X + move2.p.X - constant.p.X, constant2.p.Y + move2.p.Y - constant.p.Y);
            PointF p6 = new PointF(move2.p.Y - p5.Y + move2.p.X, p5.X - move2.p.X + move2.p.Y);
            double scale = Window.Distance(move.p, move2.p) / Window.Distance(p6, move2.p);
            PointF p7 = new PointF((float)(scale * (p6.X - move2.p.X) + move2.p.X), (float)(scale * (p6.Y - move2.p.Y) + move2.p.Y));
            move.p = p7;
        }

        public override void FixRelation((Vertex v1, Vertex v2) constant)
        {
            if (constant.v1 == this.edge1.v1 || constant.v1 == this.edge1.v2 || constant.v1 == this.edge2.v1 || constant.v1 == this.edge2.v2)
            {
                FixRelation(constant.v1);
            }
            if (constant.v2 == this.edge1.v1 || constant.v2 == this.edge1.v2 || constant.v2 == this.edge2.v1 || constant.v2 == this.edge2.v2)
            {
                FixRelation(constant.v2);
            }
        }
    }
}
