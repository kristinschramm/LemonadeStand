using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    abstract class Player
    {
        //member variables
        public string name;
        public string businessName;
        public Inventory inventory;
        public int daysWon;
        public double dollarsEarned=0;
        public double dollarsWasted= 0;
        public int customersServed=0;
        public Recipe recipe = new Recipe();
        public double lemonadePrice;
        public int customersMissed = 0;



        //constructor
        public Player()
        {
            inventory = new Inventory();
            daysWon = 0;
            dollarsEarned = 0;
            dollarsWasted = 0;
            customersServed = 0;
            lemonadePrice = 1.75; //.toString("C");
        }        

        //member methods

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public abstract void SetLemonadePrice();
        public abstract void SetLemonadeRecipe();
        public abstract void PurchaseItems(string items);
        public abstract string SetPlayerName(string player);
        public abstract string SetPlayerBusinessName(string player);
    }
}
