using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    [Serializable]
    public class Square : Shape
    {
        public Square(Color color, int thickness, System.Drawing.Drawing2D.DashStyle style, int x1, int y1, int x2, int y2) : base(color, thickness, style, x1, y1, x2, y2) { }
        public override void draw(Graphics g)
        {
            int width = Math.Abs(x1 - x2);
            int height = Math.Abs(y1 - y2);
            if (x1 >= x2 && y1 >= y2)
            {
                if (width >= height)
                {
                    g.DrawRectangle(pen, x2 + width - height, y2, height, height);
                    x2 = x2 + width - height;
                }
                else
                {
                    g.DrawRectangle(pen, x2, y2 + height - width, width, width);
                    y2 = y2 + height - width;
                }
            }
            if (x2 >= x1 && y2 >= y1)
            {
                if (width >= height)
                {
                    g.DrawRectangle(pen, x1, y1, height, height);
                    x2 = x1 + height;
                }
                else
                {
                    g.DrawRectangle(pen, x1, y1, width, width);
                    y2 = y1 + width;
                }
            }
            if (x1 >= x2 && y2 >= y1)
            {
                if (width >= height)
                {
                    g.DrawRectangle(pen, x2 + width - height, y1, height, height);
                    x2 = x2 + width - height;
                }
                else
                {
                    g.DrawRectangle(pen, x2, y1, width, width);
                    y2 = y1 + width;
                }
            }
            if (x2 >= x1 && y1 >= y2)
            {
                if (width >= height)
                {
                    g.DrawRectangle(pen, x1, y2, height, height);
                    x2 = x1 + height;
                }
                else
                {
                    g.DrawRectangle(pen, x1, y2 - width + height, width, width);
                    y2 = y2 + height - width;
                }
            }
        }
    }
}
