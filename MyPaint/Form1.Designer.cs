namespace MyPaint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clrBtn = new System.Windows.Forms.Button();
            this.BorderColorDialog = new System.Windows.Forms.ColorDialog();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CurrentShape = new System.Windows.Forms.ToolStripStatusLabel();
            this.DashedLinesCheckBox = new System.Windows.Forms.CheckBox();
            this.LineThicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.LineColorPBox = new System.Windows.Forms.PictureBox();
            this.BGColorPBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TriangleBtn = new System.Windows.Forms.Button();
            this.SquareBtn = new System.Windows.Forms.Button();
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.OvalBtn = new System.Windows.Forms.Button();
            this.CircleBtn = new System.Windows.Forms.Button();
            this.LineBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LineColorDialog = new System.Windows.Forms.ColorDialog();
            this.BGColorDialog = new System.Windows.Forms.ColorDialog();
            this.ShapeListBox = new System.Windows.Forms.ListBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.shapeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineThicknessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineColorPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGColorPBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.DrawingPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(12, 18);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(94, 32);
            this.clrBtn.TabIndex = 3;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentShape});
            this.StatusStrip.Location = new System.Drawing.Point(0, 601);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1241, 22);
            this.StatusStrip.TabIndex = 5;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // CurrentShape
            // 
            this.CurrentShape.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentShape.Name = "CurrentShape";
            this.CurrentShape.Size = new System.Drawing.Size(87, 17);
            this.CurrentShape.Text = "Current shape: ";
            // 
            // DashedLinesCheckBox
            // 
            this.DashedLinesCheckBox.AutoSize = true;
            this.DashedLinesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DashedLinesCheckBox.Location = new System.Drawing.Point(7, 438);
            this.DashedLinesCheckBox.Name = "DashedLinesCheckBox";
            this.DashedLinesCheckBox.Size = new System.Drawing.Size(106, 20);
            this.DashedLinesCheckBox.TabIndex = 8;
            this.DashedLinesCheckBox.Text = "Dashed lines";
            this.DashedLinesCheckBox.UseVisualStyleBackColor = true;
            this.DashedLinesCheckBox.CheckedChanged += new System.EventHandler(this.DashedLinesCheckBox_CheckedChanged);
            // 
            // LineThicknessUpDown
            // 
            this.LineThicknessUpDown.Location = new System.Drawing.Point(8, 502);
            this.LineThicknessUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.LineThicknessUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineThicknessUpDown.Name = "LineThicknessUpDown";
            this.LineThicknessUpDown.Size = new System.Drawing.Size(98, 20);
            this.LineThicknessUpDown.TabIndex = 7;
            this.LineThicknessUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Line thickness:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LineColorPBox
            // 
            this.LineColorPBox.BackColor = System.Drawing.Color.Black;
            this.LineColorPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LineColorPBox.Location = new System.Drawing.Point(3, 377);
            this.LineColorPBox.Name = "LineColorPBox";
            this.LineColorPBox.Size = new System.Drawing.Size(54, 27);
            this.LineColorPBox.TabIndex = 14;
            this.LineColorPBox.TabStop = false;
            this.toolTip1.SetToolTip(this.LineColorPBox, "Foreground color");
            this.LineColorPBox.Click += new System.EventHandler(this.LineColorPBox_Click);
            // 
            // BGColorPBox
            // 
            this.BGColorPBox.BackColor = System.Drawing.Color.White;
            this.BGColorPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BGColorPBox.Location = new System.Drawing.Point(49, 396);
            this.BGColorPBox.Name = "BGColorPBox";
            this.BGColorPBox.Size = new System.Drawing.Size(57, 27);
            this.BGColorPBox.TabIndex = 7;
            this.BGColorPBox.TabStop = false;
            this.toolTip1.SetToolTip(this.BGColorPBox, "Background color");
            this.BGColorPBox.Click += new System.EventHandler(this.BGColorPBox_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 328);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Additional\r\nshapes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.Image = global::MyPaint.Properties.Resources.Triangle;
            this.TriangleBtn.Location = new System.Drawing.Point(65, 218);
            this.TriangleBtn.Name = "TriangleBtn";
            this.TriangleBtn.Size = new System.Drawing.Size(37, 37);
            this.TriangleBtn.TabIndex = 12;
            this.toolTip1.SetToolTip(this.TriangleBtn, "Triangle");
            this.TriangleBtn.UseVisualStyleBackColor = true;
            this.TriangleBtn.Click += new System.EventHandler(this.TriangleBtn_Click);
            // 
            // SquareBtn
            // 
            this.SquareBtn.Image = global::MyPaint.Properties.Resources.Square;
            this.SquareBtn.Location = new System.Drawing.Point(10, 218);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(37, 37);
            this.SquareBtn.TabIndex = 11;
            this.toolTip1.SetToolTip(this.SquareBtn, "Square");
            this.SquareBtn.UseVisualStyleBackColor = true;
            this.SquareBtn.Click += new System.EventHandler(this.SquareBtn_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.Image = global::MyPaint.Properties.Resources.Rectangle;
            this.RectangleBtn.Location = new System.Drawing.Point(65, 161);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(37, 37);
            this.RectangleBtn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.RectangleBtn, "Rectangle");
            this.RectangleBtn.UseVisualStyleBackColor = true;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // OvalBtn
            // 
            this.OvalBtn.Image = global::MyPaint.Properties.Resources.Oval;
            this.OvalBtn.Location = new System.Drawing.Point(10, 161);
            this.OvalBtn.Name = "OvalBtn";
            this.OvalBtn.Size = new System.Drawing.Size(37, 37);
            this.OvalBtn.TabIndex = 9;
            this.toolTip1.SetToolTip(this.OvalBtn, "Oval");
            this.OvalBtn.UseVisualStyleBackColor = true;
            this.OvalBtn.Click += new System.EventHandler(this.OvalBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.Image = global::MyPaint.Properties.Resources.Circle;
            this.CircleBtn.Location = new System.Drawing.Point(65, 102);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(37, 37);
            this.CircleBtn.TabIndex = 8;
            this.toolTip1.SetToolTip(this.CircleBtn, "Circle");
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // LineBtn
            // 
            this.LineBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.LineBtn.Image = global::MyPaint.Properties.Resources.Line2;
            this.LineBtn.Location = new System.Drawing.Point(10, 102);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(37, 37);
            this.LineBtn.TabIndex = 7;
            this.toolTip1.SetToolTip(this.LineBtn, "Line");
            this.LineBtn.UseVisualStyleBackColor = true;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Basic shapes:";
            // 
            // ShapeListBox
            // 
            this.ShapeListBox.BackColor = System.Drawing.SystemColors.Control;
            this.ShapeListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShapeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShapeListBox.FormattingEnabled = true;
            this.ShapeListBox.ItemHeight = 18;
            this.ShapeListBox.Location = new System.Drawing.Point(7, 3);
            this.ShapeListBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ShapeListBox.Name = "ShapeListBox";
            this.ShapeListBox.Size = new System.Drawing.Size(115, 472);
            this.ShapeListBox.TabIndex = 7;
            this.ShapeListBox.SelectedIndexChanged += new System.EventHandler(this.ShapeListBox_SelectedIndexChanged);
            // 
            // changeBtn
            // 
            this.changeBtn.Enabled = false;
            this.changeBtn.Location = new System.Drawing.Point(7, 485);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(115, 29);
            this.changeBtn.TabIndex = 16;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(7, 520);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(115, 27);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ShapeListBox);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.changeBtn);
            this.panel1.Location = new System.Drawing.Point(1114, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 552);
            this.panel1.TabIndex = 18;
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingPanel.Controls.Add(this.clrBtn);
            this.DrawingPanel.Controls.Add(this.LineThicknessUpDown);
            this.DrawingPanel.Controls.Add(this.LineBtn);
            this.DrawingPanel.Controls.Add(this.label1);
            this.DrawingPanel.Controls.Add(this.label3);
            this.DrawingPanel.Controls.Add(this.DashedLinesCheckBox);
            this.DrawingPanel.Controls.Add(this.CircleBtn);
            this.DrawingPanel.Controls.Add(this.OvalBtn);
            this.DrawingPanel.Controls.Add(this.RectangleBtn);
            this.DrawingPanel.Controls.Add(this.SquareBtn);
            this.DrawingPanel.Controls.Add(this.BGColorPBox);
            this.DrawingPanel.Controls.Add(this.TriangleBtn);
            this.DrawingPanel.Controls.Add(this.LineColorPBox);
            this.DrawingPanel.Controls.Add(this.label2);
            this.DrawingPanel.Controls.Add(this.comboBox1);
            this.DrawingPanel.Location = new System.Drawing.Point(0, 38);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(121, 552);
            this.DrawingPanel.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // shapeListBindingSource
            // 
            this.shapeListBindingSource.DataSource = typeof(MyPaint.ShapeList);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 623);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPaint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineThicknessUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineColorPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGColorPBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.DrawingPanel.ResumeLayout(false);
            this.DrawingPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.ColorDialog BorderColorDialog;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CurrentShape;
        private System.Windows.Forms.Button TriangleBtn;
        private System.Windows.Forms.Button SquareBtn;
        private System.Windows.Forms.Button RectangleBtn;
        private System.Windows.Forms.Button OvalBtn;
        private System.Windows.Forms.Button CircleBtn;
        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LineColorPBox;
        private System.Windows.Forms.PictureBox BGColorPBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown LineThicknessUpDown;
        private System.Windows.Forms.ColorDialog LineColorDialog;
        private System.Windows.Forms.ColorDialog BGColorDialog;
        private System.Windows.Forms.ListBox ShapeListBox;
        private System.Windows.Forms.CheckBox DashedLinesCheckBox;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.BindingSource shapeListBindingSource;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

