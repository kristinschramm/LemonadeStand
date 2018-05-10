using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Recipe
    {
        public int lemonTotal;
        public int sugarTotal;
        public int iceTotal;
        public int cupTotal;


        public Recipe()
        {
            lemonTotal = 4;
            sugarTotal = 2;
            iceTotal = 4;
            cupTotal = lemonTotal + sugarTotal + ((lemonTotal*sugarTotal)/iceTotal);
        }
    }
}
