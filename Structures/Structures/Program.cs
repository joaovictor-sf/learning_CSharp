using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        //Uma struct é um tipo de dado que permite criar estruturas de dados que agrupam variáveis relacionadas, semelhantes a classes.
        //Diferenças:
        /**
         * Structs são tipos de valor, ou seja, seus valores são armazenados diretamente na memória stack, ao contrário das classes, que são tipos de referência e armazenam valores no heap.
           Por causa disso, structs são mais leves e podem ser mais eficientes em operações simples.

           Structs não podem herdar de outras structs ou classes (exceto do System.ValueType, implicitamente).
           Elas não podem ser usadas como base para outras structs ou classes.

           São úteis para representar objetos simples, como pontos em um plano (x, y), cores (R, G, B), ou dimensões (largura, altura).

           E por fim, embora seja possível modificar os campos de uma struct, é uma boa prática criar structs imutáveis.
         */

        struct Ponto
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Ponto(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Mover(int dx, int dy)
            {
                X += dx;
                Y += dy;
            }

            public override string ToString() => $"Ponto({X}, {Y})";
        }

        static void Main(string[] args)
        {
            Ponto ponto = new Ponto(5, 4);

            Console.WriteLine(ponto);
        }
    }
}
