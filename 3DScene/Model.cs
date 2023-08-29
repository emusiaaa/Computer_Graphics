using _3DScene.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3DScene
{
    public class Model
    {
        public List<Polygon> polygons;
        public Matrix4x4 modelMatrix;
        public Matrix4x4 scaleMatrix;
        public Matrix4x4 rotationMatrix;
        public Color color;
        public Model()
        {
            polygons = new List<Polygon>();
            modelMatrix = Matrix4x4.Identity;
            rotationMatrix = Matrix4x4.Identity;
        }
    }
    public class Fish : Model
    {
        public Fish() : base()
        {
            color = Color.LightGreen;
            scaleMatrix = Matrix4x4.CreateScale(25);
            string path = "..\\..\\..\\objects\\ryba3.obj";
            Parser.Parse(path, polygons);
            Matrix4x4 initial = Matrix4x4.CreateRotationZ((float)Math.PI)
                * Matrix4x4.CreateRotationX((float)Math.PI / 2)
                 * Matrix4x4.CreateRotationY((float)Math.PI / 2)
              ;
            foreach (var polygon in polygons)
            {
                foreach (var v in polygon.vertices)
                {
                    v.modelPosition = Vector4.Transform(v.modelPosition, initial);
                    v.modelNormal = Vector3.TransformNormal(v.modelNormal, initial);
                }
            }
        } 
    }
    public class Sand : Model
    {
        public Sand() : base()
        {
            color = Color.FromArgb(255,255,227);
            scaleMatrix = Matrix4x4.CreateScale(400);
            string path = "..\\..\\..\\objects\\sand.obj";
            Parser.Parse(path, polygons);
            modelMatrix = scaleMatrix * Matrix4x4.CreateRotationZ((float)Math.PI)
                * Matrix4x4.CreateTranslation(new Vector3(0,400,100));
        }
    }
    public class Pear : Model
    {
        public Pear() : base()
        {
            color = Color.Red;
            scaleMatrix = Matrix4x4.CreateScale(1000);
            string path = "..\\..\\..\\objects\\gruszka.obj";
            Parser.Parse(path, polygons);
            modelMatrix = scaleMatrix *Matrix4x4.CreateRotationZ((float)Math.PI) * Matrix4x4.CreateTranslation(new Vector3(0, 340, 0));
            rotationMatrix = Matrix4x4.CreateRotationZ((float)Math.PI);
        }
    }
}
