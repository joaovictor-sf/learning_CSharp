using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // long > int
            // decimal > double > float

            int age = 10;
            long bigNumber = 10000000;
            float numberr = 2.2F;
            double bigNumber2 = 222.22;
            decimal another = 1.34M;

            //Convertendo String para valores:
            string val = "12";
            int valInt = Convert.ToInt32(val);
            

            Console.WriteLine("Data types in C##");
            Console.WriteLine("int");
            Console.WriteLine(age);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine("long");
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine("float");
            Console.WriteLine(numberr);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine("double");
            Console.WriteLine(bigNumber2);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine("decimal");
            Console.WriteLine(another);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
        }
    }
}
