using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    public class Polygon
    {
        public List<Vertex> vertices;
        public HashSet<(Vertex v1, Vertex v2)> lengthRestriction;
        public Polygon()
        {
            vertices = new List<Vertex>();
            lengthRestriction = new HashSet<(Vertex v1, Vertex v2)>();
        }
        public void AddVertex(Vertex v)
        {
            vertices.Add(v);
        }
    }
}
