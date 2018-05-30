using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    public class Line : Shape
    {
        public Line(Color color, int thickness, System.Drawing.Drawing2D.DashStyle style, int x1, int y1, int x2, int y2) : base(color, thickness, style, x1, y1, x2, y2) { }
        public override void draw(Graphics g)
        {
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
