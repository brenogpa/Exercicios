using System;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Ler um número inteiro N e calcular todos os seus divisores.

            Console.Write("Insira um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            for (int c = 1; c <= n; c++)
            {
                if (n % c == 0)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
