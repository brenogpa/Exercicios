using System;
using System.Globalization;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira 4 valores:");

            int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int dif = a * b - c * d;

            Console.WriteLine("DIFERENÇA = " + dif);
        }
    }
}
