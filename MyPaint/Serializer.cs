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
            FileStream FileStr = new FileStream(FileName, FileMode.Create);
            BinaryFormatter Formatter = new BinaryFormatter();
            try
            {
                Formatter.Serialize(FileStr, LocalList);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                FileStr.Close();
            }
        }

        public List<Shape> DeSerialize(string FileName)
        {
            List<Shape> DShapeList = null;
            FileStream FileStr = new FileStream(FileName, FileMode.Open);
            BinaryFormatter Formatter = new BinaryFormatter();
            //Formatter.Binder = new TypeNameConverter();
            try
            {
                DShapeList = (List<Shape>)(Formatter.Deserialize(FileStr));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DShapeList = null;
            }
            finally
            {
                FileStr.Close();
            }
            return DShapeList;
        }
    }
}
