using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class SquareMaker : Maker
    {
        public override Shape Make(int x1, int y1, int x2, int y2)
        {
            return new Square(x1, y1, x2, y2);
        }
    }
}
