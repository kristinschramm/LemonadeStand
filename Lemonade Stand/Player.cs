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
        Inventory inventory;
        

        //constructor
        public Player()
        {
            Inventory inventory = new Inventory();        
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

        public abstract string SetPlayerName(string player);
        public abstract string SetPlayerBusinessName(string player);
        public abstract void SetLemonadeRecipe();
        public abstract void SetLemonadePrice();
        
    }
}
