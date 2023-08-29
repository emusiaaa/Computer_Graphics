using System.Drawing;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.DataFormats;

namespace Polygons
{
    public partial class Window : Form
    {
        private Bitmap bitmap;
        private List<Polygon> polygons = new List<Polygon> { };
        private Polygon? curr = null;
        private int radius = 8;
        private (Polygon polygon, Vertex v, bool isSelected, int index) selected;
        private (Polygon pol, Vertex v1, Vertex v2, int v2_index, bool isSelected) leftSelectedEdge;
        private (Polygon pol, Vertex v1, Vertex v2, int v2_index, bool isSelected) rightSelectedEdge;
        private List<(Polygon pol, Vertex v1, Vertex v2, int v2_index, bool isSelected)> restrictionEdges = new List<(Polygon pol, Vertex v1, Vertex v2, int v2_index, bool isSelected)> { };
        bool isMouseDown = false;
        bool didMouseMoveVertex = false;
        bool didMouseMoveEdge = false;
        bool isThatTheSameVertex = false;
        PointF mouseLocation = new PointF(0, 0);
        public List<Relation> relations = new List<Relation> { };

        public Window()
        {
            InitializeComponent();
            bitmap = new Bitmap(CANVA.Size.Width, CANVA.Size.Height);
            radioButton_Default.Checked = true;
            InitPolygons();
            CANVA.Invalidate();
        }
        private void InitPolygons()
        {
            var P1 = new Polygon();
            var P2 = new Polygon();
            var P3 = new Polygon();
            var xy = new[] { (400, 290), (100, 250), (180, 100), (300, 100) };
            var vz = new[] { (600, 680), (700, 480), (570, 580), (234, 590) };
            var s = new[] { (750, 500), (850, 500), (1000, 500), (1100, 420), (850, 300), (800, 150), (750, 100), (700,400) };


            foreach (var p in xy) P1.AddVertex(new Vertex(p, P1));
            foreach (var p in vz) P2.AddVertex(new Vertex(p, P1));
            foreach (var p in s) P3.AddVertex(new Vertex(p, P3));
            
            relations.Add(new LengthRelation(P1.vertices[2], P1.vertices[3]));
            relations.Add(new LengthRelation(P3.vertices[3], P3.vertices[4]));
            relations.Add(new PerpedicularRelation((P2.vertices[0], P2.vertices[1]),(P2.vertices[2], P2.vertices[3])));
            relations.Add(new PerpedicularRelation((P3.vertices[0], P3.vertices[1]), (P3.vertices[1], P3.vertices[2])));
            relations.Add(new PerpedicularRelation((P3.vertices[6], P3.vertices[7]), (P1.vertices[3], P1.vertices[0])));
            relations.Add(new LengthRelation(P3.vertices[2], P3.vertices[3]));

            relations[2].FixRelation(P2.vertices[0]);
            relations[3].FixRelation(P3.vertices[1]);
            relations[4].FixRelation(P3.vertices[6]);

            polygons.Add(P1);
            polygons.Add(P2);
            polygons.Add(P3);
        }
        private void CANVA_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && button_Mode.Enabled && !didMouseMoveEdge && !didMouseMoveVertex)
            {
                PointF pNow = e.Location;
                AddingVertex(pNow);
            }
            if (e.Button == MouseButtons.Left && !button_Mode.Enabled && leftSelectedEdge.isSelected)
            {
                ManageRestrictionMode();
            }
            CANVA.Invalidate();
        }
        private void AddingVertex(PointF pNow)
        {
            //building polygon
            if (!selected.isSelected && !leftSelectedEdge.isSelected)
            {
                if (curr == null)
                {
                    curr = new Polygon();
                    curr.AddVertex(new Vertex(pNow, curr));
                    curr.vertices[0].brush.Color = Color.Green;
                }
                else curr.AddVertex(new Vertex(pNow, curr));
            }
            //finish polygon
            else if (curr != null && selected.v == curr.vertices[0] && curr.vertices.Count > 2)
            {
                curr.vertices[0].brush.Color = Color.Black;
                polygons.Add(curr);
                curr = null;
                isThatTheSameVertex = true;
                selected.isSelected = false;
            }
            //deselecting
            else if (isThatTheSameVertex && selected.v.brush.Color == Color.Red)
            {
                selected.isSelected = false;
                selected.v.brush.Color = Color.Black;
            }
            //Add on edge
            else if (leftSelectedEdge.isSelected)
            {
                for (int i = relations.Count - 1; i >= 0; i--)
                {
                    if (relations[i].ContainsEdge((leftSelectedEdge.v1, leftSelectedEdge.v2))) relations.RemoveAt(i);
                }

                leftSelectedEdge.pol.vertices.Insert(leftSelectedEdge.v2_index, new Vertex(pNow, leftSelectedEdge.pol));
                CANVA.Invalidate();
            }
        }
        private void ManageRestrictionMode()
        {
            Vertex v1, v2, v3, v4;
            switch (restrictionEdges.Count)
            {
                case 0:
                    restrictionEdges.Add(leftSelectedEdge);
                    v1 = restrictionEdges[0].v1;
                    v2 = restrictionEdges[0].v2;
                    if (isTheEdgeRelated((v1, v2))) button_Delete.Enabled = true;
                    else button_RestrictLength.Enabled = true;
                    leftSelectedEdge.v1.brush.Color = Color.BlueViolet;
                    leftSelectedEdge.v2.brush.Color = Color.BlueViolet;
                    break;
                case 1:
                    v1 = restrictionEdges[0].v1;
                    v2 = restrictionEdges[0].v2;
                    v3 = leftSelectedEdge.v1;
                    v4 = leftSelectedEdge.v2;
                    if (!isTheEdgeRelated((v1, v2)) && !isTheEdgeRelated((v3, v4)))
                    {
                        restrictionEdges.Add(leftSelectedEdge);
                        button_AddRelation.Enabled = true;
                        button_RestrictLength.Enabled = false;
                        v3.brush.Color = Color.BlueViolet;
                        v4.brush.Color = Color.BlueViolet;
                    }
                    break;
                case 2:
                    MessageBox.Show("There is already two edges selected");
                    break;
            }
        }
        private void CANVA_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            foreach (Polygon p in polygons)
            {
                PaintPolygon(g, p, true);
            }
            if (curr != null)
            {
                PaintPolygon(g, curr, false);
            }
            foreach (var r in relations)
            {
                r.Draw(g, this.Font);
            }
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        private void PaintPolygon(Graphics g, Polygon p, bool isFinished)
        {
            for (int i = 1; i < p.vertices.Count; i++)
            {
                var v1 = p.vertices[i - 1];
                var v2 = p.vertices[i];
                drawLine(g, v1.p, v2.p);
                v1.Draw(g);
            }
            if (isFinished)
            {
                drawLine(g, p.vertices[0].p, p.vertices[^1].p);
                var v1 = p.vertices[^1];
                var v2 = p.vertices[0];
            }
            p.vertices[0].Draw(g);
            p.vertices[^1].Draw(g);
        }

        private bool isThereAnyVertex(PointF p)
        {
            foreach (var pol in polygons)
            {
                if (isThatAVertexFromThisPolygon(p, pol)) return true;
            }
            if (curr != null)
            {
                if (isThatAVertexFromThisPolygon(p, curr)) return true;
            }
            return false;
        }
        private bool isThatAVertexFromThisPolygon(PointF p, Polygon pol)
        {
            int i = 0;
            foreach (var v in pol.vertices)
            {
                if ((p.X - v.p.X) * (p.X - v.p.X) + (p.Y - v.p.Y) * (p.Y - v.p.Y) < 4 * radius * radius)
                {
                    if (selected.isSelected) selected.v.brush.Color = Color.Black;
                    v.brush.Color = Color.Red;
                    if (selected.v == v && !isThatTheSameVertex) isThatTheSameVertex = true;
                    else isThatTheSameVertex = false;
                    selected = (pol, v, true, i);
                    return true;
                }
                i++;
            }
            return false;
        }
        private (Polygon pol, Vertex v1, Vertex v2, int v2_index, bool isIt) isThereAnyEdge(PointF p)
        {
            Vertex v1, v2;
            foreach (var polygon in polygons)
            {
                v1 = polygon.vertices[0];
                v2 = polygon.vertices[polygon.vertices.Count - 1];
                if (IsThePointOnEdge(v1, v2, p))
                {
                    return (polygon, v2, v1, polygon.vertices.Count, true);
                }
                for (int i = 1; i < polygon.vertices.Count; i++)
                {
                    v1 = polygon.vertices[i - 1];
                    v2 = polygon.vertices[i];
                    if (IsThePointOnEdge(v1, v2, p))
                    {
                        return (polygon, v1, v2, i, true);
                    }
                }
            }
            return (new Polygon(), new Vertex(), new Vertex(), -1, false);
        }
        private bool IsThePointOnEdge(Vertex v1, Vertex v2, PointF p)
        {
            double d = Distance(v1.p, v2.p);
            double d1 = Distance(v1.p, p);
            double d2 = Distance(p, v2.p);
            if (Math.Abs(d - d1 - d2) < 0.1) return true;
            else return false;
        }
        public static double Distance(PointF p1, PointF p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
        private void drawLine(Graphics g, PointF p1, PointF p2)
        {
            Pen pen = new Pen(Color.Black);
            if (radioButton_Default.Checked == true)
                g.DrawLine(pen, p1, p2);
            else Bresenham(g, p1, p2, pen);
        }
        private void Bresenham(Graphics g, PointF p1, PointF p2, Pen pen)
        {
            //https://stackoverflow.com/questions/11678693/all-cases-covered-bresenhams-line-algorithm

            int x = ((int)p1.X);
            int x2 = ((int)p2.X);
            int y = ((int)p1.Y);
            int y2 = ((int)p2.Y);

            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;
            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);
            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }
            int numerator = longest >> 1;
            for (int i = 0; i <= longest; i++)
            {
                if (x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height)
                    bitmap.SetPixel(x, y, Color.Black);
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }
        }
        private void button_ClearAll_Click(object sender, EventArgs e)
        {
            polygons.Clear();
            curr = null;
            relations.Clear();
            CANVA.Invalidate();
        }

        private void CANVA_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseLocation = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                if (button_Mode.Enabled) isThereAnyVertex(e.Location);
                leftSelectedEdge = isThereAnyEdge(e.Location);
            }
            if (e.Button == MouseButtons.Right && button_Mode.Enabled)
            {
                rightSelectedEdge = isThereAnyEdge(e.Location);
            }
        }

        private void button_DeleteVertex_Click(object sender, EventArgs e)
        {
            if (selected.isSelected && button_Mode.Enabled)
            {
                if (curr != null && selected.polygon == curr)
                {
                    if (curr.vertices.Count == 1) curr = null;
                    else if (selected.v == curr.vertices[0])
                    {
                        selected.v.brush.Color = Color.Black;

                        if (curr.vertices.Count < 3) curr = null;
                    }
                    else curr.vertices.Remove(selected.v);
                }
                else
                {
                    if (selected.polygon.vertices.Count > 3)
                    {
                        for (int i = relations.Count - 1; i >= 0; i--)
                        {
                            if (relations[i].ContainsVertex(selected.v)) relations.RemoveAt(i);
                        }
                        selected.polygon.vertices.Remove(selected.v);
                    }
                    else polygons.Remove(selected.polygon);
                }
            }
            selected.isSelected = false;
            CANVA.Invalidate();
        }
        private void CANVA_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            if (didMouseMoveVertex)
            {
                selected.v.brush.Color = Color.Black;
                didMouseMoveVertex = false;
                selected.isSelected = false;
                CANVA.Invalidate();
            }
            if (didMouseMoveEdge)
            {
                leftSelectedEdge.isSelected = false;
                didMouseMoveEdge = false;
            }
        }
        private void CANVA_MouseMove(object sender, MouseEventArgs e)
        {
            //ew tutaj ruszanie daæ w now¹ funkcjê
            //ruszanie wierzcho³ków
            if (isMouseDown && selected.isSelected && selected.polygon != curr && e.Button == MouseButtons.Left && button_Mode.Enabled)
            {
                selected.v.p = e.Location;
                mouseLocation.X = e.X;
                mouseLocation.Y = e.Y;
                //
                didMouseMoveVertex = true;
                //
                FixRelations(selected.polygon.vertices, selected.index);

                CANVA.Invalidate();
            }
            //ruszanie krawêdzi¹
            else if (isMouseDown && leftSelectedEdge.isSelected && e.Button == MouseButtons.Left && button_Mode.Enabled)
            {
                //tu
                didMouseMoveEdge = true;
                leftSelectedEdge.v1.p.X += e.X - mouseLocation.X;
                leftSelectedEdge.v1.p.Y += e.Y - mouseLocation.Y;
                leftSelectedEdge.v2.p.X += e.X - mouseLocation.X;
                leftSelectedEdge.v2.p.Y += e.Y - mouseLocation.Y;
                mouseLocation.X = e.X;
                mouseLocation.Y = e.Y;
                FixRelations(leftSelectedEdge.pol.vertices, leftSelectedEdge.v2_index);

                CANVA.Invalidate();
            }
            //ruszanie wielok¹tem
            else if (isMouseDown && rightSelectedEdge.isSelected && e.Button == MouseButtons.Right)
            {
                foreach (var v in rightSelectedEdge.pol.vertices)
                {
                    v.p.X += e.X - mouseLocation.X;
                    v.p.Y += e.Y - mouseLocation.Y;
                }
                mouseLocation.X = e.X;
                mouseLocation.Y = e.Y;
                CANVA.Invalidate();
            }
        }
        public void FixRelations(List<Vertex> vertices, int index)
        {
            HashSet<(Relation, Vertex v)> naprawo = new HashSet<(Relation, Vertex v)> { };
            HashSet<(Relation, Vertex v)> nalewo = new HashSet<(Relation, Vertex v)> { };
            List<Vertex> right = new List<Vertex>(vertices.GetRange(index, vertices.Count - index));
            if (index != 0) right.AddRange(vertices.GetRange(0, index));
            //sprawdzam na prawo relacje
            Relation? rel = null;
            for (int i = 0; i < right.Count - 1; i++)
            {
                if (isTheEdgeRelated((right[i], right[i + 1])))
                {
                    var g = GetRelation((right[i], right[i + 1]));
                    if (g != null) naprawo.Add((g, right[i]));
                    rel = g;
                }
                else break;
            }
            //teraz na lewo

            right.Reverse();
            right.Insert(0, right[right.Count - 1]);
            right.RemoveAt(right.Count - 1);
            for (int i = 0; i < right.Count - 1; i++)
            {
                if (isTheEdgeRelated((right[i + 1], right[i])))
                {
                    var g = GetRelation((right[i + 1], right[i]));
                    if (g != rel && g != null)
                        nalewo.Add((g, right[i]));
                    else break;
                }

                else break;
            }

            foreach (var r in naprawo)
            {
                if (!r.Item1.IsRelationValid())
                {
                    r.Item1.FixRelation(r.Item2);
                }
            }
            foreach (var r in nalewo)
            {
                if (!r.Item1.IsRelationValid())
                {
                    r.Item1.FixRelation(r.Item2);
                }
            }
            //foreach (var r in relations)
            //{
            //    if (!r.IsRelationValid())
            //    {
            //        r.FixRelation((leftSelectedEdge.v1, leftSelectedEdge.v2));
            //    }
            //}
        }

        private void button_Mode_Click(object sender, EventArgs e)
        {
            button_Mode.Enabled = false;
            button_Cancel.Enabled = true;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            button_Mode.Enabled = true;
            button_Cancel.Enabled = false;
            button_RestrictLength.Enabled = false;
            button_AddRelation.Enabled = false;
            button_Delete.Enabled = false;
            foreach (var v in restrictionEdges)
            {
                v.v1.brush.Color = Color.Black;
                v.v2.brush.Color = Color.Black;
            }
            restrictionEdges.Clear();
            CANVA.Invalidate();
        }

        private void button_RestrictLength_Click(object sender, EventArgs e)
        {
            var v1 = restrictionEdges[0].v1;
            var v2 = restrictionEdges[0].v2;
            if (!isTheEdgeRelated((v1, v2)))
            {
                relations.Add(new LengthRelation(v1, v2));
                v1.brush.Color = Color.Black;
                v2.brush.Color = Color.Black;
            }
            else MessageBox.Show("This edge has already a restriction ;)");
            button_Cancel_Click(sender, e);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            foreach (var edge in restrictionEdges)
            {
                for (int i = relations.Count - 1; i >= 0; i--)
                {
                    if (relations[i].ContainsEdge((edge.v1, edge.v2))) relations.RemoveAt(i);
                }
            }
            button_Delete.Enabled = false;
            button_Cancel_Click(sender, e);
        }

        private void radioButton_Default_CheckedChanged(object sender, EventArgs e)
        {
            CANVA.Invalidate();
        }

        private void button_AddRelation_Click(object sender, EventArgs e)
        {
            var v1 = restrictionEdges[0].v1;
            var v2 = restrictionEdges[0].v2;
            var v3 = restrictionEdges[1].v1;
            var v4 = restrictionEdges[1].v2;
            if (!isTheEdgeRelated((v1, v2)) && !isTheEdgeRelated((v3, v4)))
            {
                relations.Add(new PerpedicularRelation((v1, v2), (v3, v4)));
                CANVA.Invalidate();
            }
            else MessageBox.Show("This edge has already a restriction ;)");

            button_Cancel_Click(sender, e);
        }
        private bool isTheEdgeRelated((Vertex v1, Vertex v2) edge)
        {
            foreach (var r in relations)
            {
                if (r.ContainsEdge(edge)) return true;
            }
            return false;
        }
        private Relation? GetRelation((Vertex v1, Vertex v2) edge)
        {
            foreach (var r in relations)
            {
                if (r.ContainsEdge(edge)) return r;
            }
            return null;
        }

    }
}