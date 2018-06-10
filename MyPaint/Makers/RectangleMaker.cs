﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    class RectangleMaker : Maker
    {
        public override string Name { get { return "Rectangle"; } }

        public override Shape Make(Color color, int thickness, System.Drawing.Drawing2D.DashStyle style, int x1, int y1, int x2, int y2)
        {
            return new Rectangle(color, thickness, style, x1, y1, x2, y2);
        }
    }
}
