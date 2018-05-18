using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forAndForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves= { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            
            string [] dinners =new string[7];
            string[] drinks = new string[7];
                


            for (int i = 0; i < sevenDwarves.Length; i++)
            {   string dinner = "";
                string drink = "";
                Console.WriteLine("What would you like for dinner? " +sevenDwarves[i]);
                dinner = Console.ReadLine();
                Console.WriteLine("What would you like to drink ? " + sevenDwarves[i]);
                drink = Console.ReadLine();
                dinners[i] = dinner;
                drinks[i] = drink;
                
               // Console.WriteLine("Here's your dinner, " +sevenDwarves[i]);
            }


            for (int i = 0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine("Here's your {0} and {1} {2} ", dinners[i], drinks[i], sevenDwarves[i] );
            }

           /* foreach (string dwarf in sevenDwarves)
            {
                for (int i = 0; i < dinners.Length; i++)
                {

                }
                Console.WriteLine("and here's your drink, " +dwarf);

            }*/


        }
    }
}
