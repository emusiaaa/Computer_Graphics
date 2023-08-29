namespace Triangles
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonInterpolation2 = new System.Windows.Forms.RadioButton();
            this.radioButtonInterpolation1 = new System.Windows.Forms.RadioButton();
            this.checkBoxDrawPolygons = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.labelz = new System.Windows.Forms.Label();
            this.trackBarM = new System.Windows.Forms.TrackBar();
            this.labelm = new System.Windows.Forms.Label();
            this.trackBarKs = new System.Windows.Forms.TrackBar();
            this.labelks = new System.Windows.Forms.Label();
            this.trackBarKd = new System.Windows.Forms.TrackBar();
            this.labelkd = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_Color = new System.Windows.Forms.Label();
            this.button_selectColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.4669F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.53311F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1278, 944);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(958, 938);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(967, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 392F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(308, 938);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonInterpolation2);
            this.groupBox1.Controls.Add(this.radioButtonInterpolation1);
            this.groupBox1.Controls.Add(this.checkBoxDrawPolygons);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonInterpolation2
            // 
            this.radioButtonInterpolation2.AutoSize = true;
            this.radioButtonInterpolation2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonInterpolation2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonInterpolation2.Location = new System.Drawing.Point(3, 77);
            this.radioButtonInterpolation2.Name = "radioButtonInterpolation2";
            this.radioButtonInterpolation2.Size = new System.Drawing.Size(296, 25);
            this.radioButtonInterpolation2.TabIndex = 2;
            this.radioButtonInterpolation2.Text = "kolor wyznaczany dokładnie w pkt";
            this.radioButtonInterpolation2.UseVisualStyleBackColor = true;
            this.radioButtonInterpolation2.CheckedChanged += new System.EventHandler(this.radioButtonInterpolation2_CheckedChanged);
            // 
            // radioButtonInterpolation1
            // 
            this.radioButtonInterpolation1.AutoSize = true;
            this.radioButtonInterpolation1.Checked = true;
            this.radioButtonInterpolation1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonInterpolation1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonInterpolation1.Location = new System.Drawing.Point(3, 52);
            this.radioButtonInterpolation1.Name = "radioButtonInterpolation1";
            this.radioButtonInterpolation1.Size = new System.Drawing.Size(296, 25);
            this.radioButtonInterpolation1.TabIndex = 1;
            this.radioButtonInterpolation1.TabStop = true;
            this.radioButtonInterpolation1.Text = "kolor wyznaczany w wierzchołkach";
            this.radioButtonInterpolation1.UseVisualStyleBackColor = true;
            this.radioButtonInterpolation1.CheckedChanged += new System.EventHandler(this.radioButtonInterpolation1_CheckedChanged);
            // 
            // checkBoxDrawPolygons
            // 
            this.checkBoxDrawPolygons.AutoSize = true;
            this.checkBoxDrawPolygons.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxDrawPolygons.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDrawPolygons.Location = new System.Drawing.Point(3, 27);
            this.checkBoxDrawPolygons.Name = "checkBoxDrawPolygons";
            this.checkBoxDrawPolygons.Size = new System.Drawing.Size(296, 25);
            this.checkBoxDrawPolygons.TabIndex = 0;
            this.checkBoxDrawPolygons.Text = "Draw edges";
            this.checkBoxDrawPolygons.UseVisualStyleBackColor = true;
            this.checkBoxDrawPolygons.CheckedChanged += new System.EventHandler(this.checkBoxDrawPolygons_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBarZ);
            this.groupBox2.Controls.Add(this.labelz);
            this.groupBox2.Controls.Add(this.trackBarM);
            this.groupBox2.Controls.Add(this.labelm);
            this.groupBox2.Controls.Add(this.trackBarKs);
            this.groupBox2.Controls.Add(this.labelks);
            this.groupBox2.Controls.Add(this.trackBarKd);
            this.groupBox2.Controls.Add(this.labelkd);
            this.groupBox2.Location = new System.Drawing.Point(3, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 386);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sliders";
            // 
            // trackBarZ
            // 
            this.trackBarZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarZ.Location = new System.Drawing.Point(3, 334);
            this.trackBarZ.Maximum = 1000;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(294, 69);
            this.trackBarZ.TabIndex = 7;
            this.trackBarZ.Value = 1000;
            this.trackBarZ.ValueChanged += new System.EventHandler(this.trackBarZ_ValueChanged);
            // 
            // labelz
            // 
            this.labelz.AutoSize = true;
            this.labelz.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelz.Location = new System.Drawing.Point(3, 309);
            this.labelz.Name = "labelz";
            this.labelz.Size = new System.Drawing.Size(82, 25);
            this.labelz.TabIndex = 6;
            this.labelz.Text = "z = 1000";
            // 
            // trackBarM
            // 
            this.trackBarM.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarM.Location = new System.Drawing.Point(3, 240);
            this.trackBarM.Maximum = 100;
            this.trackBarM.Minimum = 1;
            this.trackBarM.Name = "trackBarM";
            this.trackBarM.Size = new System.Drawing.Size(294, 69);
            this.trackBarM.TabIndex = 5;
            this.trackBarM.Value = 40;
            this.trackBarM.ValueChanged += new System.EventHandler(this.trackBarM_ValueChanged);
            // 
            // labelm
            // 
            this.labelm.AutoSize = true;
            this.labelm.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelm.Location = new System.Drawing.Point(3, 215);
            this.labelm.Name = "labelm";
            this.labelm.Size = new System.Drawing.Size(70, 25);
            this.labelm.TabIndex = 4;
            this.labelm.Text = "m = 40";
            // 
            // trackBarKs
            // 
            this.trackBarKs.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarKs.Location = new System.Drawing.Point(3, 146);
            this.trackBarKs.Maximum = 100;
            this.trackBarKs.Name = "trackBarKs";
            this.trackBarKs.Size = new System.Drawing.Size(294, 69);
            this.trackBarKs.TabIndex = 3;
            this.trackBarKs.Value = 50;
            this.trackBarKs.ValueChanged += new System.EventHandler(this.trackBarKs_ValueChanged);
            // 
            // labelks
            // 
            this.labelks.AutoSize = true;
            this.labelks.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelks.Location = new System.Drawing.Point(3, 121);
            this.labelks.Name = "labelks";
            this.labelks.Size = new System.Drawing.Size(82, 25);
            this.labelks.TabIndex = 2;
            this.labelks.Text = "k_s = 0.5";
            // 
            // trackBarKd
            // 
            this.trackBarKd.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBarKd.Location = new System.Drawing.Point(3, 52);
            this.trackBarKd.Maximum = 100;
            this.trackBarKd.Name = "trackBarKd";
            this.trackBarKd.Size = new System.Drawing.Size(294, 69);
            this.trackBarKd.TabIndex = 1;
            this.trackBarKd.Value = 50;
            this.trackBarKd.ValueChanged += new System.EventHandler(this.trackBarKd_ValueChanged);
            // 
            // labelkd
            // 
            this.labelkd.AutoSize = true;
            this.labelkd.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelkd.Location = new System.Drawing.Point(3, 27);
            this.labelkd.Name = "labelkd";
            this.labelkd.Size = new System.Drawing.Size(85, 25);
            this.labelkd.TabIndex = 0;
            this.labelkd.Text = "k_d = 0.5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_Color);
            this.groupBox3.Controls.Add(this.button_selectColor);
            this.groupBox3.Location = new System.Drawing.Point(3, 516);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 83);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Light color";
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Color.Location = new System.Drawing.Point(124, 29);
            this.label_Color.MaximumSize = new System.Drawing.Size(112, 34);
            this.label_Color.MinimumSize = new System.Drawing.Size(112, 34);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(112, 34);
            this.label_Color.TabIndex = 1;
            // 
            // button_selectColor
            // 
            this.button_selectColor.Location = new System.Drawing.Point(6, 30);
            this.button_selectColor.Name = "button_selectColor";
            this.button_selectColor.Size = new System.Drawing.Size(112, 34);
            this.button_selectColor.TabIndex = 0;
            this.button_selectColor.Text = "Select color";
            this.button_selectColor.UseVisualStyleBackColor = true;
            this.button_selectColor.Click += new System.EventHandler(this.button_selectColor_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Stop animation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 703);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 187);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Loading bitmaps";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(296, 157);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(290, 47);
            this.button4.TabIndex = 2;
            this.button4.Text = "Revert normal map";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "Change texture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(290, 46);
            this.button3.TabIndex = 1;
            this.button3.Text = "Change normal map";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 893);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 944);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sphere";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private CheckBox checkBoxDrawPolygons;
        private GroupBox groupBox2;
        private TrackBar trackBarKd;
        private Label labelkd;
        private TrackBar trackBarKs;
        private Label labelks;
        private TrackBar trackBarM;
        private Label labelm;
        private Label label1;
        private GroupBox groupBox3;
        private ColorDialog colorDialog1;
        private Label label_Color;
        private Button button_selectColor;
        private TrackBar trackBarZ;
        private Label labelz;
        private RadioButton radioButtonInterpolation2;
        private RadioButton radioButtonInterpolation1;
        private Button button1;
        private System.Windows.Forms.Timer timer;
        private GroupBox groupBox4;
        private Button button2;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel3;
    }
}