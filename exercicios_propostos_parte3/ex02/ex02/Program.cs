using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
            */

            string[] pontos = Console.ReadLine().Split();

            int x = int.Parse(pontos[0]);
            int y = int.Parse(pontos[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                    break;
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                    break;
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                    break;
                }
                else
                {
                    Console.WriteLine("terceiro");
                    break;
                }
            }
        }
    }
}
