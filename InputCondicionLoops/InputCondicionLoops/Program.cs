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

                string result = age > 120 ? "How you are alive?" : "Ok";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("You aren't old enough to drink");
            }

            Console.WriteLine("Write the number of the mounth you where born");
            string input = Console.ReadLine();
            int mounth = Convert.ToInt32(input);

            switch (mounth)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            int x = 0;
            while (x < 3)
            {
                x++;
                Console.WriteLine(x);
            }
        }
    }
}
