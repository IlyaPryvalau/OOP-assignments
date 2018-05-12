using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public class Triangle : Shape
    {
        public Triangle(Color color, int thickness, int x1, int y1, int x2, int y2) : base(color, thickness, x1, y1, x2, y2) { }
        public override void draw(Graphics g)
        {
            Console.WriteLine("Triangle({0}, {1}, {2}, {3})", x1, y1, x2, y2);
        }
    }
}
