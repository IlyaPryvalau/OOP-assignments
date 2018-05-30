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
        public Circle(Color color, int thickness, System.Drawing.Drawing2D.DashStyle style, int x1, int y1, int x2, int y2) : base(color, thickness, style, x1, y1, x2, y2) { }
        public override void draw(Graphics g)
        {
            int width = Math.Abs(x1 - x2); //the code is the same for square (circle is essentially an ellipse drawn in a square)
            int height = Math.Abs(y1 - y2);
            if (x1 >= x2 && y1 >= y2)
            {
                if (width >= height)
                    g.DrawEllipse(pen, x2 + width - height, y2, height, height);
                else
                    g.DrawEllipse(pen, x2, y2 + height - width, width, width);
            }
            if (x2 >= x1 && y2 >= y1)
            {
                if (width >= height)
                    g.DrawEllipse(pen, x1, y1, height, height);
                else
                    g.DrawEllipse(pen, x1, y1, width, width);
            }
            if (x1 >= x2 && y2 >= y1)
            {
                if (width >= height)
                    g.DrawEllipse(pen, x2 + width - height, y1, height, height);
                else
                    g.DrawEllipse(pen, x2, y1, width, width);
            }
            if (x2 >= x1 && y1 >= y2)
            {
                if (width >= height)
                    g.DrawEllipse(pen, x1, y2, height, height);
                else
                    g.DrawEllipse(pen, x1, y2 - width + height, width, width);
            }
        }
    }
}
