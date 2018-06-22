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
    public class Hexagon : Shape
    {
        public Hexagon(Color color, int thickness, PenStyle penStyle, int x1, int y1, int x2, int y2) : base(color, thickness, penStyle, x1, y1, x2, y2)
        {
            engname = "Hexagon";
            rusname = "Шестиугольник";
        }

        public override void draw(Graphics g)
        {
            g.DrawLine(pen, x1 + (x2 - x1) / 2, y1, x1, y1 - (y1 - y2) / 4);
            g.DrawLine(pen, x1 + (x2 - x1) / 2, y1, x2, y1 - (y1 - y2) / 4);
            g.DrawLine(pen, x1, y1 - (y1 - y2) / 4, x1, y1 - 3 * (y1 - y2) / 4);
            g.DrawLine(pen, x2, y1 - (y1 - y2) / 4, x2, y1 - 3 * (y1 - y2) / 4);
            g.DrawLine(pen, x1, y1 - 3 * (y1 - y2) / 4, x1 + (x2 - x1) / 2, y2);
            g.DrawLine(pen, x2, y1 - 3 * (y1 - y2) / 4, x1 + (x2 - x1) / 2, y2);
        }
    }
}
