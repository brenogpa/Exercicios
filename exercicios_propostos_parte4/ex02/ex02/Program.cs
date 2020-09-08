using System;
using System.Security.Cryptography.X509Certificates;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            */

            Console.Write("Insira a quantidade de valores a serem lidos: ");
            int n = int.Parse(Console.ReadLine());
            int c_in = 0;
            int c_out = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Insira o {i}° valor: ");
                int x = int.Parse(Console.ReadLine());
                
                if (x >= 10 && x <= 20)
                {
                    c_in++;
                }
                else
                {
                    c_out++;
                }
            }

            Console.WriteLine($"{c_in} in \n {c_out} out");
        }
    }
}
