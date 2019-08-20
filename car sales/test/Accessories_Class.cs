using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace test
{
    public class Accessories_Class
    {
        public int accessories_id { get; set; }
        public string accessories_name{ get; set; }
        public int customer_id { get; set; }
        public string accessories_type { get; set; }
        public Byte[] accessories_picture { get; set; }
        public string accessories_price{ get; set; }
    }
}
