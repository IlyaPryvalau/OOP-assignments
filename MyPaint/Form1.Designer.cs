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
            this.GroupBox = new System.Windows.Forms.GroupBox();
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
            this.StatusStrip.SuspendLayout();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineThicknessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineColorPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGColorPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(12, 24);
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
            this.CurrentShape.Name = "CurrentShape";
            this.CurrentShape.Size = new System.Drawing.Size(87, 17);
            this.CurrentShape.Text = "Current shape: ";
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox.Controls.Add(this.DashedLinesCheckBox);
            this.GroupBox.Controls.Add(this.LineThicknessUpDown);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.LineColorPBox);
            this.GroupBox.Controls.Add(this.BGColorPBox);
            this.GroupBox.Controls.Add(this.comboBox1);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.TriangleBtn);
            this.GroupBox.Controls.Add(this.SquareBtn);
            this.GroupBox.Controls.Add(this.RectangleBtn);
            this.GroupBox.Controls.Add(this.OvalBtn);
            this.GroupBox.Controls.Add(this.CircleBtn);
            this.GroupBox.Controls.Add(this.LineBtn);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.clrBtn);
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(122, 600);
            this.GroupBox.TabIndex = 6;
            this.GroupBox.TabStop = false;
            // 
            // DashedLinesCheckBox
            // 
            this.DashedLinesCheckBox.AutoSize = true;
            this.DashedLinesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DashedLinesCheckBox.Location = new System.Drawing.Point(16, 416);
            this.DashedLinesCheckBox.Name = "DashedLinesCheckBox";
            this.DashedLinesCheckBox.Size = new System.Drawing.Size(106, 20);
            this.DashedLinesCheckBox.TabIndex = 8;
            this.DashedLinesCheckBox.Text = "Dashed lines";
            this.DashedLinesCheckBox.UseVisualStyleBackColor = true;
            this.DashedLinesCheckBox.CheckedChanged += new System.EventHandler(this.DashedLinesCheckBox_CheckedChanged);
            // 
            // LineThicknessUpDown
            // 
            this.LineThicknessUpDown.Location = new System.Drawing.Point(12, 471);
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
            this.label3.Location = new System.Drawing.Point(13, 452);
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
            this.LineColorPBox.Location = new System.Drawing.Point(12, 349);
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
            this.BGColorPBox.Location = new System.Drawing.Point(49, 360);
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
            this.comboBox1.Location = new System.Drawing.Point(6, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Additional\r\nshapes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.Image = global::MyPaint.Properties.Resources.Triangle;
            this.TriangleBtn.Location = new System.Drawing.Point(69, 219);
            this.TriangleBtn.Name = "TriangleBtn";
            this.TriangleBtn.Size = new System.Drawing.Size(37, 37);
            this.TriangleBtn.TabIndex = 12;
            this.toolTip1.SetToolTip(this.TriangleBtn, "draw triangle");
            this.TriangleBtn.UseVisualStyleBackColor = true;
            this.TriangleBtn.Click += new System.EventHandler(this.TriangleBtn_Click);
            // 
            // SquareBtn
            // 
            this.SquareBtn.Image = global::MyPaint.Properties.Resources.Square;
            this.SquareBtn.Location = new System.Drawing.Point(12, 219);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(37, 37);
            this.SquareBtn.TabIndex = 11;
            this.toolTip1.SetToolTip(this.SquareBtn, "draw square");
            this.SquareBtn.UseVisualStyleBackColor = true;
            this.SquareBtn.Click += new System.EventHandler(this.SquareBtn_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.Image = global::MyPaint.Properties.Resources.Rectangle;
            this.RectangleBtn.Location = new System.Drawing.Point(69, 163);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(37, 37);
            this.RectangleBtn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.RectangleBtn, "draw rectangle");
            this.RectangleBtn.UseVisualStyleBackColor = true;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // OvalBtn
            // 
            this.OvalBtn.Image = global::MyPaint.Properties.Resources.Oval;
            this.OvalBtn.Location = new System.Drawing.Point(12, 163);
            this.OvalBtn.Name = "OvalBtn";
            this.OvalBtn.Size = new System.Drawing.Size(37, 37);
            this.OvalBtn.TabIndex = 9;
            this.toolTip1.SetToolTip(this.OvalBtn, "draw oval");
            this.OvalBtn.UseVisualStyleBackColor = true;
            this.OvalBtn.Click += new System.EventHandler(this.OvalBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.Image = global::MyPaint.Properties.Resources.Circle;
            this.CircleBtn.Location = new System.Drawing.Point(69, 108);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(37, 37);
            this.CircleBtn.TabIndex = 8;
            this.toolTip1.SetToolTip(this.CircleBtn, "draw circle");
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // LineBtn
            // 
            this.LineBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.LineBtn.Image = global::MyPaint.Properties.Resources.Line2;
            this.LineBtn.Location = new System.Drawing.Point(12, 108);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(37, 37);
            this.LineBtn.TabIndex = 7;
            this.toolTip1.SetToolTip(this.LineBtn, "draw line");
            this.LineBtn.UseVisualStyleBackColor = true;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 72);
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
            this.ShapeListBox.Location = new System.Drawing.Point(1134, 0);
            this.ShapeListBox.Name = "ShapeListBox";
            this.ShapeListBox.Size = new System.Drawing.Size(107, 598);
            this.ShapeListBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 623);
            this.Controls.Add(this.ShapeListBox);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.StatusStrip);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPaint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineThicknessUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineColorPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGColorPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.ColorDialog BorderColorDialog;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CurrentShape;
        private System.Windows.Forms.GroupBox GroupBox;
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
    }
}

