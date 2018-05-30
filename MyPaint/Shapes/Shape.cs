using System.Drawing;

namespace MyPaint
{
    public abstract class Shape
    {
        protected Pen pen;
        protected int x1, x2, y1, y2;
        protected int penThickness;
        protected Color penColor;
        protected System.Drawing.Drawing2D.DashStyle penStyle;
        public Shape(Color color, int thickness, System.Drawing.Drawing2D.DashStyle style,  int x1, int y1, int x2, int y2)
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
        public void ChangePenProperties(Color newColor, int newThickness, System.Drawing.Drawing2D.DashStyle newStyle)
        {
            penThickness = newThickness;
            pen.Color = penColor = newColor;
            pen.DashStyle = penStyle = newStyle;
            pen.Width = penThickness = newThickness;
        }
        public abstract void draw(Graphics g);
    }
}
