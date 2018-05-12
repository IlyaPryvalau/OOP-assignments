using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    class TriangleMaker : Maker
    {
        public override Shape Make(Color color, int thickness, int x1, int y1, int x2, int y2)
        {
            return new Triangle(color, thickness, x1, y1, x2, y2);
        }
    }
}
