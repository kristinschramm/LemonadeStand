using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {   //member variables
        List<int> lemonQuantities;
        List<double> lemonPrices;
        List<int> sugarQuantities;
        List<double> sugarPrices;
        List<int> cupQuantities;
        List<double> cupPrices;
        List<double> icePrices;
        List<int> iceQuantities;
        
        // constructor
        public Store() { 
            lemonQuantities = new List<int>() { 10, 30, 75 };
            lemonPrices = new List<double>() { .65, 1.75, 4.25 };
            sugarQuantities = new List<int>() { 8, 25, 50 };
            sugarPrices = new List<double>() { .50, 1.25, 2.00 };
            cupQuantities = new List<int>() { 25, 50, 100 };
            cupPrices = new List<double>() { .90, 1.60, 3.00 };
            icePrices = new List<double>() { 1.00, 2.00, 3.00 };
            iceQuantities = new List<int>() { 100, 250, 500 };     

        }       

        //member methods

        public void Purchase(int itemInventory, int quantity, double price, double money)
        {
            itemInventory += quantity;
            money -= price * quantity;            

        }
        
        
        // cups 25 for .90, 50 for 1.60, 100 for 3.00
        // lemons 10 for .65, 30 for 1.75, 75 for 4.25
        // sugar 8 cups for .50, 25 for 1.25, 50 for 2.00
        

        //purchase cups
        // display price
        // add to inventory
        // remove funds
        //purchase lemons
        //display price
        // add to inventory
        // remove funds
        //purchase sugar
        //display price
        // add to inventory
        // remove funds
        //purchase ice
        //display price
        // add to inventory
        // remove funds
    }
}
