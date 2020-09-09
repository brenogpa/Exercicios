using System;

namespace ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
                começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor.
            */


            Console.Write("Digite um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());

            for (int c = 1; c <= n; c++)
            {
                Console.WriteLine($"{c} {c*c} {c*c*c} ");
            }
        }
    }
}
