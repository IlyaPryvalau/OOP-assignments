using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        Graphics g;
        ShapeList DrawnShapesList = new ShapeList();
        Point StartPoint, FinishPoint;
        Shape shape;
        private Maker MCircle, MLine, MOval, MRectangle, MSquare, MTriangle;
        const string StatusBarMessage = "Drawing: ";
        Maker SelectedMaker;
        bool _mousePressed = false;

        private void ReDraw()
        {
            g.Clear(Color.White);
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

        private void DrawSpace_MouseUp(object sender, MouseEventArgs e)
        {
            FinishPoint = new Point(e.X, e.Y);
            if (StartPoint != FinishPoint) { 
                DrawnShapesList.Add(shape = SelectedMaker.Make(Color.Black, 2, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y));
                shape.draw(g);        
                //ReDraw();
            }
        }
        private void DrawSpace_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
            _mousePressed = true;
        }

        /*private void DrawSpace_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mousePressed)
            {
                shape = SelectedMaker.Make(Color.Black, 2, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y);
                shape.draw(g);
            }
        }*/

        private void clrBtn_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        public Form1()
        {
            InitializeComponent();
            g = DrawSpace.CreateGraphics();
            MCircle = new CircleMaker();
            MLine = new LineMaker();
            MOval = new OvalMaker();
            MRectangle = new RectangleMaker();
            MSquare = new SquareMaker();
            MTriangle = new TriangleMaker();
            SelectedMaker = MLine;
        }
    }
}
