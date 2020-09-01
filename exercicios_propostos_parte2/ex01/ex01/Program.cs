using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro:");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Numero Negativo");
            }
            else
            {
                Console.WriteLine("Numero Positivo");
            }
        }
    }
}
