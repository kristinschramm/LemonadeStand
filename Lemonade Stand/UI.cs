using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    static class UI
    {
        //member methods

        public static int ConvertUserInputToInt(string inputString)
        {
            int inputInt = int.Parse(inputString);
            return inputInt;
        }
        public static void DisplayMenu(List<string> menuOptions)
        {
            for (int i = 0; i < menuOptions.Count; i++)
            {
                Console.WriteLine("Press " + (i + 1) + " to choose " + menuOptions[i]);
            }
        }
        public static void DisplayRules()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Your goal is to make as much money as you can in 7, 14, or 21 days by selling lemonade at your lemonade stand.");
            Console.WriteLine("Step One:");
            Console.WriteLine(" - Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.");
            Console.WriteLine("Step Two:");
            Console.WriteLine(" - Start with the basic recipe, but try to vary the recipe and see if you can do better.");
            Console.WriteLine("Step Three:");
            Console.WriteLine(" - Lastly, set your price and sell your lemonade at the stand.");
            Console.WriteLine(" - At the end of the game, you'll see how much money you made.");
            Console.WriteLine("Tips:  ");
            Console.WriteLine(" 1.  Try changing up the price based on the weather conditions as well.");
            Console.WriteLine(" 2.  Check the newspaper daily to see the weather forecast and helpful tips.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Press 'm' at any point during the game to get the main menu.");
            Console.WriteLine("Press 'q' at any point during the game to quit.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static string GetUserInput()
        {
            string inputString = Console.ReadLine();
            return inputString;
        }

        public static void DisplayInventory()
        {
            Console.WriteLine("Which player's inventory would you like to display");
        }
        public static void DisplayScore()
        {

        }
        public static string GetUserString(string message)
        {
            Console.WriteLine(message);
            string inputString = GetUserInput();
            return inputString;
        }
        public static void DisplayPlayerInventory()// update when players are created
        {
            ////Console.WriteLine("Player here is your inventory");
            //Console.WriteLine("Cups: " + Inventory.cups);
            //Console.WriteLine("Lemons: " + Inventory.lemons);
            //Console.WriteLine("Sugar: " + Inventory.sugar);
            //Console.WriteLine("Ice: " + Inventory.ice);
            //Console.WriteLine("Money: " + Inventory.money);
            //Console.WriteLine("Satisfaction: " + Inventory.satisfaction);

            //Console.WriteLine("{0} is something {1} is the other something", something, otherSomething);
            //Console.WriteLine($"This works too {something}");

        }
        //display inventory

        public static int GetInputInt(string message)
        {
            Console.WriteLine(message);
            string inputString = GetUserInput();
            int inputInt = ConvertUserInputToInt(inputString);
            return inputInt;
        }
        public static int GetInputInt()
        {
            string inputString = GetUserInput();
            int inputInt = ConvertUserInputToInt(inputString);
            return inputInt;
        }
        public static int GetRandomNumber(int min, int max, Random random)
        {
            int randomValue = random.Next(min, max);
            return randomValue;
        }
        public static int GetRandomNumber(int max, Random random)
        {
            int randomValue = random.Next(max);
            return randomValue;
        }
        public static string GetRandomOption(List<string> options, Random random)
        {
            string randomOption;
            int randomValue = random.Next(1, (options.Count + 1));
            return randomOption = options[randomValue - 1];
        }
        public static void DisplayPurchaseMenu(List<int> itemQuantity, List<double> itemPrice, string type)
        {
            for (int i = 0; i < itemQuantity.Count; i++)
            {
                Console.WriteLine($"Press {i + 1} to purchase {itemQuantity[i]}  {type} for {itemPrice[i]}");
            }
        }

    }
        

}
