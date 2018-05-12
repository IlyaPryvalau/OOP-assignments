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
        ShapeList SList = new ShapeList();
        ShapeList SList1 = new ShapeList();
        Point StartPoint, FinishPoint;
        Shape shape;
        private Maker MCircle, MLine, MOval, MRectangle, MSquare, MTriangle;

        private void DrawSpace_MouseUp(object sender, MouseEventArgs e)
        {
            FinishPoint = new Point(e.X, e.Y);
            if (StartPoint != FinishPoint) {
                switch (ShapeBox.Text)
                {
                    case "Rectangle":
                        SList1.Add(shape = MRectangle.Make(Color.Black, 2, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y));
                        shape.draw(g);
                        break;
                    case "Square":
                        SList1.Add(shape = MSquare.Make(Color.Black, 2, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y));
                        shape.draw(g);
                        break;
                    case "Oval":
                        SList1.Add(shape = MOval.Make(Color.Black, 2, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y));
                        shape.draw(g);
                        break;
                    case "Circle":
                        SList1.Add(shape = MCircle.Make(Color.Black, 2, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y));
                        shape.draw(g);
                        break;
                    case "Triangle":
                        SList1.Add(shape = MTriangle.Make(Color.Black, 2, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y));
                        shape.draw(g);
                        break;
                    case "Line":
                        SList1.Add(shape = MLine.Make(Color.Black, 2, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y));
                        shape.draw(g);
                        break;
                    default:
                        SList1.Add(shape = MLine.Make(Color.Black, 2, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y));
                        shape.draw(g);
                        break;
                }
                //ReDraw();
            }
        }
        private void ReDraw()
        {
            g.Clear(Color.White);
            SList1.DrawAll(g);
        }
        private void DrawSpace_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }
        
        private void DrawAllBtn_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            SList.DrawAll(g);
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        public Form1()
        {
            //static tipification for lab1
            SList.Add(new Circle(Color.Black, 2, 100, 100, 150, 150));
            SList.Add(new Line(Color.Black, 2, 200, 170, 340, 30));
            SList.Add(new Oval(Color.Black, 2, 220, 30, 320, 70));
            SList.Add(new Rectangle(Color.Black, 2, 360, 30, 460, 70));
            SList.Add(new Triangle(Color.Black, 2, 480, 30, 580, 70));
            SList.Add(new Square(Color.Black, 2, 600, 30, 700, 70));
            //lab1 end
            InitializeComponent();
            g = DrawSpace.CreateGraphics();
            MCircle = new CircleMaker();
            MLine = new LineMaker();
            MOval = new OvalMaker();
            MRectangle = new RectangleMaker();
            MSquare = new SquareMaker();
            MTriangle = new TriangleMaker();
        }
    }
}
