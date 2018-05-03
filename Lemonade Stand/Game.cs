using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {


        // member variables (HAS A)
        List<string> menuOptions = new List<string>() { "Display Rules", "New Game", "Display Score" , "Display Inventory" , "End Game" };
        List<Player> players = new List<Player>();
        List<Day> days = new List<Day>();        
        Store store = new Store();        
        int playerCountInt;
        int dayCountInt;
        int dayNumber;
        public static Random random = new Random(); 

        //constructor
        public Game()
        {
            dayNumber = 0;
                     
        }

        //member methods
        
        public void RunGame()
        {
            BeginGame();
            //while loop
            StartDay();
            EndDay();
            EndGame();
            Console.ReadKey();
        }
        public void CheckMenuInput(string inputString)
        {
            switch (inputString)
            {
                case "1":
                    UI.DisplayRules();
                    break;
                case "2":
                    BeginGame();
                    break;
                case "3":
                    UI.DisplayScore();
                    break;
                case "4":
                    UI.DisplayInventory();
                    break;
                case "5":
                    EndGame();
                    break;
                case "q":
                    Quit();
                    break;
                case "m":
                    MainMenu(menuOptions);
                    break;
                default:
                    Console.WriteLine("Oops! Invalid entry. Try again.");
                    UI.DisplayMainMenu(menuOptions);
                    break;
            }
        }
        public void MainMenu(List<string> menuOptions)
        {
            Console.WriteLine("This is the main menu.");
            UI.DisplayMainMenu(menuOptions);
            string userInputString= UI.GetMainMenuInput();
            CheckMenuInput(userInputString);
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to your virtual Lemonade Stand");
            UI.DisplayRules();
        }
        public void BeginGame()
        {
            Welcome();
            playerCountInt = UI.GetPlayerCount();
            CreatePlayers();
            dayCountInt = UI.GetDayCount();
            CreateDays();

        }
        private void StartDay()
        {

        }

        private void EndDay()
        {

        }
        
        public void EndGame()
        {

        }
        public void Quit()
        {
            Welcome();
        }
        public void CreatePlayers()
        {
            for (int i = 0; i < playerCountInt; i++)
            {
                players.Add(new Human());
            }
            for (int i = 0; i < players.Count; i++)
            {
                players[i].name = ("Player " + (i + 1));
                players[i].name = players[i].SetPlayerName(players[i].name);
                players[i].businessName = players[i].SetPlayerBusinessName(players[i].name);
            }
            Console.WriteLine("Would you also like to play against a computer?");
            string yesNo = UI.GetUserInput();
            if (yesNo == "yes")
            {
                players.Add(new AI());
            }
            else
            {
                return;
            }
        }
        
        public static int GetRandomNumber(int min, int max)
        {
            int randomValue = random.Next(min,max);            
            return randomValue;
        }
        public void CreateDays()
        {
            for (int i = 0; i < dayCountInt; i++)
            {
                days.Add(new Day(random));
            }            
        }

    }
}
