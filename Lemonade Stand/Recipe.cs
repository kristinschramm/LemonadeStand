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
        public double cupTotal;
        public double lemonValue = .3;
        public double sugarValue = .1;
        public double iceValue = .005;
        public double cupValue = .05;
        public double cupLemonadeValue;
        public double reasonablePrice;
        public string flavor;


        public Recipe()
        {
            lemonTotal = 4;
            sugarTotal = 2;
            iceTotal = 4;
            cupTotal =(lemonTotal + sugarTotal + (iceTotal/4));
            double cupTotalRound = Math.Floor(cupTotal);

            
            double lemonadeValue = (lemonValue * lemonTotal + sugarValue * sugarTotal)/ cupTotal;
            cupLemonadeValue = (iceValue * iceTotal) + cupValue + lemonadeValue;
            reasonablePrice = cupLemonadeValue * 4;
            DetermineFlavor();
        }

        public void DetermineFlavor()
        {
            if (lemonTotal > sugarTotal + 2)
            {
                flavor = "Sour";
            }
            else if (sugarTotal > lemonTotal + 2)
            {
                flavor = "Sweet";
            }
            else
            {
                flavor = "Just Right";
            }

        }
    }
}
