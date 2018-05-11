using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
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
        public void DrawAll()
        {
            foreach (Shape shape in shapeList)
            {
                shape.draw();
            }
        }
    }
}
