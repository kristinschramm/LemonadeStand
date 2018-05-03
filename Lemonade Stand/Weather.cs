using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather { 
        //member variables
        public string temperature;
        public string sky;
        public int quality;
        List<string> temperatures;
        List<string> skies;
        
        
        // constructor
        public Weather(List<string> temperatures, List<string> skies, Random random)  {
            this.temperatures = temperatures;
            this.skies = skies;
            temperature = UI.GetRandomOption(temperatures, random);
            sky = UI.GetRandomOption(skies, random);
            quality = DetermineWeatherQuality(temperature, sky);
         }      

        //member methods             
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
