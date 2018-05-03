using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        // member variables
        Weather weather;
        List<Customer> customers = new List<Customer>();
        int customerCount;
        List<string> temperatures;
        List<string> skies;
        List<string> flavors;
        string flavorOftheDay;
        Random random;

       //member constructors
        public Day(Random random)
        {
            this.random = random;
            flavors = new List<string> { "Sweet", "Sour", "Just Right" };
            skies = new List<string> { "Sunny", "Cloudy", "Rainy" };
            temperatures = new List<string> { "Hot", "Cold" };            
            weather = new Weather(temperatures, skies, random);            
        }

        //member methods

        public void CreateCustomers(Random random)
        {
            customerCount= DetermineCustomerCount(random);
            for (int i=0; i<customerCount; i++)
            {
                customers.Add(new Customer(temperatures, skies, flavors, random));
            }
        }
        public string GenerateRandom(Random random, List<string> options)
        {
            string randomOption;
            int randomValue = random.Next(1, (options.Count + 1));
            return randomOption = options[randomValue - 1];
        }

        public int DetermineCustomerCount(Random random)
        {
            switch (weather.quality) {
                case 1:
                    return customerCount = random.Next(1, 51);                    
                case 2:
                    return customerCount = random.Next(50, 101);                    
                case 3:
                    return customerCount = random.Next(100, 151);                    
                case 4:
                    return customerCount = random.Next(150, 201);                    
                case 5:
                    return customerCount = random.Next(200, 251);
                default:
                    return customerCount = random.Next(1, 251);
            }
            
        }
        public void PreferredFlavorOfDay()
        {
            int sweetCount = 0;
            int sourCount = 0;
            int justRightCount = 0;
            foreach (Customer c in customers)
            {
                if (c.favoriteFlavor == "Sweet")
                {
                    sweetCount++;
                }
                else if (c.favoriteFlavor == "Sour")
                {
                    sourCount++;
                }
                else { justRightCount++; }
            }
            if (sweetCount == sourCount && sweetCount == justRightCount)
            {
                flavorOftheDay = "Just Right";
            }
            else if (sweetCount > sourCount && sweetCount > justRightCount)
            {
                flavorOftheDay = "Sweet";
            }
            else if (sourCount > sweetCount && sourCount > justRightCount) {
                flavorOftheDay = "Sour";

            }
            else {
                flavorOftheDay = "Just Right";
            }              
        }
        //begin Day
            //read newspaper
            //go to store
        //sell Lemonade
            //sell out
        //end Day
            //report sales     
            //ice melt
            //inventory spoil chance        
        //newspaper
        

    }
}
