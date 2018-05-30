using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    public abstract class Maker
    {
        public abstract Shape Make(Color color, int thickness, System.Drawing.Drawing2D.DashStyle style, int x1, int y1, int x2, int y2); //factory method
    }
}
