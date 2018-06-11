using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BaseShape;

namespace MyPaint
{
    class RectangleMaker : Maker
    {
        public override string RusName { get { return "Прямоугольник"; } }
        public override string EngName { get { return "Rectangle"; } }

        public override Shape Make(Color color, int thickness, PenStyle penStyle, int x1, int y1, int x2, int y2)
        {
            return new Rectangle(color, thickness, penStyle, x1, y1, x2, y2);
        }
    }
}
