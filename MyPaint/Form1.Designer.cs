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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.clrBtn = new System.Windows.Forms.Button();
            this.BorderColorDialog = new System.Windows.Forms.ColorDialog();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CurrentShape = new System.Windows.Forms.ToolStripStatusLabel();
            this.LineThicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.PluginsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LineBtn = new System.Windows.Forms.Button();
            this.CircleBtn = new System.Windows.Forms.Button();
            this.OvalBtn = new System.Windows.Forms.Button();
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.SquareBtn = new System.Windows.Forms.Button();
            this.LineColorPBox = new System.Windows.Forms.PictureBox();
            this.TriangleBtn = new System.Windows.Forms.Button();
            this.BGColorPBox = new System.Windows.Forms.PictureBox();
            this.ShapeListBox = new System.Windows.Forms.ListBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LineTypesComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePanelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.hideRight = new System.Windows.Forms.ToolStripMenuItem();
            this.LineColorDialog = new System.Windows.Forms.ColorDialog();
            this.BGColorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.shapeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineThicknessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineColorPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGColorPBox)).BeginInit();
            this.EditPanel.SuspendLayout();
            this.DrawingPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clrBtn
            // 
            resources.ApplyResources(this.clrBtn, "clrBtn");
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentShape});
            resources.ApplyResources(this.StatusStrip, "StatusStrip");
            this.StatusStrip.Name = "StatusStrip";
            // 
            // CurrentShape
            // 
            this.CurrentShape.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentShape.Name = "CurrentShape";
            resources.ApplyResources(this.CurrentShape, "CurrentShape");
            // 
            // LineThicknessUpDown
            // 
            resources.ApplyResources(this.LineThicknessUpDown, "LineThicknessUpDown");
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
            this.LineThicknessUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // PluginsComboBox
            // 
            resources.ApplyResources(this.PluginsComboBox, "PluginsComboBox");
            this.PluginsComboBox.FormattingEnabled = true;
            this.PluginsComboBox.Name = "PluginsComboBox";
            this.PluginsComboBox.SelectedIndexChanged += new System.EventHandler(this.PluginsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // LineBtn
            // 
            this.LineBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.LineBtn.Image = global::MyPaint.Properties.Resources.Line2;
            resources.ApplyResources(this.LineBtn, "LineBtn");
            this.LineBtn.Name = "LineBtn";
            this.toolTip1.SetToolTip(this.LineBtn, resources.GetString("LineBtn.ToolTip"));
            this.LineBtn.UseVisualStyleBackColor = true;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.Image = global::MyPaint.Properties.Resources.Circle;
            resources.ApplyResources(this.CircleBtn, "CircleBtn");
            this.CircleBtn.Name = "CircleBtn";
            this.toolTip1.SetToolTip(this.CircleBtn, resources.GetString("CircleBtn.ToolTip"));
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // OvalBtn
            // 
            this.OvalBtn.Image = global::MyPaint.Properties.Resources.Oval;
            resources.ApplyResources(this.OvalBtn, "OvalBtn");
            this.OvalBtn.Name = "OvalBtn";
            this.toolTip1.SetToolTip(this.OvalBtn, resources.GetString("OvalBtn.ToolTip"));
            this.OvalBtn.UseVisualStyleBackColor = true;
            this.OvalBtn.Click += new System.EventHandler(this.OvalBtn_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.Image = global::MyPaint.Properties.Resources.Rectangle;
            resources.ApplyResources(this.RectangleBtn, "RectangleBtn");
            this.RectangleBtn.Name = "RectangleBtn";
            this.toolTip1.SetToolTip(this.RectangleBtn, resources.GetString("RectangleBtn.ToolTip"));
            this.RectangleBtn.UseVisualStyleBackColor = true;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // SquareBtn
            // 
            this.SquareBtn.Image = global::MyPaint.Properties.Resources.Square;
            resources.ApplyResources(this.SquareBtn, "SquareBtn");
            this.SquareBtn.Name = "SquareBtn";
            this.toolTip1.SetToolTip(this.SquareBtn, resources.GetString("SquareBtn.ToolTip"));
            this.SquareBtn.UseVisualStyleBackColor = true;
            this.SquareBtn.Click += new System.EventHandler(this.SquareBtn_Click);
            // 
            // LineColorPBox
            // 
            this.LineColorPBox.BackColor = System.Drawing.Color.Black;
            this.LineColorPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.LineColorPBox, "LineColorPBox");
            this.LineColorPBox.Name = "LineColorPBox";
            this.LineColorPBox.TabStop = false;
            this.toolTip1.SetToolTip(this.LineColorPBox, resources.GetString("LineColorPBox.ToolTip"));
            this.LineColorPBox.Click += new System.EventHandler(this.LineColorPBox_Click);
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.Image = global::MyPaint.Properties.Resources.Triangle;
            resources.ApplyResources(this.TriangleBtn, "TriangleBtn");
            this.TriangleBtn.Name = "TriangleBtn";
            this.toolTip1.SetToolTip(this.TriangleBtn, resources.GetString("TriangleBtn.ToolTip"));
            this.TriangleBtn.UseVisualStyleBackColor = true;
            this.TriangleBtn.Click += new System.EventHandler(this.TriangleBtn_Click);
            // 
            // BGColorPBox
            // 
            this.BGColorPBox.BackColor = System.Drawing.Color.White;
            this.BGColorPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.BGColorPBox, "BGColorPBox");
            this.BGColorPBox.Name = "BGColorPBox";
            this.BGColorPBox.TabStop = false;
            this.toolTip1.SetToolTip(this.BGColorPBox, resources.GetString("BGColorPBox.ToolTip"));
            this.BGColorPBox.Click += new System.EventHandler(this.BGColorPBox_Click);
            // 
            // ShapeListBox
            // 
            this.ShapeListBox.BackColor = System.Drawing.SystemColors.Control;
            this.ShapeListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ShapeListBox, "ShapeListBox");
            this.ShapeListBox.FormattingEnabled = true;
            this.ShapeListBox.Name = "ShapeListBox";
            this.ShapeListBox.SelectedIndexChanged += new System.EventHandler(this.ShapeListBox_SelectedIndexChanged);
            // 
            // changeBtn
            // 
            resources.ApplyResources(this.changeBtn, "changeBtn");
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // deleteBtn
            // 
            resources.ApplyResources(this.deleteBtn, "deleteBtn");
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.SystemColors.Control;
            this.EditPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditPanel.Controls.Add(this.ShapeListBox);
            this.EditPanel.Controls.Add(this.deleteBtn);
            this.EditPanel.Controls.Add(this.changeBtn);
            resources.ApplyResources(this.EditPanel, "EditPanel");
            this.EditPanel.Name = "EditPanel";
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingPanel.Controls.Add(this.label4);
            this.DrawingPanel.Controls.Add(this.LineTypesComboBox);
            this.DrawingPanel.Controls.Add(this.clrBtn);
            this.DrawingPanel.Controls.Add(this.LineThicknessUpDown);
            this.DrawingPanel.Controls.Add(this.LineBtn);
            this.DrawingPanel.Controls.Add(this.label1);
            this.DrawingPanel.Controls.Add(this.label3);
            this.DrawingPanel.Controls.Add(this.CircleBtn);
            this.DrawingPanel.Controls.Add(this.OvalBtn);
            this.DrawingPanel.Controls.Add(this.RectangleBtn);
            this.DrawingPanel.Controls.Add(this.SquareBtn);
            this.DrawingPanel.Controls.Add(this.LineColorPBox);
            this.DrawingPanel.Controls.Add(this.TriangleBtn);
            this.DrawingPanel.Controls.Add(this.BGColorPBox);
            this.DrawingPanel.Controls.Add(this.label2);
            this.DrawingPanel.Controls.Add(this.PluginsComboBox);
            resources.ApplyResources(this.DrawingPanel, "DrawingPanel");
            this.DrawingPanel.Name = "DrawingPanel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // LineTypesComboBox
            // 
            this.LineTypesComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.LineTypesComboBox, "LineTypesComboBox");
            this.LineTypesComboBox.Name = "LineTypesComboBox";
            this.LineTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.LineTypesComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.setLanguageToolStripMenuItem,
            this.saveChangesToolStripMenuItem});
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // setLanguageToolStripMenuItem
            // 
            this.setLanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishUSToolStripMenuItem,
            this.russianToolStripMenuItem});
            this.setLanguageToolStripMenuItem.Name = "setLanguageToolStripMenuItem";
            resources.ApplyResources(this.setLanguageToolStripMenuItem, "setLanguageToolStripMenuItem");
            // 
            // englishUSToolStripMenuItem
            // 
            this.englishUSToolStripMenuItem.Checked = true;
            this.englishUSToolStripMenuItem.CheckOnClick = true;
            this.englishUSToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishUSToolStripMenuItem.Name = "englishUSToolStripMenuItem";
            resources.ApplyResources(this.englishUSToolStripMenuItem, "englishUSToolStripMenuItem");
            this.englishUSToolStripMenuItem.Click += new System.EventHandler(this.englishUSToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.CheckOnClick = true;
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            resources.ApplyResources(this.russianToolStripMenuItem, "russianToolStripMenuItem");
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.CheckOnClick = true;
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            resources.ApplyResources(this.saveChangesToolStripMenuItem, "saveChangesToolStripMenuItem");
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hidePanelsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // hidePanelsToolStripMenuItem
            // 
            this.hidePanelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideLeft,
            this.hideRight});
            this.hidePanelsToolStripMenuItem.Name = "hidePanelsToolStripMenuItem";
            resources.ApplyResources(this.hidePanelsToolStripMenuItem, "hidePanelsToolStripMenuItem");
            // 
            // hideLeft
            // 
            this.hideLeft.CheckOnClick = true;
            this.hideLeft.Name = "hideLeft";
            resources.ApplyResources(this.hideLeft, "hideLeft");
            this.hideLeft.CheckedChanged += new System.EventHandler(this.hideLeft_CheckedChanged);
            // 
            // hideRight
            // 
            this.hideRight.CheckOnClick = true;
            this.hideRight.Name = "hideRight";
            resources.ApplyResources(this.hideRight, "hideRight");
            this.hideRight.CheckedChanged += new System.EventHandler(this.hideRight_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
            this.EditPanel.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox BGColorPBox;
        private System.Windows.Forms.PictureBox LineColorPBox;
        private System.Windows.Forms.ComboBox PluginsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown LineThicknessUpDown;
        private System.Windows.Forms.ColorDialog LineColorDialog;
        private System.Windows.Forms.ColorDialog BGColorDialog;
        private System.Windows.Forms.ListBox ShapeListBox;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.BindingSource shapeListBindingSource;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hidePanelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideLeft;
        private System.Windows.Forms.ToolStripMenuItem hideRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox LineTypesComboBox;
        private System.Windows.Forms.ToolStripMenuItem setLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
    }
}

