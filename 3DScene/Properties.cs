using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DScene
{
    public class Properties
    {
        public enum CameraType
        {
            CenterMode = 0,
            StationaryMode = 1,
            MovingMode = 2,
        }
        public static CameraType cameraType = CameraType.CenterMode;
        public DirectBitmap dirBitmap;
        public static int bitmapWidth;
        public static int bitmapHeight;

        public float fieldOfView = MathF.PI / 2;
        public float nearPlaneDistance = 10;
        public float farPlaneDistance = 5000;

        public static float k_s = 0.4F;
        public static float k_d = 0.2F;
        public static float k_a = 0.2F;
        public static float m = 6;
        public static float p = 1;
        public static Vector3 lightPosition = new Vector3(0, 600, 0);
        public static Vector3 spotLightPosition = new Vector3(0, 0, 0);
        public static Vector3 spotLightTarget = new Vector3(0, 0, 0);

        public static Color light = Color.Yellow;
        public static Color dirLight = Color.White;
        public static Color spotLight = Color.Magenta;
        public static Vector3 dirVector = Vector3.Normalize(new Vector3(1, 1, 1));
        public static Color water = Color.FromArgb(158, 207, 228);
        public static int startFog = 300;
        public static int endFog = 1000;
        public static bool isFog = false;
        public static bool isDirLight = false;
        public static bool isPointLight = false;
        public static bool isSpotLight = false;

        public static ZBuffer zbuffer;

        public Vector3 cameraUpVector = new Vector3(0, 1, 0);

        public static Matrix4x4 viewMatrix = Matrix4x4.Identity;
        public Vector3 cameraPosition = new Vector3(0, 50, 600);
        public static Matrix4x4 perspectiveFieldOfView = Matrix4x4.Identity;

        public static int shading = 1;

        public Properties(DirectBitmap directBitmap)
        {

            dirBitmap = directBitmap;
            bitmapWidth = directBitmap.Width;
            bitmapHeight = directBitmap.Height;

            perspectiveFieldOfView =
                Matrix4x4.CreatePerspectiveFieldOfView
                (fieldOfView, (float)bitmapWidth / (float)bitmapHeight, nearPlaneDistance, farPlaneDistance);

            zbuffer = new ZBuffer(new float[bitmapWidth, bitmapHeight]);
        }     
        public static Color CalculateColor2(List<Vertex> vertices, Vector3 bari, Color obj)
        {
            int R = (int)((k_a * obj.R));
            int G = (int)((k_a * obj.G));
            int B = (int)((k_a * obj.B));

            //diffuse reflection
            var X = vertices[0].viewNormal.X * bari.X + vertices[1].viewNormal.X * bari.Y + vertices[2].viewNormal.X * bari.Z;
            var Y = vertices[0].viewNormal.Y * bari.X + vertices[1].viewNormal.Y * bari.Y + vertices[2].viewNormal.Y * bari.Z;
            var Z = vertices[0].viewNormal.Z * bari.X + vertices[1].viewNormal.Z * bari.Y + vertices[2].viewNormal.Z * bari.Z;
            Vector3 N = Vector3.Normalize(new Vector3(X, Y, Z));

            var XX = vertices[0].worldPosition.X * bari.X + vertices[1].worldPosition.X * bari.Y + vertices[2].worldPosition.X * bari.Z;
            var YY = vertices[0].worldPosition.Y * bari.X + vertices[1].worldPosition.Y * bari.Y + vertices[2].worldPosition.Y * bari.Z;
            var ZZ = vertices[0].worldPosition.Z * bari.X + vertices[1].worldPosition.Z * bari.Y + vertices[2].worldPosition.Z * bari.Z;
            Vector3 L = Vector3.Normalize(new Vector3(Properties.lightPosition.X - XX, Properties.lightPosition.Y - YY, Properties.lightPosition.Z - ZZ));

            float NL = Math.Max(Vector3.Dot(N, L), 0);

            //specular reflection
            Vector3 V = new Vector3(
            vertices[0].cameraVector.X * bari.X + vertices[1].cameraVector.X * bari.Y + vertices[2].cameraVector.X * bari.Z,
            vertices[0].cameraVector.Y * bari.X + vertices[1].cameraVector.Y * bari.Y + vertices[2].cameraVector.Y * bari.Z,
            vertices[0].cameraVector.Z * bari.X + vertices[1].cameraVector.Z * bari.Y + vertices[2].cameraVector.Z * bari.Z);

            int d = (int)V.Length();

            V = Vector3.Normalize(V);

            if (isPointLight)
            {
                Vector3 RR = Vector3.Normalize(2 * NL * N - L);
                float cos2 = Vector3.Dot(V, RR);
                cos2 = cos2 < 0 ? 0 : (float)Math.Pow(cos2, m);

                R += (int)(k_d * NL * light.R + k_s * cos2 * light.R) * obj.R / 255;
                G += (int)(k_d * NL * light.G + k_s * cos2 * light.G) * obj.G / 255;
                B += (int)(k_d * NL * light.B + k_s * cos2 * light.B) * obj.B / 255;
            }

            if (isDirLight)
            {
                Vector3 RR = 2 * Vector3.Dot(N, dirVector) * N - dirVector;
                float NLdir = Math.Max(Vector3.Dot(N, dirVector), 0);
                float cos2 = Vector3.Dot(V, RR);
                cos2 = cos2 < 0 ? 0 : (float)Math.Pow(cos2, m);

                R += (int)((k_d * NLdir + k_s * cos2) * dirLight.R) * obj.R / 255;
                G += (int)((k_d * NLdir + k_s * cos2) * dirLight.G) * obj.G / 255;
                B += (int)((k_d * NLdir + k_s * cos2) * dirLight.B) * obj.B / 255;
            }
            if (isSpotLight)
            {
                Vector3 L2 = Vector3.Normalize(new Vector3(Properties.spotLightPosition.X - XX, Properties.spotLightPosition.Y - YY, Properties.spotLightPosition.Z - ZZ));
                Vector3 D = Properties.spotLightTarget;
                float NL2 = Math.Max(Vector3.Dot(N, L2), 0);
                Vector3 RR = Vector3.Normalize(2 * NL2 * N - L2);
                float cos2 = Vector3.Dot(V, RR);
                cos2 = cos2 < 0 ? 0 : (float)Math.Pow(cos2, m);
                float spot = (float)Math.Pow(Math.Max(0, Vector3.Dot(-1 * D, L2)), p);
                R += (int)((k_d * NL2 * spotLight.R + k_s * cos2 * spotLight.R) * obj.R * (spot / 255 / 255));
                G += (int)((k_d * NL2 * spotLight.G + k_s * cos2 * spotLight.G) * obj.G * (spot / 255 / 255));
                B += (int)((k_d * NL2 * spotLight.B + k_s * cos2 * spotLight.B) * obj.B * (spot / 255 / 255));
            }
           
            R = R < 0 ? 0 : R > 255 ? 255 : R;
            G = G < 0 ? 0 : G > 255 ? 255 : G;
            B = B < 0 ? 0 : B > 255 ? 255 : B;

            return isFog ? Fog(d, Color.FromArgb(R, G, B)) : Color.FromArgb(R, G, B);
        }
        public static void initialGourand(Polygon polygon, Color obj)
        {
            var normals = polygon.vertices.Select(p => p.viewNormal).ToArray();
            Vector3[] id = new Vector3[] { new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1) };

            for (int l = 0; l < polygon.gourandColors.Length; l++)
            {
                polygon.gourandColors[l] = Properties.CalculateColor2(polygon.vertices, id[l], obj);
            }
        }
        public static Color CalculateGourand(Vector3 bari, Color[] colors)
        {
            var R = colors[0].R * bari.X + colors[1].R * bari.Y + colors[2].R * bari.Z;
            var G = colors[0].G * bari.X + colors[1].G * bari.Y + colors[2].G * bari.Z;
            var B = colors[0].B * bari.X + colors[1].B * bari.Y + colors[2].B * bari.Z;

            R = R < 0 ? 0 : R > 255 ? 255 : R;
            G = G < 0 ? 0 : G > 255 ? 255 : G;
            B = B < 0 ? 0 : B > 255 ? 255 : B;

            return Color.FromArgb((int)R, (int)G, (int)B);
        }
        public static Color CalculateConst(List<Vertex> vertices, Vector3 bari, Color obj)
        {
            Color [] colors = new Color[3];
            Vector3 [] id = new Vector3[] { new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1) };

            for (int l = 0; l < 3; l++)
            {
                colors[l] = Properties.CalculateColor2(vertices, id[l], obj);
            }

            var R = (colors[0].R + colors[1].R + colors[2].R) / 3;
            var G = (colors[0].G + colors[1].G + colors[2].G) / 3;
            var B = (colors[0].B + colors[1].B + colors[2].B) / 3;

            R = R < 0 ? 0 : R > 255 ? 255 : R;
            G = G < 0 ? 0 : G > 255 ? 255 : G;
            B = B < 0 ? 0 : B > 255 ? 255 : B;
            return Color.FromArgb(R, G, B);
        }
        public static Color Fog(int d, Color color)
        {
            if (d > startFog)
            {
                if (d > endFog)
                    return water;
                else
                {
                    float increase = (float)(d - startFog) / (float)(endFog - startFog);
                    float increaseR = increase * (water.R - color.R);
                    float increaseG = increase * (water.G - color.G);
                    float increaseB = increase * (water.B - color.B);

                    return Color.FromArgb(color.R + (int)increaseR, color.G + (int)increaseG, color.B + (int)increaseB);
                }
            }
            return color;
        }
    }
    public class ZBuffer
    {
        public float[,] Zbuffer { get; set; }
        public ZBuffer(float[,] Zbuffer)
        {
            this.Zbuffer = Zbuffer;
        }
        public void clear()
        {
            for (int i = 0; i < Zbuffer.GetLength(0); i++)
            {
                for (int j = 0; j < Zbuffer.GetLength(1); j++)
                {
                    Zbuffer[i, j] = int.MaxValue;
                }
            }
        }
    }
}
