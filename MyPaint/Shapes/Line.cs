using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BaseShape;

namespace MyPaint
{
    [Serializable]
    public class Line : Shape
    { 
        public Line(Color color, int thickness, PenStyle penStyle, int x1, int y1, int x2, int y2) : base(color, thickness, penStyle, x1, y1, x2, y2)
        {
            engname = "Line";
            rusname = "Круг";
        }

        public override void draw(Graphics g)
        {
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
