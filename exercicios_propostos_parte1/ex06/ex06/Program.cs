using System;
using System.Globalization;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangulo, circulo, trapezio, quadrado, retangulo, A, B, C;

            Console.WriteLine("Insira valores pros pontos A, B e C respectivamente:");
            string[] valores = Console.ReadLine().Split();

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("Triangulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture) + 
                "\nCirculo: " + circulo.ToString("F3", CultureInfo.InvariantCulture) + 
                "\nTrapezio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture) + 
                "\nQuadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture) + 
                "\nRetangulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
