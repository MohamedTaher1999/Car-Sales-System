using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test
{
    public class carclass
    {
        public int car_id{get; set;}
        public int customer_id { get; set; }
        public string makke { get; set; }
        public string price { get; set; }
        public string car_model { get; set; }
        public string engine { get; set; }
        public string weight { get; set; }
        public string manufacturedstate { get; set; }
        public string yearestablished { get; set; }
        public string maxspeed { get; set; }
        public string tank { get; set; }
        public string details { get; set; }
        public string color { get; set; }

        public Byte[] pic  { get; set; }
    }
}
