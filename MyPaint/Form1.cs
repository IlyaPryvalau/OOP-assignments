using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;
using System.Reflection;

namespace MyPaint
{
    public partial class MainForm : Form
    {
        Graphics g;
        ShapeList DrawnShapesList = new ShapeList();
        Point StartPoint, FinishPoint;
        Shape DrawnShape;
        List<Shape> seriList;
        private Serializer serializer = new Serializer();
        private Maker MCircle, MLine, MOval, MRectangle, MSquare, MTriangle, SelectedMaker;
        private System.Drawing.Drawing2D.DashStyle penStyle;
        const string StatusBarMessage = "Drawing: ";
        string SelectedShapeName;
        bool _mousePressed = false, _drawnShapeIsOriginal = true;

        //OnClick button events for basic shapes                                                                    
        private void LineBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MLine;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.Name;
        }
        private void CircleBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MCircle;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.Name;
        }
        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MRectangle;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.Name;
        }
        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MTriangle;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.Name;
        }
        private void OvalBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MOval;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.Name;
        }
        private void SquareBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MSquare;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.Name;
        }
        //OnClick button events for basic shapes END

        //background color change event handler
        private void LineColorPBox_Click(object sender, EventArgs e)
        {
            if (LineColorDialog.ShowDialog() == DialogResult.OK)
            {
                LineColorPBox.BackColor = LineColorDialog.Color;
            }
        }

        //Handles the situation when different shapes from already drawn shapes list are chosen
        private void ShapeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShapeListBox.SelectedIndex > -1)
            {
                changeBtn.Enabled = true;
                deleteBtn.Enabled = true;
                Shape S = DrawnShapesList.GetShape(ShapeListBox.SelectedIndex);
                Invalidate();
                Update();
                g = CreateGraphics();
                MRectangle.Make(Color.Purple, 2, System.Drawing.Drawing2D.DashStyle.Dash, S.getX1(), S.getY1(), S.getX2(), S.getY2()).draw(g);
            } 
            else
            {
                Invalidate();
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            Shape shapeToChange = DrawnShapesList.GetShape(ShapeListBox.SelectedIndex);
            shapeToChange.ChangePenProperties(LineColorPBox.BackColor, (int)LineThicknessUpDown.Value, penStyle);
            Invalidate();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            deleteBtn.Enabled = false;
            changeBtn.Enabled = false;
            DrawnShapesList.RemoveShape(ShapeListBox.SelectedIndex);
            ShapeListBox.Items.RemoveAt(ShapeListBox.SelectedIndex);
            Invalidate();
        }

        //Serialization handler
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All files(*.*) | *.dat";
            seriList = DrawnShapesList.GetList();
            if (ShapeListBox.Items.Count != 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    serializer.Serialize(seriList, saveFileDialog1.FileName);
                }
            }
            else
                MessageBox.Show("Nothing to save!");
        }

        //Deserialization handler
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files(*.*) | *.dat";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                seriList = serializer.DeSerialize(openFileDialog1.FileName);            
                ShapeListBox.Items.Clear();
                foreach (Shape shape in seriList)
                {
                    shape.createPen();
                    ShapeListBox.Items.Add(shape.getName());
                    DrawnShapesList.setList(seriList);
                    Invalidate();
                }
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
            _mousePressed = true;
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void hideLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (hideLeft.Checked)
            {
                DrawingPanel.Enabled = false;
                DrawingPanel.Visible = false;
            }
            else
            {
                DrawingPanel.Enabled =true;
                DrawingPanel.Visible = true;
            }
        }

        private void hideRight_CheckedChanged(object sender, EventArgs e)
        {
            if (hideRight.Checked)
            {
                EditPanel.Enabled = false;
                EditPanel.Visible = false;
            }
            else
            {
                EditPanel.Enabled = true;
                EditPanel.Visible = true;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            FinishPoint = new Point(e.X, e.Y);
            _mousePressed = false;
            if (StartPoint != FinishPoint)
            {
                if (_drawnShapeIsOriginal)
                {
                    DrawnShape = SelectedMaker.Make(LineColorPBox.BackColor, (int)LineThicknessUpDown.Value,
                    penStyle, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y);
                }
                DrawnShapesList.Add(DrawnShape);
                ShapeListBox.Items.Add(DrawnShape.getName());
                Invalidate();
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FinishPoint.X = e.X;
                FinishPoint.Y = e.Y;
                Invalidate();
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            DrawnShapesList.DrawAll(g);
            if (_mousePressed)
                (SelectedMaker.Make(LineColorPBox.BackColor, (int)LineThicknessUpDown.Value, penStyle, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y)).draw(g);
        }

        private void BGColorPBox_Click(object sender, EventArgs e)
        {
            if (BGColorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = BGColorPBox.BackColor = BGColorDialog.Color;
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

        private void clrBtn_Click(object sender, EventArgs e)
        {
            DrawnShapesList.Clear();
            ShapeListBox.Items.Clear();
            changeBtn.Enabled = false;
            deleteBtn.Enabled = false;
            Invalidate();
            Update();
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
            SelectedShapeName = "Line";
            CurrentShape.Text = StatusBarMessage + SelectedShapeName;
            penStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }
    }
}
