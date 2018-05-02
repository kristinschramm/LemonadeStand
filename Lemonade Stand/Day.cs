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
        Weather weather = new Weather();
        List<Customer> customers = new List<Customer>();

        

       //member constructors
        public Day()
        {
            Console.WriteLine(weather.temperature);
            Console.WriteLine(weather.sky);
            CreateCustomers();

        }

        //member methods
        public void CreateCustomers()
        {

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
        //has weather
        //newspaper
        //customer quanity 
            //create customer list

    }
}
