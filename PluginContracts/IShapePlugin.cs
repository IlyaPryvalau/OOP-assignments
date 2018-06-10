using System.Drawing;

namespace PluginContracts
{
    public interface IShapePlugin
    {
        void draw(Graphics g);
        void ChangePenProperties(Color newColor, int newThickness, System.Drawing.Drawing2D.DashStyle newStyle);
        int getX1();
        int getY1();
        int getX2();
        int getY2();
        void setPen(Pen newPen);
        string getName();
        void createPen();  
    }
}
