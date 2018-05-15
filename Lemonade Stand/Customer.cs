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
        public double priceVariance;
        public string iceVariance;
        List<string> temperatures;
        List<string> flavors;
        List<string> skies;
        List<string> priceVariances;
        Random random;


        //constructor
        public Customer(List<string> temperatures, List<string> skies, List<string> flavors, Random random) 
        {
            
            this.random = random;
            this.temperatures = temperatures;
            this.skies = skies;
            this.flavors = flavors;


        }


        //member methods
        public void CreateCustomerPreferences() {
            priceVariances = new List<string> { ".10", ".25", ".50", ".75" };
            favoriteTemperature = UI.GetRandomOption(temperatures, random);
            favoriteSky = UI.GetRandomOption(skies, random);
            favoriteFlavor = UI.GetRandomOption(flavors, random);
            string priceVarianceString = UI.GetRandomOption(priceVariances, random);
            priceVariance = double.Parse(priceVarianceString);
            iceVariance = UI.GetRandomOption(new List<string> { "1", "2", "3", "4" }, random);       
             
        }
              
        
        //buy probabilty
            
        //give appreciation if flavor and price are true
    }
}
