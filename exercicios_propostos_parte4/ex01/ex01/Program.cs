using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
             X, se for o caso.
            */

            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            for (int c = 1; c <= num; c++)
            {
                if (c % 2 != 0)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
