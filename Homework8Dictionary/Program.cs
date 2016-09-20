using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, int> animals = new Dictionary <string, int>();
            animals.Add("octopus", 8);
            animals.Add("shark", 0);
            animals.Add("wolf", 4);
            animals.Add("bear", 4);
            animals.Add("penguin", 2);
            animals.Add("sloth", 4);

            Console.WriteLine("Enter an animal to find out how many legs it has:");
            string searchAni = Console.ReadLine();
            searchAni.ToLower();

            if (animals.ContainsKey(searchAni))
            {
                int legs = animals[searchAni];
                Console.WriteLine("A " + searchAni + " has " + legs + " legs.");
            }
            else
            {
                Console.WriteLine("Sorry, I've never heard of a " + searchAni + ".");
            }

            //would it be more efficient if the most commonly searched animals were at the top?


        }
    }
}
