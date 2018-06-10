using System;
using System.Drawing;

namespace MyPaint
{
    [Serializable]
    public abstract class Shape
    {
        [NonSerialized]
        protected Pen pen;
        protected int x1, x2, y1, y2;
        protected int penThickness;
        protected Color penColor;
        protected System.Drawing.Drawing2D.DashStyle penStyle;
        protected string name;

        public Shape(Color color, int thickness, System.Drawing.Drawing2D.DashStyle style, int x1, int y1, int x2, int y2)
        {
            penThickness = thickness;
            penColor = color;
            penStyle = style;
            pen = new Pen(penColor, penThickness);
            pen.DashStyle = style;
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public abstract void draw(Graphics g);

        public void ChangePenProperties(Color newColor, int newThickness, System.Drawing.Drawing2D.DashStyle newStyle)
        {
            pen.Color = penColor = newColor;
            pen.DashStyle = penStyle = newStyle;
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

        public abstract string getName();

        //creates and configurates pen after deserialization
        public void createPen()
        {
            this.pen = new Pen(penColor, penThickness);
            pen.DashStyle = penStyle;
        }
    }
}
