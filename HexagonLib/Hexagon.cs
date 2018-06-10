using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPaint;
using PluginContracts;
using System.Drawing;

namespace HexagonLib
{
    public class Hexagon : Shape, IShapePlugin
    {
        public Hexagon(Color color, int thickness, System.Drawing.Drawing2D.DashStyle style, int x1, int y1, int x2, int y2) : base(color, thickness, style, x1, y1, x2, y2)
        {
            name = "Hexagon";
        }

        public override string getName()
        {
            return name;
        }

        public override void draw(Graphics g)
        {
            g.DrawLine(pen, x1 + (x2 - x1) / 2, y1, x1, y1 - (y1 - y2) / 4);
            g.DrawLine(pen, x1 + (x2 - x1) / 2, y1, x2, y1 - (y1 - y2) / 4);
            g.DrawLine(pen, x1, y1 - (y1 - y2) / 4, x1, y1 - 3 * (y1 - y2) / 4);
            g.DrawLine(pen, x2, y1 - (y1 - y2) / 4, x2, y1 - 3 * (y1 - y2) / 4);
            g.DrawLine(pen, x1, y1 - 3 * (y1 - y2) / 4, x1 + (x2 - x1) / 2, y2);
            g.DrawLine(pen, x2, y1 - 3 * (y1 - y2) / 4, x1 + (x2 - x1) / 2, y2);
        }
    }
}
