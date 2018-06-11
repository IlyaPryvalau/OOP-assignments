using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BaseShape;

namespace MyPaint
{
    class SquareMaker : Maker
    {
        public override string RusName { get { return "Квадрат"; } }
        public override string EngName { get { return "Square"; } }

        public override Shape Make(Color color, int thickness, PenStyle penStyle, int x1, int y1, int x2, int y2)
        {
            return new Square(color, thickness, penStyle, x1, y1, x2, y2);
        }
    }
}
