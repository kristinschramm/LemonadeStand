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
            int inputInt = Int32.Parse(inputString);
            return inputInt;
        }
        public static void DisplayMainMenu(List<string> menuOptions)
        {
            for (int i=0; i<menuOptions.Count; i++)
            {
                Console.WriteLine("Press " + (i + 1) + " to choose " + menuOptions[i]);
            }
       }
        public static void DisplayRules()
        {
            Console.WriteLine("Your goal is to make as much money as you can in 7, 14, or 21 days by selling lemonade at your lemonade stand.");
            Console.WriteLine("Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.");
            Console.WriteLine("Start with the basic recipe, but try to vary the recipe and see if you can do better.");
            Console.WriteLine("Lastly, set your price and sell your lemonade at the stand.");
            Console.WriteLine("Try changing up the price based on the weather conditions as well.");
            Console.WriteLine("At the end of the game, you'll see how much money you made.");
            Console.WriteLine("Press 'm' at any point during the game to get the main menu.");
            Console.WriteLine("Press 'q' at any point during the game to quit.");

        }
        public static string GetUserInput()
        {
            string inputString = Console.ReadLine();
            return inputString;
        }
        
        public static void DisplayInventory()
        {

        }
        public static void DisplayScore()
        {

        }
        public static string GetMainMenuInput()
        {
            string inputString = GetUserInput();
            return inputString;

        }
        

    }

}
