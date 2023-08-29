
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public static class Calculations
    {
        public static Color light = Color.BlueViolet;
        public static Color obj = Color.White;
        public static float k_s = 0.5F;
        public static float k_d = 0.5F;
        public static float m = 40;
        public static Vector3 V = new Vector3(0, 0, 1);
        public static Vector3 lightPosition = new Vector3(0, 0, 1000);
        public static Vector3 ligthCenter = new Vector3(0, 0, 1000);
        public static bool interpolationFlagColor = true;
        public static Color CalculateColor(Vector3 normal)
        {
            var R_vector = 2 * Vector3.Dot(normal, lightPosition) * normal - lightPosition;
            float cos1 = Vector3.Dot(Vector3.Normalize(normal), Vector3.Normalize(lightPosition));
            cos1 = cos1 < 0 ? 0 : cos1;
            float cos2 = Vector3.Dot(V, Vector3.Normalize(R_vector));
            cos2 = cos2 < 0 ? 0 : (float)Math.Pow(cos2, m);
            
            int R = (int)((k_d * light.R * obj.R * cos1 + k_s * light.R * obj.R * cos2)/255);
            int G = (int)((k_d * light.G * obj.G * cos1 + k_s * light.G * obj.G * cos2)/255);
            int B = (int)((k_d * light.B * obj.B * cos1 + k_s * light.B * obj.B * cos2)/255);

            R = R < 0 ? 0 : R > 255? 255 : R;
            G = G < 0 ? 0 : G > 255? 255 : G;
            B = B < 0 ? 0 : B > 255 ? 255 : B;

            return Color.FromArgb(R,G,B);
        }

        public static Vector3 CalculateNormal(Vector3 vec, Color tex)
        {
            var mapv = new Vector3((float)tex.R / 128 - 1, (float)tex.G / 128 - 1, (float)tex.B / 128 - 1);
            var normal = new Vector3(vec.X, vec.Y, vec.Z);
            var binormal = Vector3.Cross(normal, new Vector3(0.0f, 0.0f, 1.0f));
            if (normal.X == 0 && normal.Y == 0 && normal.Z == 1)
            {
                binormal = new Vector3(0, 1, 0);
            }
            var tangent = Vector3.Cross(binormal, normal);
            vec = new Vector3(Vector3.Dot(tangent, mapv), Vector3.Dot(binormal, mapv), Vector3.Dot(normal, mapv));
            /*var vec = new Vector3(
                tangent.X * mapv.X + binormal.X * mapv.Y + normal.X * mapv.Z,
                tangent.Y * mapv.X + binormal.Y * mapv.Y + normal.Y * mapv.Z,
                tangent.Z * mapv.X + binormal.Z * mapv.Y + normal.Z * mapv.Z);
            */
            return vec;
        }
    }
}
