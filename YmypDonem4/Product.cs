using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypDonem4
{
    public class Product
    {
        //field (alan)
        //property (özellik)
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }

        public bool KDVApplied { get; set; } 


        //methods (metodlar)

    }
}
