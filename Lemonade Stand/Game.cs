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
        Store store = new Store();
        Day day = new Day();
        int playerCountInt;

        //constructor
        public Game()
        {
            RunGame();
            
        }

        //member methods
        public void RunGame()
        {
            BeginGame();
            StartDay();
            EndDay();
            Console.ReadKey();
        }
        private void CheckMenuInput(string inputString)
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
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Oops! Invalid entry. Try again.");
                    UI.DisplayMainMenu(menuOptions);
                    break;
            }
        }
        public void MainMenu()
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
        

    }
}
