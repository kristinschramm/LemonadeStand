using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Bundle
    {
        public int quantity;
        public double price;
        public string name;
        public double bundleTotal;

        public Bundle(double bundlePrice, int bundleQuantity, Item item)
        {
            quantity = bundleQuantity;
            price = bundlePrice;
            bundleTotal = quantity * price;
            name = item.name;

            
        }
    }
}
