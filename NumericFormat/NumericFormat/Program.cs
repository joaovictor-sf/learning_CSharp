using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double value = 1000 / 2.5;
            double value2 = 1000 / 12.34;
            //Console.WriteLine(value);
            Console.WriteLine("Sem formadação: " + value2);
            Console.WriteLine(string.Format("Formadação 0: {0:0}", value2));
            Console.WriteLine(string.Format("Formadação 0.0: {0:0.0}", value2));
            Console.WriteLine(string.Format("Formadação 0.#(Se for 0, ignora o resto): {0:0.#}", value2));
            Console.WriteLine(string.Format("Formadação 0.00: {0:0.00}", value2));


            double money = -10d / 3;

            Console.WriteLine();
            Console.WriteLine(money);
            Console.WriteLine(string.Format("R$ 10 / R$ 3 = R$ {0:0.00}", money));

            Console.WriteLine();
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine("Ulilizando metodo ToString escrevendo o char 'C' permite que o sistema veja qual a cultura da moeda do país padrão do sistema");

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.InvariantCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("pt-PT")));

            string input = Console.ReadLine();
            int.TryParse(input, out int result);
            if (result == 0)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine(result);
            }

            input = Console.ReadLine();
            if(int.TryParse(input, out int result2))
            {
                Console.WriteLine(result2);
            }

        }
    }
}
