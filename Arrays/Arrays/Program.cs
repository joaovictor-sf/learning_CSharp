using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] ints = new int[5];
            ints[0] = 1;
            ints[1] = 2;
            ints[2] = 3;
            ints[3] = 4;
            ints[4] = 5;

            foreach (int i in ints) {
                Console.WriteLine(i);
            }

            //List
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine("List");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            //Dictionary
            Dictionary<int, string> nomes = new Dictionary<int, string>
            {
                {1, "John"},
                {20, "Daniel"},
                {5, "Gustavo"},
                {15, "John "}

            };

            Console.WriteLine("Dictionary");
            for (int i = 0; i < nomes.Count; i++)
            {
                KeyValuePair<int, string> pair = nomes.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            //Pode usar var ou KeyValuePair
            foreach (var pair in nomes)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}
