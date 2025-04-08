using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = add(5, 5);
            Console.WriteLine(result);

            result = add(5);
            Console.WriteLine(result);

            //Out
            test(out int num);
            Console.WriteLine(num);
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(1);
            list.Add(3);

            Console.WriteLine(isInList(3, list, out int posicao));
            Console.WriteLine(posicao);

            //Ref
            /**
             * Uma maneira mais rapida para o sistema
             * Em vez de enviar o valor, a função recebe o endereço de memoria do valor
             */

            int valor = 10;
            mudar(ref valor);
            Console.WriteLine(valor);

        }

        //Parametros Optionais
        /**
         * Maneiras de fazer:
         * int b = 10 Se vc não acrecentar o valor ele será o da sua escolha
         * int b = default
         * [Optional] int b
         */
        static int add(int a,[Optional] int b)
        {
            return a + b;
        }

        //OUT
        static void test(out int num)
        {
            num = 2;
        }

        /**
         * Permite que vc consiga "retornar" mais do que um valor
         */

        static bool isInList(int num, List<int> list, out int posicao) 
        {
            posicao = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == num)
                {
                    posicao = i;
                    return true;
                }
            }
            return false;
        }

        //REF
        static void mudar(ref int num)
        {
            num = 20;
        }
    }
}
