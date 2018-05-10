﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        // member variables
        public Weather weather;
        Store store = new Store();
        List<Customer> customers = new List<Customer>();
        int customerCount;
        List<string> temperatures;
        List<string> skies;
        List<string> flavors;
        List<string> inventoryItems;
        List<string> activityOptions;
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
            activityOptions = new List<string>() { "Store", "Recipe", "Inventory", "Newspaper" };
            flavorOftheDay = GetFlavorOftheDay(customers);
        }

        //member methods
        public void BeginDay()
        {
            Console.WriteLine($"Today's weather is {weather}");
        }
        public void CreateCustomers(Random random)
        {
            customerCount = DetermineCustomerCount(random);
            for (int i = 0; i < customerCount; i++)
            {
                customers.Add(new Customer(temperatures, skies, flavors, random));
            }
        }
        public int DetermineCustomerCount(Random random)
        {
            switch (weather.quality)
            {
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
            else if (sourCount > sweetCount && sourCount > justRightCount)
            {
                flavorOftheDay = "Sour";

            }
            else
            {
                flavorOftheDay = "Just Right";
            }
        }
        public void Shop(Player player)//create shop within player class
        {
            UI.DisplayMenu(inventoryItems);
            string userInput = UI.GetUserInput();
            store.ShopBundles(userInput, player);
            Console.WriteLine("Would you like to keep shopping?");
            string yesNo = UI.GetUserInput();
            if (yesNo == "yes")
            {
                Shop(player);
            }
            else
            {
                return;
            }


        }


        public void RunNewspaper(List<Player> players)
        {
            foreach (Player player in players)
            {

                Console.WriteLine($"{player.name} you have earned {player.dollarsEarned}");
                Console.WriteLine($"{player.name} you have won {player.daysWon} days");
                Console.WriteLine($"{player.name} you wasted {player.dollarsWasted} dollars worth of product");
            
            }
            Console.WriteLine($"Today's favorite flavor is {flavorOftheDay}");
            Console.WriteLine($"Today's weather is {weather.sky} and {weather.temperature}");
            return;
        }
        public void ChangeRecipe(Player player)
        {
            DisplayCurrentRecipe(player);
            List<string> ingredients = new List<string> { "lemons", "sugar", "ice cubes per cup" };
            UI.DisplayMenu(ingredients);
            string userInput = UI.GetUserInput();
            CheckIngredients(userInput, player.recipe, player);
            Console.WriteLine("Would you like to change other ingredients?");
            string yesNo = UI.GetUserInput();
            if (yesNo == "yes")
            {
                ChangeRecipe(player);
            }
            else
            {
                return;
            }


        }

        public void CheckIngredients(string userInput, Recipe recipe, Player player)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("How many lemons would you like in each pitcher?");
                    int lemonInputInt = UI.GetUserInputInt();
                    recipe.lemonTotal = lemonInputInt;
                    DisplayCurrentRecipe(player);
                    break;
                case "2":
                    Console.WriteLine("How many cups of sugar would you like in each pitcher?");
                    int sugarInputInt = UI.GetUserInputInt();
                    recipe.sugarTotal = sugarInputInt;
                    DisplayCurrentRecipe(player);
                    break;
                case "3":
                    Console.WriteLine("How many ice cubes would you like in each cup?");
                    int recipeInputInt = UI.GetUserInputInt();
                    recipe.lemonTotal = recipeInputInt;
                    DisplayCurrentRecipe(player);
                    break;
                default:
                    Console.WriteLine("Hmm that doesn't look right..");
                    ChangeRecipe(player);
                    return;
            }
        }

        public void DisplayCurrentRecipe(Player player)
        {
            Console.WriteLine($"Your current recipe contains:");
            Console.WriteLine($"Lemons: {player.recipe.lemonTotal}");
            Console.WriteLine($"Sugar: {player.recipe.sugarTotal}");
            Console.WriteLine($"Ice per cup: {player.recipe.iceTotal}");

        }
        
        public string GetFlavorOftheDay(List <Customer> customers)
        {
            int favoriteJustRight = 0;
            int favoriteSweet = 0;
            int favoriteSour = 0;
            foreach (Customer customer in customers )
            {
                if (customer.favoriteFlavor == "Sweet")
                {
                    favoriteSweet += 1;
                }
                else if (customer.favoriteFlavor == "Sour")
                {
                    favoriteSour += 1;
                }
                else
                {
                    favoriteJustRight += 1;
                }
            }
            if (favoriteJustRight==favoriteSweet && favoriteSweet == favoriteSour)
            {
                return flavorOftheDay = "Just right";
            }
            else if (favoriteJustRight > favoriteSour && favoriteJustRight > favoriteSweet)
            {
                return flavorOftheDay = "Just right";
            }
            else if (favoriteSour > favoriteJustRight && favoriteSour > favoriteSweet)
            {
                return flavorOftheDay = "Sour";
            }
            else if (favoriteSweet > favoriteJustRight && favoriteSweet > favoriteSour)
            {
                return flavorOftheDay = "Sweet";
            }
            else
            {
                return flavorOftheDay = "Just Right";
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
