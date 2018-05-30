using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;

namespace MyPaint
{
    public partial class MainForm : Form
    {
        Graphics g;
        ShapeList DrawnShapesList = new ShapeList();
        Point StartPoint, FinishPoint;
        Shape shape;
        private Maker MCircle, MLine, MOval, MRectangle, MSquare, MTriangle, SelectedMaker;
        private System.Drawing.Drawing2D.DashStyle penStyle;
        const string StatusBarMessage = "Drawing: ";
        bool _mousePressed = false;
        const int FPS = 60; //when being drawn, shapes will be redrawn this amount per second
        const int TARGET_TIME = 1000 / FPS;


        private void ReDraw()
        {
            g.Clear(BGColorPBox.BackColor);
            DrawnShapesList.DrawAll(g);
        }
                                                                             
        private void LineBtn_Click(object sender, EventArgs e)
        {
            CurrentShape.Text = StatusBarMessage + "Line";
            SelectedMaker = MLine;
        }
        private void CircleBtn_Click(object sender, EventArgs e)
        {
            CurrentShape.Text = StatusBarMessage + "Circle";
            SelectedMaker = MCircle;
        }
        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            CurrentShape.Text = StatusBarMessage + "Rectangle";
            SelectedMaker = MRectangle;
        }
        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            CurrentShape.Text = StatusBarMessage + "Triangle";
            SelectedMaker = MTriangle;
        }

        private void LineColorPBox_Click(object sender, EventArgs e)
        {
            if (LineColorDialog.ShowDialog() == DialogResult.OK)
            {
                LineColorPBox.BackColor = LineColorDialog.Color;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
            _mousePressed = true;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            FinishPoint = new Point(e.X, e.Y);
            _mousePressed = false;
            if (StartPoint != FinishPoint)
            {
                Invalidate();
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            long start, elapsed, delay;

            if (e.Button == MouseButtons.Left)
            {
                start = DateTime.Now.Ticks;

                FinishPoint.X = e.X;
                FinishPoint.Y = e.Y;
                Invalidate();
                elapsed = DateTime.Now.Ticks - start;

                delay = TARGET_TIME - elapsed / 10000;

                if (delay < 0)
                    delay = 5;
                /*try
                {
                    Thread.Sleep((int)delay);
                }
                catch (Exception c)
                {
                    CurrentShape.Text = c.StackTrace;
                }*/
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            if (_mousePressed)
                (SelectedMaker.Make(LineColorPBox.BackColor, (int)LineThicknessUpDown.Value, penStyle, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y)).draw(g);
            else
                DrawnShapesList.Add(SelectedMaker.Make(LineColorPBox.BackColor, (int)LineThicknessUpDown.Value, penStyle, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y));
            DrawnShapesList.DrawAll(g);
        }

        private void BGColorPBox_Click(object sender, EventArgs e)
        {
            if (BGColorDialog.ShowDialog() == DialogResult.OK)
            {
                BGColorPBox.BackColor = BGColorDialog.Color;
                ReDraw();
            }
        }         

        private void DashedLinesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DashedLinesCheckBox.Checked)
                penStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            else
                penStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
        }

        private void OvalBtn_Click(object sender, EventArgs e)
        {
            CurrentShape.Text = StatusBarMessage + "Line";
            SelectedMaker = MOval;
        }
        private void SquareBtn_Click(object sender, EventArgs e)
        {
            CurrentShape.Text = StatusBarMessage + "Square";
            SelectedMaker = MSquare;
        }      

        private void clrBtn_Click(object sender, EventArgs e)
        {
            DrawnShapesList.Clear();
            ReDraw();
        }

        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            UpdateStyles();
            MCircle = new CircleMaker();
            MLine = new LineMaker();
            MOval = new OvalMaker();
            MRectangle = new RectangleMaker();
            MSquare = new SquareMaker();
            MTriangle = new TriangleMaker();
            SelectedMaker = MLine;
            penStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }
    }
}
