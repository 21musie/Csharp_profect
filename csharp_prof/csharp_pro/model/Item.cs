using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_pro.model
{
   class Item
    {
        public int itemid { get; set; } 
        public string name { get; set; }
        public string status { get; set; }

        public string postdate { get; set; }
        public string quantity { get; set; }
        public int location { get; set; }
    }
}
