using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    [Serializable]
    class ShapeList
    {
        private List<Shape> shapeList;
        public ShapeList()
        {
            shapeList = new List<Shape>();
        }
        public List<Shape> GetList()
        {
            return shapeList;
        }
        public Shape GetShape(int index)
        {
            return shapeList[index];
        }
        public void Add(Shape shape)
        {
            shapeList.Add(shape);
        }
        public void RemoveShape(int index)
        {
            shapeList.RemoveAt(index);
        }
        public void DrawAll(Graphics g)
        {
            foreach (Shape shape in shapeList)
            {
                shape.draw(g);
            }
        }
        public void Clear()
        {
            shapeList.Clear();
        }
        public void setList(List<Shape> newList)
        {
            shapeList = newList;
        }
    }
}
