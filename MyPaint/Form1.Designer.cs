namespace MyPaint
{
    partial class Form1
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
            this.DrawSpace = new System.Windows.Forms.PictureBox();
            this.clrBtn = new System.Windows.Forms.Button();
            this.BorderColorDialog = new System.Windows.Forms.ColorDialog();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CurrentShape = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BGClolorPBox = new System.Windows.Forms.PictureBox();
            this.LineClolorPBox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.DrawSpace)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGClolorPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineClolorPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawSpace
            // 
            this.DrawSpace.AccessibleName = "";
            this.DrawSpace.BackColor = System.Drawing.Color.White;
            this.DrawSpace.Location = new System.Drawing.Point(128, 0);
            this.DrawSpace.Name = "DrawSpace";
            this.DrawSpace.Size = new System.Drawing.Size(1030, 657);
            this.DrawSpace.TabIndex = 2;
            this.DrawSpace.TabStop = false;
            this.DrawSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawSpace_MouseDown);
            this.DrawSpace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawSpace_MouseMove);
            this.DrawSpace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawSpace_MouseUp);
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
            this.StatusStrip.Location = new System.Drawing.Point(0, 660);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1264, 22);
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
            this.GroupBox.Controls.Add(this.numericUpDown1);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.BGClolorPBox);
            this.GroupBox.Controls.Add(this.LineClolorPBox);
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
            this.GroupBox.Size = new System.Drawing.Size(122, 657);
            this.GroupBox.TabIndex = 6;
            this.GroupBox.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 422);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Line thickness:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BGClolorPBox
            // 
            this.BGClolorPBox.BackColor = System.Drawing.Color.White;
            this.BGClolorPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BGClolorPBox.Location = new System.Drawing.Point(62, 360);
            this.BGClolorPBox.Name = "BGClolorPBox";
            this.BGClolorPBox.Size = new System.Drawing.Size(54, 27);
            this.BGClolorPBox.TabIndex = 14;
            this.BGClolorPBox.TabStop = false;
            // 
            // LineClolorPBox
            // 
            this.LineClolorPBox.BackColor = System.Drawing.Color.Black;
            this.LineClolorPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LineClolorPBox.Location = new System.Drawing.Point(6, 360);
            this.LineClolorPBox.Name = "LineClolorPBox";
            this.LineClolorPBox.Size = new System.Drawing.Size(57, 27);
            this.LineClolorPBox.TabIndex = 7;
            this.LineClolorPBox.TabStop = false;
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
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // LineBtn
            // 
            this.LineBtn.Image = global::MyPaint.Properties.Resources.Line2;
            this.LineBtn.Location = new System.Drawing.Point(12, 108);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(37, 37);
            this.LineBtn.TabIndex = 7;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.DrawSpace);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPaint";
            ((System.ComponentModel.ISupportInitialize)(this.DrawSpace)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGClolorPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineClolorPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox DrawSpace;
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
        private System.Windows.Forms.PictureBox BGClolorPBox;
        private System.Windows.Forms.PictureBox LineClolorPBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

