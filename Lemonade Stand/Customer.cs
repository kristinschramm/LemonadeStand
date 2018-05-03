using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer 
    {
        //member variables
        public string favoriteFlavor;
        public string favoriteTemperature;
        public string favoriteSky;
        public string priceVariance;
        public string iceVariance;
        List<string> temperatures;
        List<string> flavors;
        List<string> skies;
        List<string> priceVariances;
        Random random;


        //constructor
        public Customer(List<string> temperatures, List<string> skies, List<string> flavors, Random random) 
        {
            priceVariances = new List<string> { "5", "10", "15", "20" };
            this.random = random;
            this.temperatures = temperatures;
            this.skies = skies;
            this.flavors = flavors;
            favoriteTemperature = UI.GetRandomOption(temperatures, random);
            favoriteSky = UI.GetRandomOption(skies, random);
            favoriteFlavor = UI.GetRandomOption(flavors, random);
            priceVariance = UI.GetRandomOption(priceVariances, random);
            iceVariance = UI.GetRandomOption(new List<string>{"1","2","3","4"}, random);

        }


        //member methods



        //random number
       
        
        //buy probabilty
            
        //give appreciation if flavor and price are true
    }
}
