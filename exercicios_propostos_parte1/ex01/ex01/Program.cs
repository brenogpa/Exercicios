using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada: ");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 += valor2;

            Console.WriteLine("Soma = " + soma);
        }
    }
}
