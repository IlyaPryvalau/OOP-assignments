using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BaseShape
{
    [Serializable]
    public abstract class Shape
    {
        [NonSerialized]
        protected Pen pen;
        protected int x1, x2, y1, y2;
        protected int penThickness;
        protected Color penColor;
        protected string engname;
        protected string rusname;
        protected System.Drawing.Drawing2D.DashStyle dashStyle; //field for dash style serialization
        [NonSerialized]
        protected PenStyle penStyle;

        public string EngName { get { return engname; } }
        public string RusName { get { return rusname; } }

        public Shape(Color color, int thickness, PenStyle penStyle, int x1, int y1, int x2, int y2)
        {
            penThickness = thickness;
            penColor = color;
            this.penStyle = penStyle;
            pen = new Pen(penColor, penThickness);
            pen.DashStyle = dashStyle = penStyle.Style;
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public abstract void draw(Graphics g);

        public void ChangePenProperties(Color newColor, int newThickness, PenStyle newPenStyle)
        {
            pen.Color = penColor = newColor;
            pen.DashStyle = dashStyle = penStyle.Style =  newPenStyle.Style;
            pen.Width = penThickness = newThickness;
        }

        public int getX1()
        {
            return x1;
        }
        public int getY1()
        {
            return y1;
        }
        public int getX2()
        {
            return x2;
        }
        public int getY2()
        {
            return y2;
        }

        public void setPen(Pen newPen)
        {
            this.pen = newPen;
        }

        //creates and configurates pen after deserialization
        public void createPen()
        {
            this.pen = new Pen(penColor, penThickness);
            pen.DashStyle = dashStyle;
        }
    }
}
