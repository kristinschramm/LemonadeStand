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
        public static void DisplayPlayerInventory(Player player)
        {
            Console.WriteLine("{0} here is your inventory", player.name);
            Console.WriteLine("Cups: {0}", player.inventory.cups.Count);
            Console.WriteLine("Lemons: {0}", player.inventory.lemons.Count);
            Console.WriteLine("Sugar:{0}", player.inventory.sugarCups.Count);
            Console.WriteLine("Ice: {0}", player.inventory.iceCubes.Count);
            Console.WriteLine("Money: ${0}", player.inventory.money);

            //Console.WriteLine("{0} is something {1} is the other something", something, otherSomething);
            //Console.WriteLine($"This works too {something}");

        }
        public static void DisplayPurchaseMenu(List<Bundle> bundles)
        {
            for (int i = 0; i < bundles.Count; i++)
            {
                Console.WriteLine($"Press {i + 1} to purchase {bundles[i].quantity}  {bundles[i].name}s for {bundles[i].bundleTotal}");
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
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void DisplayScore(Player player)//not complete
        {
            //display total customers purchased out of total customers
            //display dollars earned
            //display days won        
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
        public static string GetUserInput()
        {
            string inputString = Console.ReadLine();
            return inputString;
        }
        public static int GetUserInputInt(string message)
        {
            Console.WriteLine(message);
            string inputString = GetUserInput();
            int inputInt = ConvertUserInputToInt(inputString);
            return inputInt;
        }
        public static int GetUserInputInt()
        {
            string inputString = GetUserInput();
            int inputInt = ConvertUserInputToInt(inputString);
            return inputInt;
        }
        public static string GetUserString(string message)
        {
            Console.WriteLine(message);
            string inputString = GetUserInput();
            return inputString;
        }       
    }
        

}
