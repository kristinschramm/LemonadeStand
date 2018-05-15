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
        public static List<string> menuOptions = new List<string>() { "Display Rules", "New Game", "Display Score", "Display Inventory", "End Game" };
        public List<Player> players = new List<Player>();
        public List<Day> days = new List<Day>();
        public List<string> inventoryItems = new List<string>() { "Lemons", "Cups of Sugar", "Cups", "Ice" };
        int playerCountInt;
        int dayCountInt;
        int dayNumber;
        public static Random random = new Random();
        public static Game game = new Game();
        


        //constructor
        public Game()
        {
            dayNumber = 1;
            

        }

        //member methods

        public void RunGame()//not complete loop through
        {
            BeginGame();
            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine($"Today's weather is {days[i].weather}");
                StartDay(days[i]);
                RunDay(days[i]);
                EndDay(days[i]);

            }
            EndGame();
            Console.ReadKey();
        }
        public void BeginGame()
        {
            Welcome();
            playerCountInt = UI.GetUserInputInt("Please enter the number of players.");
            CreatePlayers();
            dayCountInt = UI.GetUserInputInt("Please enter the number of days you would like to play");
            CreateDays();
            return;
        }
        public void CheckMenuInput(string inputString, Player player)
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
                    UI.DisplayScore(player);
                    break;
                case "4":
                    UI.DisplayPlayerInventory(player);
                    break;
                case "5":
                    EndGame();
                    break;
                case "q":
                    Quit();
                    break;
                case "m":
                    MainMenu(player);
                    break;
                default:
                    Console.WriteLine("Oops! Invalid entry. Try again.");
                    UI.DisplayMenu(menuOptions);
                    break;
            }
        }//validate (maybe write specific validation method taking in the length of the list)
        public void CheckStoreMenuInput(int userInputInt, Player player)
        {
            switch (userInputInt)
            {
                case 1:
                    player.PurchaseItems("Lemons");
                    break;
                case 2:
                    player.PurchaseItems("Sugar");
                    break;
                case 3:
                    player.PurchaseItems("Cups");
                    break;
                case 4:
                    player.PurchaseItems("Ice");
                    break;
                default:
                    Console.WriteLine("Hmm...that wasn't a valid response.");
                    UI.DisplayMenu(inventoryItems);
                    break;
            }
        }//validate (maybe write specific validation method taking in the length of the list)
        public void CreateDays()
        {
            for (int i = 0; i < dayCountInt; i++)
            {
                days.Add(new Day(inventoryItems, random));
            }
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
        private void EndDay(Day day)
        {

            // add a day to each item
            // set ice = 0;
            // spoil if it's been there for 3 days
            //lemons mold
            //sugar gets ants
            //end of round readkey for each player
            //display customers missed
            //display sales (x customers out of y)
            //display waste
            //display popularity


        }// not complete create foreach players
        public void EndGame()
        {
            //declare winner
            //display total profits
            //add players to high score database
            //display high score database
        }//not complete
        public void MainMenu(Player player)
        {
            Console.WriteLine("This is the main menu.");
            UI.DisplayMenu(menuOptions);
            string userInputString = UI.GetUserInput();
            CheckMenuInput(userInputString, player);
        }
        public static void Quit()//maybe just not....
        {
            Welcome();
        } //not complete
        public void RunDay(Day day)
        {
            //foreach customer
            foreach (Customer customer in day.customers)
            {


            }
            //determine purchase for each lemonade stand
            //decide if you want a customer to be done once it buys one or give each player equal chance
            //make lemonade pitchers
            //handle sold out
            //make day dashboard??      

        }//not complete create foreach players ASK if it would be a good idea to write a loop funtion, can a function be a parameter?
        private void StartDay(Day day)
        {
            for (int i = 0; i < players.Count; i++)
            {
                Console.Clear();
                Console.WriteLine($"Ready {players[i].name}? It's your turn to get ready for the day {dayNumber}.");
                MorningRoutine(day, players[i]);
                day.SetDailyPrice(players[i]);
            }

        }//not complete create foreach players
        public static void Welcome()
        {
            Console.WriteLine("Welcome to your virtual Lemonade Stand");
            UI.DisplayRules();
        }

        public void CheckStartDayInput(string inputString, Day day, Player player)
        {
            switch (inputString)
            {
                case "1":
                    day.Shop(player);
                    break;
                case "2":
                    day.RunNewspaper(players);
                    break;
                case "3":
                    day.ChangeRecipe(player);
                    break;
                case "4":
                    UI.DisplayPlayerInventory(player);
                    break;
                case "q":
                    Quit();
                    break;
                case "m":
                    MainMenu(player);
                    break;
                default:
                    Console.WriteLine("Oops! Invalid entry. Try again.");
                    UI.DisplayMenu(menuOptions);
                    break;
            }

        }
        public void MorningRoutine(Day day, Player player)
        {
            UI.DisplayMenu(new List<string>() { "Store", "Newspaper", "Recipe", "Inventory" });
            string userInputString = UI.GetUserInput();
            CheckStartDayInput(userInputString, day, player);
            Console.WriteLine("Would you like to open your lemonade stand for the day?");
            string yesNo = UI.GetUserInput();
            if (yesNo == "no")
            {
                MorningRoutine(day, player);
            }
            else
            {
                return;
            }
        }
    }
}
