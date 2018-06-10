using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    [Serializable]
    public class Triangle : Shape
    {
        public Triangle(Color color, int thickness, System.Drawing.Drawing2D.DashStyle style, int x1, int y1, int x2, int y2) : base(color, thickness, style, x1, y1, x2, y2)
        {
            name = "Triangle";
        }

        public override string getName()
        {
            return name;
        }

        public override void draw(Graphics g)
        {
            //Another way of drawing the even triangle
            /*g.DrawLine(pen, x1, y1, x2, y1);
            g.DrawLine(pen, x2, y1, x2 + (x1 - x2) / 2, y2);
            g.DrawLine(pen, x2 + (x1 - x2) / 2, y2, x1, y1);*/

            //straight triangle
            /*g.DrawLine(pen, x1, y1, x2, y1);
            g.DrawLine(pen, x2, y1, x2, y2);
            g.DrawLine(pen, x2, y2, x1, y1);*/

            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x1, y1, x1 + x1 - x2, y2);
            g.DrawLine(pen, x1 + x1 - x2, y2, x2, y2);
        }
    }
}
