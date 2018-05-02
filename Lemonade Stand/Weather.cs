using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        //member variables
        public string temperature;
        public string sky;
        public int quality;
        List<string> temperatures = new List<string> {"Hot", "Cold"};
        List<string> skies = new List<string> { "Sunny", "Cloudy", "Rainy" };
        
        // constructor
        public Weather(){
            temperature = GenerateTemperature(Game.random);
            sky = GenerateSky(Game.random);
            quality = DetermineWeatherQuality(temperature, sky);

         }      

        //member methods
        private string GenerateTemperature(Random random)
        {
            int randomValue = random.Next(1, (temperatures.Count + 1));
            return temperature = temperatures[randomValue - 1];
        }
        private string GenerateSky(Random random)
        {
            int randomValue = random.Next(1, (skies.Count + 1));
            return sky = skies[randomValue - 1];
        }
        private int DetermineWeatherQuality(string temperature, string sky)
        {
            if ( temperature == "Hot")
            {
                if (sky == "Sunny")
                {
                    return quality = 4;
                }
                else if (sky == "Cloudy")
                {
                    return quality = 3;
                }
                else
                {
                    return quality = 2;
                }
            }
            else {
                if (sky == "Sunny")
                {
                    return quality = 3;
                }
                else if (sky == "Cloudy")
                {
                    return quality = 2;
                }
                else
                {
                    return quality = 1;
                }
            }
        }
    
    }
}
