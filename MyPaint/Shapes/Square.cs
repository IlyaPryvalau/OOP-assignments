using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    public class Square : Shape
    {
        public Square(Color color, int thickness, int x1, int y1, int x2, int y2) : base(color, thickness, x1, y1, x2, y2) { }
        public override void draw(Graphics g)
        {
            int width = Math.Abs(x1 - x2);
            int height = Math.Abs(y1 - y2);
            if (x1 >= x2 && y1 >= y2)
            {
                if (width >= height)
                    g.DrawRectangle(pen, x2 + width - height, y2, height, height);
                else
                    g.DrawRectangle(pen, x2 + height - width, y2, width, width);
            }
            if (x2 >= x1 && y2 >= y1)
            {
                if (width >= height)
                    g.DrawRectangle(pen, x1, y1, height, height);
                else
                    g.DrawRectangle(pen, x1, y1, width, width);
            }
            if (x1 >= x2 && y2 >= y1)
            {
                if (width >= height)
                    g.DrawRectangle(pen, x2 + width - height, y1, height, height);
                else
                    g.DrawRectangle(pen, x2, y1, width, width);
            }
            if (x2 >= x1 && y1 >= y2)
            {
                if (width >= height)
                    g.DrawRectangle(pen, x1, y2, height, height);
                else
                    g.DrawRectangle(pen, x1, y2 - width + height, width, width);
            }
        }
    }
}
