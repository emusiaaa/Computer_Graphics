using System.Drawing;

namespace ColorReducer
{
    public partial class MainWindow : Form
    {
        public DirectBitmap originalBitmap;
        public DirectBitmap reducedBitmap;
        public MainWindow()
        {
            InitializeComponent();

            originalBitmap = new DirectBitmap(originalPictureBox.Width, originalPictureBox.Height);
            reducedBitmap = new DirectBitmap(reducedPictureBox.Width, reducedPictureBox.Height);
        }
        private void changeImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (errorDithering.Checked) errorDithering.Checked = false;
                if (popularityAlg.Checked) popularityAlg.Checked = false;
                if (kmeansAlg.Checked) kmeansAlg.Checked = false;

                ManageApplyButton();
                ManageControls();

                originalBitmap = new DirectBitmap(Image.FromFile(fileDialog.FileName), originalPictureBox.Width, originalPictureBox.Height);
                reducedBitmap = new DirectBitmap(reducedPictureBox.Width, reducedPictureBox.Height);
                InvalidateAll();

                reducedLabel.Text = "COLOR REDUCED";
                errorDithering.Enabled = true;
                popularityAlg.Enabled = true;
                kmeansAlg.Enabled = true;
            }
        }
        private void originalPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(originalBitmap.Bitmap);
            e.Graphics.DrawImage(originalBitmap.Bitmap, 0, 0);
        }
        private void reducedPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (errorDithering.Checked)
            {
                if (FloydSteinberg.Checked) reducedBitmap = ErrorDitheringAlgorithm.ErrorDithering(ErrorDitheringAlgorithm.FloydSteinberg, originalBitmap, errorDitheringTrackBar.Value);
                if (Burkes.Checked) reducedBitmap = ErrorDitheringAlgorithm.ErrorDithering(ErrorDitheringAlgorithm.Burkes, originalBitmap, errorDitheringTrackBar.Value);
                if (Stucky.Checked) reducedBitmap = ErrorDitheringAlgorithm.ErrorDithering(ErrorDitheringAlgorithm.Stucky, originalBitmap, errorDitheringTrackBar.Value);
                reducedLabel.Text = "ERROR DITHERING";
            }
            if (popularityAlg.Checked)
            {
                reducedBitmap = PopularityAlgorithm.popularityAlgorithm(originalBitmap, popularityTrackBar.Value); //inne k
                reducedLabel.Text = "POPULARITY ALGORITHM";
            }
            if (kmeansAlg.Checked)
            {
                KMeans kmc = new(originalBitmap, reducedBitmap, kMeansTrackBar.Value);
                kmc.Init();
                kmc.Converge();
                kmc.Apply();
                reducedLabel.Text = kMeansTrackBar.Value.ToString() + " - MEANS";
            }
            Graphics g = Graphics.FromImage(reducedBitmap.Bitmap);
            e.Graphics.DrawImage(reducedBitmap.Bitmap, 0, 0);
        }
        private void InvalidateAll()
        {
            originalPictureBox.Invalidate();
            reducedPictureBox.Invalidate();
        }
        private void ManageApplyButton()
        {
            applyButton.Enabled = errorDithering.Checked || popularityAlg.Checked || kmeansAlg.Checked;
            applyButton.BackColor = applyButton.Enabled ? Color.FromArgb(128,255,128) : Color.FromArgb(255, 192, 192);
        }
        private void enableApplyButton()
        {
            applyButton.Enabled = true;
            applyButton.BackColor = Color.FromArgb(128, 255, 128);
        }
       
        private void ManageControls()
        {
            if (errorDithering.Checked)
            {
                errorDitheringGroupBox.Enabled = true;
                popularityGroupBox.Enabled = false;
                kMeansGroupBox.Enabled = false;
                return;
            }
            if (popularityAlg.Checked)
            {
                errorDitheringGroupBox.Enabled = false;
                popularityGroupBox.Enabled = true;
                kMeansGroupBox.Enabled = false;
                return;
            }
            if (kmeansAlg.Checked)
            {
                errorDitheringGroupBox.Enabled = false;
                popularityGroupBox.Enabled = false;
                kMeansGroupBox.Enabled = true;
                return;
            }
            errorDitheringGroupBox.Enabled = false;
            popularityGroupBox.Enabled = false;
            kMeansGroupBox.Enabled = false;

        }
        private void errorDithering_CheckedChanged(object sender, EventArgs e)
        {
            ManageApplyButton();
            ManageControls();
        }

        private void popularityAlg_CheckedChanged(object sender, EventArgs e)
        {
            ManageApplyButton();
            ManageControls();
        }

        private void kmeansAlg_CheckedChanged(object sender, EventArgs e)
        {
            ManageApplyButton();
            ManageControls();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            applyButton.Enabled = false;
            applyButton.BackColor = Color.FromArgb(255, 192, 192);
            reducedLabel.Text = "WAIT ....";
            reducedPictureBox.Invalidate();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            kPopularityLabel.Text = "k = " + popularityTrackBar.Value.ToString();
            enableApplyButton();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            kMeansLabel.Text = "k = " + kMeansTrackBar.Value.ToString();
            enableApplyButton();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            errorDitheringLabel.Text = "f = " + errorDitheringTrackBar.Value.ToString();
            enableApplyButton();
        }

        private void FloydSteinberg_CheckedChanged(object sender, EventArgs e)
        {
            enableApplyButton();
        }

        private void Burkes_CheckedChanged(object sender, EventArgs e)
        {
            enableApplyButton();
        }

        private void Stucky_CheckedChanged(object sender, EventArgs e)
        {
            enableApplyButton();
        }
    }
}