namespace Polygons
{
    partial class Window
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
            this.CANVA = new System.Windows.Forms.PictureBox();
            this.CONTROLS = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_DeleteVertex = new System.Windows.Forms.Button();
            this.button_ClearAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Mode = new System.Windows.Forms.Button();
            this.button_RestrictLength = new System.Windows.Forms.Button();
            this.button_AddRelation = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_Default = new System.Windows.Forms.RadioButton();
            this.radioButton_Algorithm = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CANVA)).BeginInit();
            this.CONTROLS.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CANVA
            // 
            this.CANVA.BackColor = System.Drawing.Color.White;
            this.CANVA.Dock = System.Windows.Forms.DockStyle.Left;
            this.CANVA.Location = new System.Drawing.Point(0, 0);
            this.CANVA.Name = "CANVA";
            this.CANVA.Size = new System.Drawing.Size(1408, 856);
            this.CANVA.TabIndex = 0;
            this.CANVA.TabStop = false;
            this.CANVA.Paint += new System.Windows.Forms.PaintEventHandler(this.CANVA_Paint);
            this.CANVA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CANVA_MouseClick);
            this.CANVA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CANVA_MouseDown);
            this.CANVA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CANVA_MouseMove);
            this.CANVA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CANVA_MouseUp);
            // 
            // CONTROLS
            // 
            this.CONTROLS.Controls.Add(this.tableLayoutPanel1);
            this.CONTROLS.Dock = System.Windows.Forms.DockStyle.Right;
            this.CONTROLS.Location = new System.Drawing.Point(1150, 0);
            this.CONTROLS.Name = "CONTROLS";
            this.CONTROLS.Size = new System.Drawing.Size(258, 856);
            this.CONTROLS.TabIndex = 1;
            this.CONTROLS.TabStop = false;
            this.CONTROLS.Text = "Controls";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.20603F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.79397F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 826);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_DeleteVertex, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_ClearAll, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 660);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(246, 163);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button_DeleteVertex
            // 
            this.button_DeleteVertex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DeleteVertex.Location = new System.Drawing.Point(3, 3);
            this.button_DeleteVertex.Name = "button_DeleteVertex";
            this.button_DeleteVertex.Size = new System.Drawing.Size(240, 75);
            this.button_DeleteVertex.TabIndex = 0;
            this.button_DeleteVertex.Text = "Delete Vertex";
            this.button_DeleteVertex.UseVisualStyleBackColor = true;
            this.button_DeleteVertex.Click += new System.EventHandler(this.button_DeleteVertex_Click);
            // 
            // button_ClearAll
            // 
            this.button_ClearAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ClearAll.Location = new System.Drawing.Point(3, 84);
            this.button_ClearAll.Name = "button_ClearAll";
            this.button_ClearAll.Size = new System.Drawing.Size(240, 76);
            this.button_ClearAll.TabIndex = 1;
            this.button_ClearAll.Text = "Clear All";
            this.button_ClearAll.UseVisualStyleBackColor = true;
            this.button_ClearAll.Click += new System.EventHandler(this.button_ClearAll_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_Mode, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_RestrictLength, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button_AddRelation, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button_Cancel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button_Delete, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 249);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.31387F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.68613F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(246, 345);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relations and Restrictions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Mode
            // 
            this.button_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Mode.Location = new System.Drawing.Point(3, 87);
            this.button_Mode.Name = "button_Mode";
            this.button_Mode.Size = new System.Drawing.Size(240, 47);
            this.button_Mode.TabIndex = 1;
            this.button_Mode.Text = "Enter relations mode";
            this.button_Mode.UseVisualStyleBackColor = true;
            this.button_Mode.Click += new System.EventHandler(this.button_Mode_Click);
            // 
            // button_RestrictLength
            // 
            this.button_RestrictLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_RestrictLength.Enabled = false;
            this.button_RestrictLength.Location = new System.Drawing.Point(3, 140);
            this.button_RestrictLength.Name = "button_RestrictLength";
            this.button_RestrictLength.Size = new System.Drawing.Size(240, 46);
            this.button_RestrictLength.TabIndex = 2;
            this.button_RestrictLength.Text = "Restrict length";
            this.button_RestrictLength.UseVisualStyleBackColor = true;
            this.button_RestrictLength.Click += new System.EventHandler(this.button_RestrictLength_Click);
            // 
            // button_AddRelation
            // 
            this.button_AddRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddRelation.Enabled = false;
            this.button_AddRelation.Location = new System.Drawing.Point(3, 192);
            this.button_AddRelation.Name = "button_AddRelation";
            this.button_AddRelation.Size = new System.Drawing.Size(240, 46);
            this.button_AddRelation.TabIndex = 3;
            this.button_AddRelation.Text = "Add perpendicullar relation";
            this.button_AddRelation.UseVisualStyleBackColor = true;
            this.button_AddRelation.Click += new System.EventHandler(this.button_AddRelation_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Cancel.Enabled = false;
            this.button_Cancel.Location = new System.Drawing.Point(3, 244);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(240, 48);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Delete.Enabled = false;
            this.button_Delete.Location = new System.Drawing.Point(3, 298);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(240, 44);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.radioButton_Default, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.radioButton_Algorithm, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(246, 188);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // radioButton_Default
            // 
            this.radioButton_Default.AutoSize = true;
            this.radioButton_Default.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_Default.Location = new System.Drawing.Point(3, 65);
            this.radioButton_Default.Name = "radioButton_Default";
            this.radioButton_Default.Size = new System.Drawing.Size(240, 56);
            this.radioButton_Default.TabIndex = 0;
            this.radioButton_Default.TabStop = true;
            this.radioButton_Default.Text = "default";
            this.radioButton_Default.UseVisualStyleBackColor = true;
            this.radioButton_Default.CheckedChanged += new System.EventHandler(this.radioButton_Default_CheckedChanged);
            // 
            // radioButton_Algorithm
            // 
            this.radioButton_Algorithm.AutoSize = true;
            this.radioButton_Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_Algorithm.Location = new System.Drawing.Point(3, 127);
            this.radioButton_Algorithm.Name = "radioButton_Algorithm";
            this.radioButton_Algorithm.Size = new System.Drawing.Size(240, 58);
            this.radioButton_Algorithm.TabIndex = 1;
            this.radioButton_Algorithm.TabStop = true;
            this.radioButton_Algorithm.Text = "Bresenham\'s line algorith";
            this.radioButton_Algorithm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drawing lines";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 856);
            this.Controls.Add(this.CONTROLS);
            this.Controls.Add(this.CANVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polygons";
            ((System.ComponentModel.ISupportInitialize)(this.CANVA)).EndInit();
            this.CONTROLS.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private PictureBox CANVA;
        private GroupBox CONTROLS;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button_DeleteVertex;
        private Button button_ClearAll;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Button button_Mode;
        private Button button_RestrictLength;
        private Button button_AddRelation;
        private Button button_Cancel;
        private Button button_Delete;
        private TableLayoutPanel tableLayoutPanel4;
        private RadioButton radioButton_Default;
        private RadioButton radioButton_Algorithm;
        private Label label2;
    }
}