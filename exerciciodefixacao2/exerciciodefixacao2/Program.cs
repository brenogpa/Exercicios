using System;
using System.Globalization;

namespace exerciciodefixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] vect = Console.ReadLine().Split();

            int idade = int.Parse(vect[1]);
            double altura = double.Parse(vect[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome}\n" +
                $"{quartos}\n" +
                $"{preco.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"{vect[0]}\n" +
                $"{idade}\n" +
                $"{altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
