using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3DScene.objects
{
    public class Parser
    {
        public static void Parse(string path, List<Polygon> polygons)
        {
            ////https://stackoverflow.com/questions/8037070/whats-the-fastest-way-to-read-a-text-file-line-by-line
            const Int32 BufferSize = 128;

            List<Vector3> vertices = new List<Vector3>();
            List<Vector3> normals = new List<Vector3>();

            using FileStream stream = File.OpenRead(path);
            using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8, true, BufferSize);

            String? row;

            string[] separator = { " ", "/" };

            while ((row = streamReader.ReadLine()) != null)
            {
                string[] splitted = row.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (splitted.Length == 0) continue;
                if (splitted[0] == "v")
                {
                    vertices.Add(new Vector3(
                            float.Parse(splitted[1], CultureInfo.InvariantCulture),
                            float.Parse(splitted[2], CultureInfo.InvariantCulture),
                            float.Parse(splitted[3], CultureInfo.InvariantCulture)));
                }
                else if (splitted[0] == "vn")
                {
                    normals.Add(new Vector3(
                               float.Parse(splitted[1], CultureInfo.InvariantCulture),
                               float.Parse(splitted[2], CultureInfo.InvariantCulture),
                               float.Parse(splitted[3], CultureInfo.InvariantCulture)));
                }
                else if (splitted[0] == "f")
                {
                    List<Vertex> vert = new List<Vertex>();
                    vert.Add(new Vertex(vertices[int.Parse(splitted[1]) - 1], normals[int.Parse(splitted[2]) - 1]));
                    vert.Add(new Vertex(vertices[int.Parse(splitted[3]) - 1], normals[int.Parse(splitted[4]) - 1]));
                    vert.Add(new Vertex(vertices[int.Parse(splitted[5]) - 1], normals[int.Parse(splitted[6]) - 1]));
                    polygons.Add(new Polygon(vert));
                }
            }
        }
    }
}
