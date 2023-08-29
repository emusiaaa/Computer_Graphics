using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Triangles
{

    public partial class Form1 : Form
    {
        public Bitmap bitmap;
        public List<Polygon> polygons;
        //private Color color;
        private int MAXRADIUS = 1000;
        private int RADIUS = 0;
        private int MINRADIUS = 0;
        private bool isRadiusIncreasing = true;
        private bool isAnimation = true;
        public static Bitmap? texture = null;
        public static Bitmap? map = null;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bitmap;
            label_Color.BackColor = Calculations.light;
            polygons = new List<Polygon>();

           const string path = "../../../sphere3mXXLSmooth.obj";
           //const string path = "../../../proj2_sfera.obj";

            Parser.Parse(path, polygons, bitmap);

            pictureBox.Invalidate();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Location: " + e.Location;
        }


        private void checkBoxDrawPolygons_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            foreach (var p in polygons)
            {
                p.FillPolygon(g);
            }

            
            if (checkBoxDrawPolygons.Checked)
            {
                foreach (var polygon in polygons)
                {
                    polygon.Draw(g);
                }
            }
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void trackBarKd_ValueChanged(object sender, EventArgs e)
        {
            Calculations.k_d = (float)trackBarKd.Value / 100;
            labelkd.Text = "k_d = " + String.Format("{0:N2}", Calculations.k_d);
            pictureBox.Invalidate();
        }

        private void trackBarKs_ValueChanged(object sender, EventArgs e)
        {
            Calculations.k_s = (float)trackBarKs.Value / 100;
            labelks.Text = "k_s = " + String.Format("{0:N2}", Calculations.k_s);
            pictureBox.Invalidate();
        }

        private void trackBarM_ValueChanged(object sender, EventArgs e)
        {
            Calculations.m = trackBarM.Value;
            labelm.Text = "m = " + Calculations.m.ToString();
            pictureBox.Invalidate();
        }

        private void button_selectColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label_Color.BackColor = colorDialog1.Color;
            Calculations.light = colorDialog1.Color;
            pictureBox.Invalidate();
        }

        private void trackBarZ_ValueChanged(object sender, EventArgs e)
        {
            Calculations.lightPosition.Z = trackBarZ.Value;
            labelz.Text = "z = " + Calculations.lightPosition.Z.ToString();
            pictureBox.Invalidate();
        }

        private void radioButtonInterpolation1_CheckedChanged(object sender, EventArgs e)
        {
            Calculations.interpolationFlagColor = radioButtonInterpolation1.Checked;
            pictureBox.Invalidate();
        }

        private void radioButtonInterpolation2_CheckedChanged(object sender, EventArgs e)
        {
            Calculations.interpolationFlagColor = !radioButtonInterpolation2.Checked;
            pictureBox.Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isAnimation)
            {
                Calculations.lightPosition.X = (float)(RADIUS * Math.Cos((float)DateTime.Now.TimeOfDay.TotalMilliseconds / 1000)) + Calculations.ligthCenter.X;
                Calculations.lightPosition.Y = (float)(RADIUS * Math.Sin((float)DateTime.Now.TimeOfDay.TotalMilliseconds / 1000)) + Calculations.ligthCenter.Y;
                //RADIUS = 1000;
                if (RADIUS == MINRADIUS) isRadiusIncreasing = true;
                else if(RADIUS == MAXRADIUS) isRadiusIncreasing = false;

                RADIUS += isRadiusIncreasing ? 20 : -20;

                pictureBox.Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isAnimation)
            {
                isAnimation = false;
                button1.Text = "Start animation";
            }
            else
            {
                isAnimation = true;
                button1.Text = "Stop animation";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Image selector";
                dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    texture = new Bitmap(dialog.FileName);
                    texture = new Bitmap(texture, new Size(pictureBox.Width, pictureBox.Height));
                    pictureBox.Invalidate();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Image selector";
                dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    map = new Bitmap(dialog.FileName);
                    map = new Bitmap(map, new Size(pictureBox.Width, pictureBox.Height));
                    pictureBox.Invalidate();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            map = null;
            pictureBox.Invalidate();
        }
    }
}