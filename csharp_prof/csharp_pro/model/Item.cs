using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_pro.model
{
    internal class Item
    {
        public int itemId { get; set; }
        
        public string name { get; set; }
        public string  catagory { get; set; }
        public string status { get; set; }
        public DateTime  postDate { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public string location { get; set; }

        public int sellerId { get; set; } // foreign key


    }
}
