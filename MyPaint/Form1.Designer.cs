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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DrawAllBtn = new System.Windows.Forms.Button();
            this.DrawSpace = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(24, 682);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // DrawAllBtn
            // 
            this.DrawAllBtn.Location = new System.Drawing.Point(27, 12);
            this.DrawAllBtn.Name = "DrawAllBtn";
            this.DrawAllBtn.Size = new System.Drawing.Size(133, 70);
            this.DrawAllBtn.TabIndex = 1;
            this.DrawAllBtn.Text = "Print all shapes";
            this.DrawAllBtn.UseVisualStyleBackColor = true;
            this.DrawAllBtn.Click += new System.EventHandler(this.DrawAllBtn_Click);
            // 
            // DrawSpace
            // 
            this.DrawSpace.AccessibleName = "";
            this.DrawSpace.Location = new System.Drawing.Point(166, 0);
            this.DrawSpace.Name = "DrawSpace";
            this.DrawSpace.Size = new System.Drawing.Size(1098, 682);
            this.DrawSpace.TabIndex = 2;
            this.DrawSpace.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.DrawSpace);
            this.Controls.Add(this.DrawAllBtn);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "MyPaint";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button DrawAllBtn;
        private System.Windows.Forms.PictureBox DrawSpace;
    }
}

