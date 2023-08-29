using _3DScene.objects;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;

namespace _3DScene
{
    public partial class Scene : Form
    {
        public DirectBitmap dirBitmap;
        public Properties props;
        public Fish fish;
        public Sand sand;
        public Pear pear;
        public int tick = 0;
        public Matrix4x4 camera;
        public List<Model> models;
        public Scene()
        {
            InitializeComponent();
            dirBitmap = new DirectBitmap(pictureBox.Width, pictureBox.Height);
            props = new Properties(dirBitmap);

            models = new List<Model>();
            fish = new Fish();
            sand = new Sand();
            pear = new Pear();
            
            models.Add(sand);
            models.Add(fish);
            models.Add(pear);

            Properties.viewMatrix = Matrix4x4.CreateLookAt(props.cameraPosition, new Vector3(0, 0, 0), props.cameraUpVector);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(dirBitmap.Bitmap);
            g.Clear(Color.FromArgb(158, 207, 228));
            Properties.zbuffer.clear();
            var cam = Camera.GetCameraPosition(this);
            foreach (Model model in models)
            {
                Matrix4x4 matrices = model.modelMatrix * Properties.viewMatrix * Properties.perspectiveFieldOfView;
                foreach (Polygon polygon in model.polygons)
                {
                    foreach (var vertex in polygon.vertices)
                    {
                        vertex.cameraVector = 
                            new Vector3(cam.X - vertex.worldPosition.X, cam.Y - vertex.worldPosition.Y, cam.Z - vertex.worldPosition.Z);
                        vertex.viewNormal = Vector3.TransformNormal(vertex.modelNormal, model.rotationMatrix);
                        vertex.worldPosition = Vector4.Transform(vertex.modelPosition, model.modelMatrix);
                        var v = Vector4.Transform(vertex.modelPosition, matrices);
                        v = v / v.W;
                        vertex.viewPosition =
                            new Vector4((v.X + 1) * pictureBox.Width / 2, (v.Y + 1) * pictureBox.Height / 2, (v.Z) * (props.farPlaneDistance - props.nearPlaneDistance) + props.nearPlaneDistance, 1);
                    }
                }
            }
            //tu foreach model
           
            //Parallel.ForEach(sand.polygons, polygon => polygon.FillPolygon(g, dirBitmap, Color.BlueViolet));
            foreach (Polygon polygon in sand.polygons)
            {
               polygon.FillPolygon(g, dirBitmap, sand.color);

            }
            Parallel.ForEach(fish.polygons, polygon => polygon.FillPolygon(g, dirBitmap, fish.color));
            Parallel.ForEach(pear.polygons, polygon => polygon.FillPolygon(g, dirBitmap, pear.color));
            e.Graphics.DrawImage(dirBitmap.Bitmap, 0, 0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Properties.spotLightPosition = Camera.GetSpotLightPosition(this);
            Properties.spotLightTarget = Camera.GetSpotLightTarget(this);
            Properties.viewMatrix = Camera.GetMatrix(this);
            fish.rotationMatrix = Matrix4x4.CreateRotationY((float)tick * (float)Math.PI / 196);
            fish.modelMatrix = fish.scaleMatrix
            * Matrix4x4.CreateTranslation(new Vector3(400, 300, 0))
            * fish.rotationMatrix;

            tick++;
            pictureBox.Invalidate();
        }

        private void radioButton_constShading_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_constShading.Checked)
            {
                Properties.shading = 0;
                pictureBox.Invalidate();
            }
        }

        private void radioButton_GourandShading_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_GourandShading.Checked)
            {
                Properties.shading = 1;
                pictureBox.Invalidate();
            }
        }

        private void radioButton_PhongShading_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_PhongShading.Checked)
            {
                Properties.shading = 2;
                pictureBox.Invalidate();
            }
        }

        private void radioButton_CenterMode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_CenterMode.Checked)
            {
                Properties.cameraType = Properties.CameraType.CenterMode;
                
                pictureBox.Invalidate();
            }
        }

        private void radioButton_StationaryMode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_StationaryMode.Checked)
            {
                Properties.cameraType = Properties.CameraType.StationaryMode;
                pictureBox.Invalidate();
            }
        }

        private void radioButton_MovingMode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_MovingMode.Checked)
            {
                Properties.cameraType = Properties.CameraType.MovingMode;
                pictureBox.Invalidate();
            }
        }

        private void checkBox_Fog_CheckedChanged(object sender, EventArgs e)
        {
            Properties.isFog = checkBox_Fog.Checked;
        }

        private void checkBox_dirLight_CheckedChanged(object sender, EventArgs e)
        {
            Properties.isDirLight = checkBox_dirLight.Checked;
        }

        private void checkBox_pointLight_CheckedChanged(object sender, EventArgs e)
        {
            Properties.isPointLight = checkBox_pointLight.Checked;
        }

        private void checkBox_spotLight_CheckedChanged(object sender, EventArgs e)
        {
            Properties.isSpotLight = checkBox_spotLight.Checked;
        }
    }
}