using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using BaseShape;

namespace MyPaint
{
    class Serializer
    {
        public void Serialize(List<Shape> LocalList, string FileName)
        {
            BinaryFormatter Formatter = new BinaryFormatter();
            using (FileStream FileStr = new FileStream(FileName, FileMode.Create))
            {
                try
                {
                    Formatter.Serialize(FileStr, LocalList);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public List<Shape> DeSerialize(string FileName)
        {
            List<Shape> DShapeList = null;
            BinaryFormatter Formatter = new BinaryFormatter();
            using (FileStream FileStr = new FileStream(FileName, FileMode.Open))
            {
                try
                {
                    DShapeList = (List<Shape>)(Formatter.Deserialize(FileStr));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    DShapeList = null;
                }
            }
            return DShapeList;
        }
    }
}
