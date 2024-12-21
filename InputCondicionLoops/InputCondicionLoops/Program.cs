using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputCondicionLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine("What's your age?");

            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if (age >= 18)
            {
                Console.WriteLine("You can drink");
            }
            else
            {
                Console.WriteLine("You aren't old enough to drink");
            }
        }
    }
}
