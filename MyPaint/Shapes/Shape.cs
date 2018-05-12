using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public abstract class Shape
    {
        protected Pen pen;
        public Color penColor;
        public int penThickness;
        protected int x1, x2, y1, y2;
        public Shape(Color color, int thickness, int x1, int y1, int x2, int y2)
        {
            penColor = color;
            pen = new Pen(penColor);
            pen.Color = penColor;
            penThickness = thickness;
            pen.Width = penThickness;
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public abstract void draw(Graphics g);
    }
}
