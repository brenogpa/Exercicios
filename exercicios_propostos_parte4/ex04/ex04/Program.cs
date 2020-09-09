using System;
using System.Globalization;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
            */

            int n = int.Parse(Console.ReadLine());
            double total;

            for (int c = 1; c <= n; c++)
            {
                string[] valores = Console.ReadLine().Split();
                double v0 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double v1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

                if (v1 == 0)
                {
                    Console.WriteLine("Divisão Impossível");
                }
                else
                {
                    total = v0 / v1;
                    Console.WriteLine(total.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
