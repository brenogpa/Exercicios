using System;

namespace ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
            //  de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            //  ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            //  - Se o ponto estiver na origem, escreva a mensagem “Origem”.
            //  - Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            //  situação.
            //      |y
            //  Q2  |  Q1
            //______|______x
            //      |
            //  Q3  |  Q4
            //      |

            Console.WriteLine("Insira os valores x e y respectivamente(1 casa decimal):");
            string[] valors = Console.ReadLine().Split();

            double x = double.Parse(valors[0]);
            double y = double.Parse(valors[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
