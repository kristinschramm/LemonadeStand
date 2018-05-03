using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer : Day
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
        public Customer(List<string> temperatures, List<string> skies, List<string> flavors, Random random) : base(random)
        {
            priceVariances = new List<string> { "5", "10", "15", "20" };
            this.random = random;
            this.temperatures = temperatures;
            this.skies = skies;
            this.flavors = flavors;
            favoriteTemperature = GenerateRandom(random, temperatures);
            favoriteSky = GenerateRandom(random, skies);
            favoriteFlavor = GenerateRandom(random, flavors);
            priceVariance = GenerateRandom(random, priceVariances);
            iceVariance = GenerateRandom (random, new List<string>{"1","2","3","4"});

        }


        //member methods



        //random number
       
        
        //buy probabilty
            
        //give appreciation if flavor and price are true
    }
}
