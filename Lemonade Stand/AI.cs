using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class AI : Player
    {
        //random generate
        public AI()
        {
            name = SetPlayerName(name);
            businessName = SetPlayerBusinessName(businessName);

        }
        public override string SetPlayerName(string name)
        {
            return name = "Larry";           
        }
        public override string SetPlayerBusinessName(string businessName)
        {
            return businessName = "Larry's Lemonade";
        }
        public override void SetLemonadePrice()
        {

        }

        public override void SetLemonadeRecipe()
        {

        }

    }
}
