using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace StringDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //$ or +
            string name = "John";
            int age = 23;
            Console.WriteLine($"My name is {name} and I am {age}");
            Console.WriteLine("My name is " + name + " and I am " + age);
            Console.WriteLine("My name is {0} and I am {1}", name, age);

            //Verbatim string literal
            //\t \n \" \\

            Console.WriteLine("C:\\Users\\joaov\\source\\repos\\StringDetails");
            Console.WriteLine("Hello \t my \n \"Friend\"");

            string path = @"C:\Users\joaov\source\repos\StringDetails" + "\n esse for meu teste com @";
            Console.WriteLine(path);

            // Maybe would be good to use string.Empty than ""
            // O resultado é o mesmo, mas para deixar claro, talvez seja bom costume usar string.Empty

            // Assim como no java, para comparar Strings o apropiado é .Equals

            //Chalenge: reverse a string
            Console.WriteLine("Write something");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
