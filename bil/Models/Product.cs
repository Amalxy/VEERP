using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bil.Models
{
    public class Product
    {

        public string Name { get; set; }
        public string ShopName { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int gst { get; set; }
        public string Branch { get; set; }
        public string Supplier { get; set; }
    }

}
