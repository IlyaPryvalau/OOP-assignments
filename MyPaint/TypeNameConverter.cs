using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Reflection;

namespace MyPaint
{
    /*class TypeNameConverter : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            typeName = typeName.Replace("HexagonLib.Hexagon", "MyPaint.Shape");
            assemblyName = assemblyName.Replace("HexagonLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Assembly.GetExecutingAssembly().FullName);
            return Type.GetType(string.Format("{0}, {1}", typeName, assemblyName));
        }
    }*/
}
