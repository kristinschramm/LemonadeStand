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
        List<string> inventoryItems;
        string flavorOftheDay;
        Random random;

       //member constructors
        public Day(List<string> inventoryItems, Random random)
        {
            this.random = random;
            this.inventoryItems = inventoryItems;
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
        public void Shop()
        {
            UI.DisplayMenu(inventoryItems);

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
