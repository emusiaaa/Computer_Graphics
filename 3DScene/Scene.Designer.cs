namespace _3DScene
{
    partial class Scene
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
            this.radioButton_PhongShading = new System.Windows.Forms.RadioButton();
            this.radioButton_GourandShading = new System.Windows.Forms.RadioButton();
            this.radioButton_constShading = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_MovingMode = new System.Windows.Forms.RadioButton();
            this.radioButton_StationaryMode = new System.Windows.Forms.RadioButton();
            this.radioButton_CenterMode = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_Fog = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_dirLight = new System.Windows.Forms.CheckBox();
            this.checkBox_pointLight = new System.Windows.Forms.CheckBox();
            this.checkBox_spotLight = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.66277F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.33723F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1367, 816);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1124, 810);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1133, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(231, 810);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_PhongShading);
            this.groupBox1.Controls.Add(this.radioButton_GourandShading);
            this.groupBox1.Controls.Add(this.radioButton_constShading);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cieniowanie";
            // 
            // radioButton_PhongShading
            // 
            this.radioButton_PhongShading.AutoSize = true;
            this.radioButton_PhongShading.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton_PhongShading.Location = new System.Drawing.Point(3, 85);
            this.radioButton_PhongShading.Name = "radioButton_PhongShading";
            this.radioButton_PhongShading.Size = new System.Drawing.Size(219, 29);
            this.radioButton_PhongShading.TabIndex = 2;
            this.radioButton_PhongShading.TabStop = true;
            this.radioButton_PhongShading.Text = "Phong";
            this.radioButton_PhongShading.UseVisualStyleBackColor = true;
            this.radioButton_PhongShading.CheckedChanged += new System.EventHandler(this.radioButton_PhongShading_CheckedChanged);
            // 
            // radioButton_GourandShading
            // 
            this.radioButton_GourandShading.AutoSize = true;
            this.radioButton_GourandShading.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton_GourandShading.Location = new System.Drawing.Point(3, 56);
            this.radioButton_GourandShading.Name = "radioButton_GourandShading";
            this.radioButton_GourandShading.Size = new System.Drawing.Size(219, 29);
            this.radioButton_GourandShading.TabIndex = 1;
            this.radioButton_GourandShading.TabStop = true;
            this.radioButton_GourandShading.Text = "Gouraud";
            this.radioButton_GourandShading.UseVisualStyleBackColor = true;
            this.radioButton_GourandShading.CheckedChanged += new System.EventHandler(this.radioButton_GourandShading_CheckedChanged);
            // 
            // radioButton_constShading
            // 
            this.radioButton_constShading.AutoSize = true;
            this.radioButton_constShading.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton_constShading.Location = new System.Drawing.Point(3, 27);
            this.radioButton_constShading.Name = "radioButton_constShading";
            this.radioButton_constShading.Size = new System.Drawing.Size(219, 29);
            this.radioButton_constShading.TabIndex = 0;
            this.radioButton_constShading.TabStop = true;
            this.radioButton_constShading.Text = "stałe";
            this.radioButton_constShading.UseVisualStyleBackColor = true;
            this.radioButton_constShading.CheckedChanged += new System.EventHandler(this.radioButton_constShading_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_MovingMode);
            this.groupBox2.Controls.Add(this.radioButton_StationaryMode);
            this.groupBox2.Controls.Add(this.radioButton_CenterMode);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera";
            // 
            // radioButton_MovingMode
            // 
            this.radioButton_MovingMode.AutoSize = true;
            this.radioButton_MovingMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton_MovingMode.Location = new System.Drawing.Point(3, 85);
            this.radioButton_MovingMode.Name = "radioButton_MovingMode";
            this.radioButton_MovingMode.Size = new System.Drawing.Size(219, 29);
            this.radioButton_MovingMode.TabIndex = 2;
            this.radioButton_MovingMode.Text = "Moving";
            this.radioButton_MovingMode.UseVisualStyleBackColor = true;
            this.radioButton_MovingMode.CheckedChanged += new System.EventHandler(this.radioButton_MovingMode_CheckedChanged);
            // 
            // radioButton_StationaryMode
            // 
            this.radioButton_StationaryMode.AutoSize = true;
            this.radioButton_StationaryMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton_StationaryMode.Location = new System.Drawing.Point(3, 56);
            this.radioButton_StationaryMode.Name = "radioButton_StationaryMode";
            this.radioButton_StationaryMode.Size = new System.Drawing.Size(219, 29);
            this.radioButton_StationaryMode.TabIndex = 1;
            this.radioButton_StationaryMode.Text = "Stationary";
            this.radioButton_StationaryMode.UseVisualStyleBackColor = true;
            this.radioButton_StationaryMode.CheckedChanged += new System.EventHandler(this.radioButton_StationaryMode_CheckedChanged);
            // 
            // radioButton_CenterMode
            // 
            this.radioButton_CenterMode.AutoSize = true;
            this.radioButton_CenterMode.Checked = true;
            this.radioButton_CenterMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton_CenterMode.Location = new System.Drawing.Point(3, 27);
            this.radioButton_CenterMode.Name = "radioButton_CenterMode";
            this.radioButton_CenterMode.Size = new System.Drawing.Size(219, 29);
            this.radioButton_CenterMode.TabIndex = 0;
            this.radioButton_CenterMode.TabStop = true;
            this.radioButton_CenterMode.Text = "On center";
            this.radioButton_CenterMode.UseVisualStyleBackColor = true;
            this.radioButton_CenterMode.CheckedChanged += new System.EventHandler(this.radioButton_CenterMode_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_Fog);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 626);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fog";
            // 
            // checkBox_Fog
            // 
            this.checkBox_Fog.AutoSize = true;
            this.checkBox_Fog.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_Fog.Location = new System.Drawing.Point(3, 27);
            this.checkBox_Fog.Name = "checkBox_Fog";
            this.checkBox_Fog.Size = new System.Drawing.Size(219, 29);
            this.checkBox_Fog.TabIndex = 0;
            this.checkBox_Fog.Text = "Mgła";
            this.checkBox_Fog.UseVisualStyleBackColor = true;
            this.checkBox_Fog.CheckedChanged += new System.EventHandler(this.checkBox_Fog_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_spotLight);
            this.groupBox4.Controls.Add(this.checkBox_pointLight);
            this.groupBox4.Controls.Add(this.checkBox_dirLight);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 181);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Light";
            // 
            // checkBox_dirLight
            // 
            this.checkBox_dirLight.AutoSize = true;
            this.checkBox_dirLight.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_dirLight.Location = new System.Drawing.Point(3, 27);
            this.checkBox_dirLight.Name = "checkBox_dirLight";
            this.checkBox_dirLight.Size = new System.Drawing.Size(219, 29);
            this.checkBox_dirLight.TabIndex = 0;
            this.checkBox_dirLight.Text = "Directional";
            this.checkBox_dirLight.UseVisualStyleBackColor = true;
            this.checkBox_dirLight.CheckedChanged += new System.EventHandler(this.checkBox_dirLight_CheckedChanged);
            // 
            // checkBox_pointLight
            // 
            this.checkBox_pointLight.AutoSize = true;
            this.checkBox_pointLight.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_pointLight.Location = new System.Drawing.Point(3, 56);
            this.checkBox_pointLight.Name = "checkBox_pointLight";
            this.checkBox_pointLight.Size = new System.Drawing.Size(219, 29);
            this.checkBox_pointLight.TabIndex = 1;
            this.checkBox_pointLight.Text = "Point light";
            this.checkBox_pointLight.UseVisualStyleBackColor = true;
            this.checkBox_pointLight.CheckedChanged += new System.EventHandler(this.checkBox_pointLight_CheckedChanged);
            // 
            // checkBox_spotLight
            // 
            this.checkBox_spotLight.AutoSize = true;
            this.checkBox_spotLight.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_spotLight.Location = new System.Drawing.Point(3, 85);
            this.checkBox_spotLight.Name = "checkBox_spotLight";
            this.checkBox_spotLight.Size = new System.Drawing.Size(219, 29);
            this.checkBox_spotLight.TabIndex = 2;
            this.checkBox_spotLight.Text = "Spot light";
            this.checkBox_spotLight.UseVisualStyleBackColor = true;
            this.checkBox_spotLight.CheckedChanged += new System.EventHandler(this.checkBox_spotLight_CheckedChanged);
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 816);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Scene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scene";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private RadioButton radioButton_PhongShading;
        private RadioButton radioButton_GourandShading;
        private RadioButton radioButton_constShading;
        private GroupBox groupBox2;
        private RadioButton radioButton_MovingMode;
        private RadioButton radioButton_StationaryMode;
        private RadioButton radioButton_CenterMode;
        private GroupBox groupBox3;
        private CheckBox checkBox_Fog;
        private GroupBox groupBox4;
        private CheckBox checkBox_spotLight;
        private CheckBox checkBox_pointLight;
        private CheckBox checkBox_dirLight;
    }
}