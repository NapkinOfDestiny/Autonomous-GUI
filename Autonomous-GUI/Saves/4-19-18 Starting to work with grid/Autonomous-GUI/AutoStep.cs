using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autonomous_GUI
{
    class AutoStep
    {
        public string name { get; set; }
        public bool start  { get; set; }
        public bool end { get; set; }


        private AutoStep(string dn, bool dstart = false, bool dend = false)
        {
            name = dn;
            start = dstart;
            end = dend;


         
        }

        
        private string FormatTop()
        {           
            string defaultTop = $"<Step id=\"{name}\" entry=\"{start}\" exit=\"{end}\">\r\n<Action id=\"{name}_A1\" parent= \"{name}\" classname=\"OIDataFaker\">";

            return defaultTop;
        }
        private string FormatBottom()
        {
            string defaultBottom = "</Action>\r\n</Step>";

            return defaultBottom;
        }

    }
}
