using System;
using System.Globalization;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de casos de teste: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Teste {i}: ");
                string[] valores = Console.ReadLine().Split();
                double val1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double val2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double val3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (val1 * 2.0 + val2 * 3.0 + val3 * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
