using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Human : Player
    {
        
        public Human()
        {
            
        }
        public override string SetPlayerName(string player)
        {
            Console.WriteLine(player + ", please enter your name:");
            name = UI.GetUserInput();
            return name;
        }
        public override string SetPlayerBusinessName(string player)
        {
            Console.WriteLine($"{player}, please enter your business name:");
            businessName = UI.GetUserInput();
            Console.WriteLine($"{player} your business name is {businessName}\n");
            return businessName;
        }
        public override void SetLemonadePrice()
        {

        }

        public override void SetLemonadeRecipe()
        {
        
        }

    }

}
