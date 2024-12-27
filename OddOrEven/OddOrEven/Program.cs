using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the integer number and I will say if it's odd or even");
            string numInput = Console.ReadLine();

            bool isInteger = int.TryParse(numInput, out int result);

            if (isInteger)
            {
                int num = int.Parse(numInput);
                Console.WriteLine(num % 2 == 0 ? "Odd" : "Even");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
