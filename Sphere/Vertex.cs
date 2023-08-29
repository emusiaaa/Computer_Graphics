using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class Vertex
    {
        public Vector3 position;
        public Vector3 normal;
        public Vertex(float x, float y, float z, float xn, float yn, float zn)
        {
            position = new Vector3(x,y, z);
            normal = new Vector3(xn, yn, zn);
        }
        public Vertex(Vector3 position, Vector3 normal)
        {
            this.position = new Vector3(position.X, position.Y, position.Z);
            this.normal = new Vector3(normal.X, normal.Y, normal.Z);
        }
    }
}
