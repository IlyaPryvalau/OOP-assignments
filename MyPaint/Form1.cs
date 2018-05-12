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
        private Maker MCircle, MLine, MOval, MRectangle, MSquare, MTriangle;
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
        }
        private void DrawAllBtn_Click(object sender, EventArgs e)
        {
            MCircle.Make(Color.Black, 2, 100, 100, 150, 150).draw(g);
            MLine.Make(Color.Black, 2, 200, 170, 340, 30).draw(g);
            MOval.Make(Color.Black, 2, 220, 30, 320, 70).draw(g);
        }
    }
}
