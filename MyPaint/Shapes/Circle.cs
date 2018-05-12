using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    public class Circle : Shape
    {
        public Circle(Color color, int thickness, int x1, int y1, int x2, int y2) : base(color, thickness, x1, y1, x2, y2) { }
        public override void draw(Graphics g)
        {
            int radius = (int)(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            g.DrawEllipse(pen, x1 - radius, y1 - radius, radius * 2, radius * 2);
        }
    }
}
