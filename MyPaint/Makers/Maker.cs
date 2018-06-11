using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BaseShape;

namespace MyPaint
{ 
    public abstract class Maker
    {
        public abstract string RusName { get; }
        public abstract string EngName { get; }

        public abstract Shape Make(Color color, int thickness, PenStyle penStyle, int x1, int y1, int x2, int y2); //factory method
    }
}
