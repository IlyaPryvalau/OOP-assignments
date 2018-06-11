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
using BaseShape;
using PluginSystem;
using System.Xml;

namespace MyPaint
{
    public partial class MainForm : Form
    {
        Graphics g;
        ShapeList DrawnShapesList;
        Point StartPoint, FinishPoint;
        Shape DrawnShape;
        List<Shape> seriList;
        List<PenStyle> penStyleList;
        PenStyle penStyle;
        ICollection<Type> pluginCollection;
        private Serializer serializer = new Serializer();
        private Maker MCircle, MLine, MOval, MRectangle, MSquare, MTriangle, SelectedMaker;
        const string StatusBarMessage = "Drawing: ";
        string SelectedShapeName;
        bool _mousePressed = false,
            _drawnShapeIsOriginal = true,
            _pluginsLoaded = false;
            

        //OnClick button events for basic shapes                                                                    
        private void LineBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MLine;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.EngName;
            _drawnShapeIsOriginal = true;
        }
        private void CircleBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MCircle;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.EngName;
            _drawnShapeIsOriginal = true;
        }
        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MRectangle;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.EngName;
            _drawnShapeIsOriginal = true;
        }
        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MTriangle;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.EngName;
            _drawnShapeIsOriginal = true;
        }
        private void OvalBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MOval;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.EngName;
            _drawnShapeIsOriginal = true;
        }
        private void SquareBtn_Click(object sender, EventArgs e)
        {
            SelectedMaker = MSquare;
            CurrentShape.Text = StatusBarMessage + SelectedMaker.EngName;
            _drawnShapeIsOriginal = true;
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
            if (ShapeListBox.SelectedIndex != -1)
            {
                changeBtn.Enabled = true;
                deleteBtn.Enabled = true;
                Shape S = DrawnShapesList.GetShape(ShapeListBox.SelectedIndex);
                Invalidate();
                Update();
                g = CreateGraphics();
                //Because of the way this triangle is drawn the select triangle around it doesn't display correctly, this "if" fixes it.
                if (S.EngName == "Triangle")
                    MRectangle.Make(Color.Purple, 2, new PenStyle("Dash", "Штрих", System.Drawing.Drawing2D.DashStyle.DashDot), S.getX2(), S.getY2(),
                        2 * S.getX1() - S.getX2(), S.getY1()).draw(g);
                else 
                    MRectangle.Make(Color.Purple, 2, new PenStyle("Dash", "Штрих", System.Drawing.Drawing2D.DashStyle.DashDot) , S.getX1(), S.getY1(), S.getX2(), S.getY2()).draw(g);
            } 
            else
            {
                Invalidate();
            }
        }

        //Confirm changes in the drawn shape object
        private void changeBtn_Click(object sender, EventArgs e)
        {
            Shape shapeToChange = DrawnShapesList.GetShape(ShapeListBox.SelectedIndex);
            shapeToChange.ChangePenProperties(LineColorPBox.BackColor, (int)LineThicknessUpDown.Value, penStyle);
            Invalidate();
        }


        //Delete the shape from drawn shapes and from listBox
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
                DrawnShapesList.GetList().AddRange(seriList);
                foreach (Shape shape in seriList)
                {
                    shape.createPen();
                    ShapeListBox.Items.Add(shape.EngName);
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

        //Handles an event of choosing plugged-in shape from combo box
        private void PluginsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_pluginsLoaded)
            {
                _drawnShapeIsOriginal = false;
            }
        }

        //Handles choosing different line types from Line types combo box
        private void LineTypesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LineTypesComboBox.SelectedIndex != -1)
            {
                penStyle = (PenStyle)LineTypesComboBox.SelectedItem;
            }
        }

        //Load plugins on form load
        private void MainForm_Load(object sender, EventArgs e)
        {
            pluginCollection = PluginLoader<Shape>.LoadPlugins("Plugins");
            if (pluginCollection.Count > 0)
            {
                PluginsComboBox.DataSource = pluginCollection;
                PluginsComboBox.DisplayMember = "Name";
                PluginsComboBox.Enabled = true;
                PluginsComboBox.SelectedIndex = -1;
            }
            _pluginsLoaded = true;
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
                else
                {
                    DrawnShape = (Shape)Activator.CreateInstance((Type)PluginsComboBox.SelectedItem, LineColorPBox.BackColor, (int)LineThicknessUpDown.Value,
                    penStyle, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y);
                }
                DrawnShapesList.Add(DrawnShape);
                ShapeListBox.Items.Add(DrawnShape.EngName);
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
            if (_mousePressed && _drawnShapeIsOriginal)
                (SelectedMaker.Make(LineColorPBox.BackColor, (int)LineThicknessUpDown.Value, penStyle, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y)).draw(g);
            else if (_mousePressed)
                ((Shape)Activator.CreateInstance((Type)PluginsComboBox.SelectedItem, LineColorPBox.BackColor, (int)LineThicknessUpDown.Value,
                penStyle, StartPoint.X, StartPoint.Y, FinishPoint.X, FinishPoint.Y)).draw(g);
        }

        private void BGColorPBox_Click(object sender, EventArgs e)
        {
            if (BGColorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = BGColorPBox.BackColor = BGColorDialog.Color;
            }
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

        //Creates .xml config file in which the current app configuration will bw stored
        private void SaveConfiguration()
        {
            XmlDocument XmlDoc = new XmlDocument();
            try
            {
                XmlDoc.Load("config.xml");
                XmlElement XmlEl = XmlDoc.DocumentElement;
                XmlEl.RemoveAll();
            }
            catch //If theres isn't a config gile - crate it
            {
                XmlTextWriter XmlWriter = new XmlTextWriter("config.xml", Encoding.UTF8);
                XmlWriter.WriteStartDocument();
                XmlWriter.WriteStartElement("head");
                XmlWriter.WriteEndElement();
                XmlWriter.Close();
                XmlDoc.Load("config.xml");
            }

            //<Color>
            XmlNode CurrUpperNode = XmlDoc.CreateElement("Color");
            XmlDoc.DocumentElement.AppendChild(CurrUpperNode);             

            XmlNode CurrChildNode = XmlDoc.CreateElement("BackArgbColor");
            CurrChildNode.InnerText = BGColorPBox.BackColor.ToArgb().ToString();
            CurrUpperNode.AppendChild(CurrChildNode);

            CurrChildNode = XmlDoc.CreateElement("LineArgbColor");
            CurrChildNode.InnerText = LineColorPBox.BackColor.ToArgb().ToString();
            CurrUpperNode.AppendChild(CurrChildNode);
            //</Color>
            
            //<Pen>
            CurrUpperNode = XmlDoc.CreateElement("Pen");
            XmlDoc.DocumentElement.AppendChild(CurrUpperNode);

            CurrChildNode = XmlDoc.CreateElement("Thickness");
            CurrChildNode.InnerText = LineThicknessUpDown.Value.ToString();
            CurrUpperNode.AppendChild(CurrChildNode);

            CurrChildNode = XmlDoc.CreateElement("Style");
            CurrChildNode.InnerText = penStyle.Style.ToString();
            CurrUpperNode.AppendChild(CurrChildNode);
            //</Pen>

            //<Language>
            CurrUpperNode = XmlDoc.CreateElement("Language");
            XmlDoc.DocumentElement.AppendChild(CurrUpperNode);
            CurrChildNode = XmlDoc.CreateElement("CurrL");
            CurrChildNode.InnerText = AppLanguage;
            CurrUpperNode.AppendChild(CurrChildNode);
            //</Language>

            XmlDoc.Save("config.xml");
        }

        //Form constructor
        public MainForm()
        {
            //Ensuring painting without flickering
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            UpdateStyles();
            //Instantiate shape object makers
            MCircle = new CircleMaker();
            MLine = new LineMaker();
            MOval = new OvalMaker();
            MRectangle = new RectangleMaker();
            MSquare = new SquareMaker();
            MTriangle = new TriangleMaker();
            //Instantiate a list of drawn shapes
            DrawnShapesList = new ShapeList();
            //Initialize default options
            SelectedMaker = MLine;
            SelectedShapeName = MLine.EngName;
            CurrentShape.Text = StatusBarMessage + SelectedShapeName;
            penStyle = new PenStyle("Solid", "Сплошная", System.Drawing.Drawing2D.DashStyle.Solid);
            //Instantiate pen style list
            penStyleList = new List<PenStyle>();

            //Adding penStyles to a list which'll be made to a data source for the combo box
            penStyleList.Add(penStyle);
            penStyleList.Add(new PenStyle("Dash", "Пунктир", System.Drawing.Drawing2D.DashStyle.Dash));
            penStyleList.Add(new PenStyle("Dash-dot", "Штрих-пунктир",System.Drawing.Drawing2D.DashStyle.DashDot));
            penStyleList.Add(new PenStyle("Dash-dot-dot", "Штрих-пунктир-пунктир", System.Drawing.Drawing2D.DashStyle.DashDotDot));
            penStyleList.Add(new PenStyle("Dot", "Пунктир", System.Drawing.Drawing2D.DashStyle.Dot));
            LineTypesComboBox.DataSource = penStyleList;
            LineTypesComboBox.DisplayMember = "EngName";

            //
        }
    }
}
