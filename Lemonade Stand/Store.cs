using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {   
        public Lemon lemon;
        public Ice ice;
        public Cup cup;
        public Sugar sugar;
        public List<string> inventoryItems = new List<string>() { "Lemons", "Cups of Sugar", "Cups", "Ice" };

        // constructor
        public Store() {
           
            lemon = new Lemon();
            ice = new Ice();
            sugar = new Sugar();
            cup = new Cup();

        }

        //member methods

        public void Purchase(Player player, Bundle bundle)
        {
            bool trueFalse = CheckPlayerMoney(player, bundle);
            if (trueFalse == true)
            {
                if (bundle.name == "lemon")
                {
                    for (int i = 0; i < bundle.quantity; i++)
                    {
                        player.inventory.lemons.Add(new Lemon());
                    }
                    player.inventory.money -= bundle.bundleTotal;
                }
                else if (bundle.name == "cup of sugar")
                {
                    for (int i = 0; i < bundle.quantity; i++)
                    {
                        player.inventory.sugarCups.Add(new Sugar());
                    }
                    player.inventory.money -= bundle.bundleTotal;
                }
                else if (bundle.name == "cube of ice")
                {
                    for (int i = 0; i < bundle.quantity; i++)
                    {
                        player.inventory.iceCubes.Add(new Ice());
                    }
                    player.inventory.money -= bundle.bundleTotal;
                }
                else if (bundle.name == "cup")
                {
                    for (int i = 0; i < bundle.quantity; i++)
                    {
                        player.inventory.cups.Add(new Cup());
                    }
                    player.inventory.money -= bundle.bundleTotal;
                }

            }
            else
            {
                Console.WriteLine("Looks like you don't have enough for that. You currently have ${0}", player.inventory.money);
            }

        }

        public List<Bundle> CreateBundles(Item item)            
        {
            List<Bundle> bundles = new List<Bundle>();
            double bundlePrice = item.value;
            int bundleQuantity = item.bundleQuantity;
            Bundle bundle1 = new Bundle(bundlePrice, bundleQuantity, item);
            bundles.Add(bundle1);
            Bundle bundle2 = new Bundle((bundlePrice * .9), (bundleQuantity * 2), item);
            bundles.Add(bundle2);
            Bundle bundle3 = new Bundle((bundlePrice * .75), (bundleQuantity * 3), item);
            bundles.Add(bundle3);
            return bundles;
        }
        public void ShopBundles(string userInput, Player player)
        {
            switch (userInput)
            {
                 case "1":                    
                    List<Bundle> lemonBundles =CreateBundles(lemon);
                    UI.DisplayPurchaseMenu(lemonBundles);
                    int i = UI.GetUserInputInt() - 1;
                    Purchase(player, lemonBundles[i]);
                    UI.DisplayPlayerInventory(player);
                    break;
                case "2":
                    List<Bundle> sugarBundles = CreateBundles(sugar);
                    UI.DisplayPurchaseMenu(sugarBundles);
                    int j = UI.GetUserInputInt() - 1;
                    Purchase(player, sugarBundles[j]);
                    UI.DisplayPlayerInventory(player);
                    break;               
                case "3":
                    List<Bundle> cupBundles = CreateBundles(cup);
                    UI.DisplayPurchaseMenu(cupBundles);
                    int l = UI.GetUserInputInt() - 1;
                    Purchase(player, cupBundles[l]);
                    UI.DisplayPlayerInventory(player);
                    break;
                case "4":
                    List<Bundle> iceBundles = CreateBundles(ice);
                    UI.DisplayPurchaseMenu(iceBundles);
                    int k = UI.GetUserInputInt() - 1;
                    Purchase(player, iceBundles[k]);
                    UI.DisplayPlayerInventory(player);
                    break;
                default:
                    Console.WriteLine("Hmm, that isn't a valid response, please try again");
                    UI.DisplayMenu(inventoryItems);
                    break;

            }

        }

      
        public void CheckBundleInput(string inputString, List <Bundle> bundles, Player player)
        {
            switch (inputString)
            {
                case "1":
                    Purchase(player, bundles[0]);
                    
                    break;
                case "2":
                    Purchase(player, bundles[1]);
                    break;
                case "3":
                    Purchase(player, bundles[2]);

                    break;
               default:
                    Console.WriteLine("Oops! Invalid entry. Try again.");
                    UI.DisplayPurchaseMenu(bundles);
                    break;
            }
                        
        }
        private bool CheckPlayerMoney(Player player, Bundle bundle)
        {
            if (player.inventory.money > bundle.bundleTotal)
            {
                return true;            
            }
            else
            {
                return false;
            }
        }

    }
}
