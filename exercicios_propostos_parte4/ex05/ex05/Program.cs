using System;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
                Lembrando que, por definição, fatorial de 0 é 1.
            */
            Console.Write("Fatorial \n Digite um valor: ");
            int n = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int c = 1; c <= n; c++)
            {
                fat *= c;
            }

            Console.WriteLine(fat);
        }
    }
}
