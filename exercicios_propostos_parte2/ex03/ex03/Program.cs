using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor (int) de A e B, respectivamente:");
            string[] num = Console.ReadLine().Split();

            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);

            if (A % B == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
