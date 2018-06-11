using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseShape
{
    public class PenStyle
    {
        private string engname;
        private string rusname;
        private System.Drawing.Drawing2D.DashStyle style;
        public string EngName { get { return engname; } }
        public string RusName { get { return rusname; } }
        public System.Drawing.Drawing2D.DashStyle Style { get { return style; } set { style = value; } }

        public PenStyle(string engname, string rusname, System.Drawing.Drawing2D.DashStyle style)
        {
            this.engname = engname;
            this.rusname = rusname;
            this.style = style;
        }
    }
}
