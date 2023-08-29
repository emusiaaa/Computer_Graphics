using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3DScene
{
    public class Vertex
    {
        public Vector4 modelPosition;
        public Vector3 modelNormal;

        public Vector4 worldPosition;

        public Vector4 viewPosition;
        public Vector3 viewNormal;

        public Vector3 worldNormal;

        public Vector3 cameraVector;
        public Vertex(Vector3 position, Vector3 normal)
        {
            this.modelPosition = new Vector4(position, 1);
            this.modelNormal = normal;
        }
    }
}
