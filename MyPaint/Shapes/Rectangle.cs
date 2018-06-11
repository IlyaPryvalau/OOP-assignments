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
    public class Rectangle : Shape
    {
        public Rectangle(Color color, int thickness, PenStyle penStyle, int x1, int y1, int x2, int y2) : base(color, thickness, penStyle, x1, y1, x2, y2)
        {
            engname = "Rectangle";
            rusname = "Прямоугольник";
        }

        public override void draw(Graphics g)
        {
            int width = Math.Abs(x1 - x2);
            int height = Math.Abs(y1 - y2);
            if (x1 >= x2 && y1 >= y2)
                g.DrawRectangle(pen, x2, y2, width, height);
            else if (x2 >= x1 && y2 >= y1)
                g.DrawRectangle(pen, x1, y1, width, height);
            else if (x1 >= x2 && y2 >= y1)
                g.DrawRectangle(pen, x2, y1, width, height);
            else if (x2 >= x1 && y1 >= y2)
                g.DrawRectangle(pen, x1, y2, width, height);
        }
    }
}
