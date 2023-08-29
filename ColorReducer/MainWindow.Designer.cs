namespace ColorReducer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reducedLabel = new System.Windows.Forms.Label();
            this.reducedPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.errorDitheringGroupBox = new System.Windows.Forms.GroupBox();
            this.errorDitheringLabel = new System.Windows.Forms.Label();
            this.errorDitheringTrackBar = new System.Windows.Forms.TrackBar();
            this.Burkes = new System.Windows.Forms.RadioButton();
            this.Stucky = new System.Windows.Forms.RadioButton();
            this.FloydSteinberg = new System.Windows.Forms.RadioButton();
            this.popularityGroupBox = new System.Windows.Forms.GroupBox();
            this.kPopularityLabel = new System.Windows.Forms.Label();
            this.popularityTrackBar = new System.Windows.Forms.TrackBar();
            this.kMeansGroupBox = new System.Windows.Forms.GroupBox();
            this.kMeansLabel = new System.Windows.Forms.Label();
            this.kMeansTrackBar = new System.Windows.Forms.TrackBar();
            this.applyButton = new System.Windows.Forms.Button();
            this.kmeansAlg = new System.Windows.Forms.RadioButton();
            this.popularityAlg = new System.Windows.Forms.RadioButton();
            this.errorDithering = new System.Windows.Forms.RadioButton();
            this.changeImageButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reducedPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.errorDitheringGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDitheringTrackBar)).BeginInit();
            this.popularityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularityTrackBar)).BeginInit();
            this.kMeansGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kMeansTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1683, 882);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.originalPictureBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 876);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORIGINAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BackColor = System.Drawing.Color.White;
            this.originalPictureBox.Location = new System.Drawing.Point(51, 92);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(570, 760);
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            this.originalPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.originalPictureBox_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reducedLabel);
            this.groupBox2.Controls.Add(this.reducedPictureBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(692, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 876);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // reducedLabel
            // 
            this.reducedLabel.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reducedLabel.Location = new System.Drawing.Point(0, 27);
            this.reducedLabel.Name = "reducedLabel";
            this.reducedLabel.Size = new System.Drawing.Size(683, 54);
            this.reducedLabel.TabIndex = 2;
            this.reducedLabel.Text = "COLOR REDUCED";
            this.reducedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reducedPictureBox
            // 
            this.reducedPictureBox.BackColor = System.Drawing.Color.White;
            this.reducedPictureBox.Location = new System.Drawing.Point(60, 92);
            this.reducedPictureBox.Name = "reducedPictureBox";
            this.reducedPictureBox.Size = new System.Drawing.Size(570, 760);
            this.reducedPictureBox.TabIndex = 1;
            this.reducedPictureBox.TabStop = false;
            this.reducedPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.reducedPictureBox_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Controls.Add(this.applyButton);
            this.groupBox3.Controls.Add(this.kmeansAlg);
            this.groupBox3.Controls.Add(this.popularityAlg);
            this.groupBox3.Controls.Add(this.errorDithering);
            this.groupBox3.Controls.Add(this.changeImageButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(1381, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 876);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(238)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.errorDitheringGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.popularityGroupBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.kMeansGroupBox, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(33, 377);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.84931F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.15068F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(242, 475);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // errorDitheringGroupBox
            // 
            this.errorDitheringGroupBox.Controls.Add(this.errorDitheringLabel);
            this.errorDitheringGroupBox.Controls.Add(this.errorDitheringTrackBar);
            this.errorDitheringGroupBox.Controls.Add(this.Burkes);
            this.errorDitheringGroupBox.Controls.Add(this.Stucky);
            this.errorDitheringGroupBox.Controls.Add(this.FloydSteinberg);
            this.errorDitheringGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorDitheringGroupBox.Enabled = false;
            this.errorDitheringGroupBox.Location = new System.Drawing.Point(3, 3);
            this.errorDitheringGroupBox.Name = "errorDitheringGroupBox";
            this.errorDitheringGroupBox.Size = new System.Drawing.Size(236, 238);
            this.errorDitheringGroupBox.TabIndex = 7;
            this.errorDitheringGroupBox.TabStop = false;
            this.errorDitheringGroupBox.Text = "Error dithering";
            // 
            // errorDitheringLabel
            // 
            this.errorDitheringLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorDitheringLabel.Location = new System.Drawing.Point(6, 177);
            this.errorDitheringLabel.Name = "errorDitheringLabel";
            this.errorDitheringLabel.Size = new System.Drawing.Size(224, 27);
            this.errorDitheringLabel.TabIndex = 9;
            this.errorDitheringLabel.Text = "f = 4";
            // 
            // errorDitheringTrackBar
            // 
            this.errorDitheringTrackBar.Location = new System.Drawing.Point(3, 135);
            this.errorDitheringTrackBar.Minimum = 1;
            this.errorDitheringTrackBar.Name = "errorDitheringTrackBar";
            this.errorDitheringTrackBar.Size = new System.Drawing.Size(230, 69);
            this.errorDitheringTrackBar.TabIndex = 8;
            this.errorDitheringTrackBar.Value = 4;
            this.errorDitheringTrackBar.ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);
            // 
            // Burkes
            // 
            this.Burkes.AutoSize = true;
            this.Burkes.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Burkes.Location = new System.Drawing.Point(12, 65);
            this.Burkes.Name = "Burkes";
            this.Burkes.Size = new System.Drawing.Size(89, 29);
            this.Burkes.TabIndex = 7;
            this.Burkes.Text = "Burkes";
            this.Burkes.UseVisualStyleBackColor = true;
            this.Burkes.CheckedChanged += new System.EventHandler(this.Burkes_CheckedChanged);
            // 
            // Stucky
            // 
            this.Stucky.AutoSize = true;
            this.Stucky.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stucky.Location = new System.Drawing.Point(12, 100);
            this.Stucky.Name = "Stucky";
            this.Stucky.Size = new System.Drawing.Size(89, 29);
            this.Stucky.TabIndex = 6;
            this.Stucky.Text = "Stucky";
            this.Stucky.UseVisualStyleBackColor = true;
            this.Stucky.CheckedChanged += new System.EventHandler(this.Stucky_CheckedChanged);
            // 
            // FloydSteinberg
            // 
            this.FloydSteinberg.AutoSize = true;
            this.FloydSteinberg.Checked = true;
            this.FloydSteinberg.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FloydSteinberg.Location = new System.Drawing.Point(12, 30);
            this.FloydSteinberg.Name = "FloydSteinberg";
            this.FloydSteinberg.Size = new System.Drawing.Size(164, 29);
            this.FloydSteinberg.TabIndex = 5;
            this.FloydSteinberg.TabStop = true;
            this.FloydSteinberg.Text = "Floyd-Steinberg";
            this.FloydSteinberg.UseVisualStyleBackColor = true;
            this.FloydSteinberg.CheckedChanged += new System.EventHandler(this.FloydSteinberg_CheckedChanged);
            // 
            // popularityGroupBox
            // 
            this.popularityGroupBox.Controls.Add(this.kPopularityLabel);
            this.popularityGroupBox.Controls.Add(this.popularityTrackBar);
            this.popularityGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popularityGroupBox.Enabled = false;
            this.popularityGroupBox.Location = new System.Drawing.Point(3, 247);
            this.popularityGroupBox.Name = "popularityGroupBox";
            this.popularityGroupBox.Size = new System.Drawing.Size(236, 115);
            this.popularityGroupBox.TabIndex = 8;
            this.popularityGroupBox.TabStop = false;
            this.popularityGroupBox.Text = "Popularity algorithm";
            // 
            // kPopularityLabel
            // 
            this.kPopularityLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kPopularityLabel.Location = new System.Drawing.Point(6, 69);
            this.kPopularityLabel.Name = "kPopularityLabel";
            this.kPopularityLabel.Size = new System.Drawing.Size(224, 27);
            this.kPopularityLabel.TabIndex = 2;
            this.kPopularityLabel.Text = "k = 12";
            // 
            // popularityTrackBar
            // 
            this.popularityTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.popularityTrackBar.Location = new System.Drawing.Point(3, 27);
            this.popularityTrackBar.Maximum = 64;
            this.popularityTrackBar.Minimum = 1;
            this.popularityTrackBar.Name = "popularityTrackBar";
            this.popularityTrackBar.Size = new System.Drawing.Size(230, 69);
            this.popularityTrackBar.TabIndex = 1;
            this.popularityTrackBar.Value = 12;
            this.popularityTrackBar.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // kMeansGroupBox
            // 
            this.kMeansGroupBox.Controls.Add(this.kMeansLabel);
            this.kMeansGroupBox.Controls.Add(this.kMeansTrackBar);
            this.kMeansGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kMeansGroupBox.Enabled = false;
            this.kMeansGroupBox.Location = new System.Drawing.Point(3, 368);
            this.kMeansGroupBox.Name = "kMeansGroupBox";
            this.kMeansGroupBox.Size = new System.Drawing.Size(236, 104);
            this.kMeansGroupBox.TabIndex = 9;
            this.kMeansGroupBox.TabStop = false;
            this.kMeansGroupBox.Text = "k-means algorithm";
            // 
            // kMeansLabel
            // 
            this.kMeansLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kMeansLabel.Location = new System.Drawing.Point(6, 69);
            this.kMeansLabel.Name = "kMeansLabel";
            this.kMeansLabel.Size = new System.Drawing.Size(224, 27);
            this.kMeansLabel.TabIndex = 3;
            this.kMeansLabel.Text = "k = 12";
            // 
            // kMeansTrackBar
            // 
            this.kMeansTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.kMeansTrackBar.Location = new System.Drawing.Point(3, 27);
            this.kMeansTrackBar.Maximum = 64;
            this.kMeansTrackBar.Minimum = 1;
            this.kMeansTrackBar.Name = "kMeansTrackBar";
            this.kMeansTrackBar.Size = new System.Drawing.Size(230, 69);
            this.kMeansTrackBar.TabIndex = 0;
            this.kMeansTrackBar.Value = 12;
            this.kMeansTrackBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.applyButton.Enabled = false;
            this.applyButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applyButton.Location = new System.Drawing.Point(63, 296);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(169, 55);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "APPLY";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // kmeansAlg
            // 
            this.kmeansAlg.AutoSize = true;
            this.kmeansAlg.Enabled = false;
            this.kmeansAlg.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kmeansAlg.Location = new System.Drawing.Point(57, 243);
            this.kmeansAlg.Name = "kmeansAlg";
            this.kmeansAlg.Size = new System.Drawing.Size(187, 29);
            this.kmeansAlg.TabIndex = 4;
            this.kmeansAlg.Text = "k-means algorithm";
            this.kmeansAlg.UseVisualStyleBackColor = true;
            this.kmeansAlg.CheckedChanged += new System.EventHandler(this.kmeansAlg_CheckedChanged);
            // 
            // popularityAlg
            // 
            this.popularityAlg.AutoSize = true;
            this.popularityAlg.Enabled = false;
            this.popularityAlg.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.popularityAlg.Location = new System.Drawing.Point(57, 208);
            this.popularityAlg.Name = "popularityAlg";
            this.popularityAlg.Size = new System.Drawing.Size(199, 29);
            this.popularityAlg.TabIndex = 3;
            this.popularityAlg.Text = "Popularity algorithm";
            this.popularityAlg.UseVisualStyleBackColor = true;
            this.popularityAlg.CheckedChanged += new System.EventHandler(this.popularityAlg_CheckedChanged);
            // 
            // errorDithering
            // 
            this.errorDithering.AutoSize = true;
            this.errorDithering.Enabled = false;
            this.errorDithering.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorDithering.Location = new System.Drawing.Point(57, 173);
            this.errorDithering.Name = "errorDithering";
            this.errorDithering.Size = new System.Drawing.Size(151, 29);
            this.errorDithering.TabIndex = 2;
            this.errorDithering.Text = "Error dithering";
            this.errorDithering.UseVisualStyleBackColor = true;
            this.errorDithering.CheckedChanged += new System.EventHandler(this.errorDithering_CheckedChanged);
            // 
            // changeImageButton
            // 
            this.changeImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(238)))));
            this.changeImageButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeImageButton.Location = new System.Drawing.Point(67, 34);
            this.changeImageButton.Name = "changeImageButton";
            this.changeImageButton.Size = new System.Drawing.Size(169, 55);
            this.changeImageButton.TabIndex = 1;
            this.changeImageButton.Text = "Upload image";
            this.changeImageButton.UseVisualStyleBackColor = false;
            this.changeImageButton.Click += new System.EventHandler(this.changeImageButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "ALGORITHMS";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1683, 882);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Reducer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reducedPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.errorDitheringGroupBox.ResumeLayout(false);
            this.errorDitheringGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDitheringTrackBar)).EndInit();
            this.popularityGroupBox.ResumeLayout(false);
            this.popularityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularityTrackBar)).EndInit();
            this.kMeansGroupBox.ResumeLayout(false);
            this.kMeansGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kMeansTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label label1;
        private PictureBox originalPictureBox;
        private GroupBox groupBox2;
        private Label reducedLabel;
        private PictureBox reducedPictureBox;
        private GroupBox groupBox3;
        private Label label3;
        private Button changeImageButton;
        private Button applyButton;
        private RadioButton kmeansAlg;
        private RadioButton popularityAlg;
        private RadioButton errorDithering;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox errorDitheringGroupBox;
        private RadioButton Burkes;
        private RadioButton Stucky;
        private RadioButton FloydSteinberg;
        private GroupBox popularityGroupBox;
        private Label kPopularityLabel;
        private TrackBar popularityTrackBar;
        private GroupBox kMeansGroupBox;
        private Label kMeansLabel;
        private TrackBar kMeansTrackBar;
        private Label errorDitheringLabel;
        private TrackBar errorDitheringTrackBar;
    }
}