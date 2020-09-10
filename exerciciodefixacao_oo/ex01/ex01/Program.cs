using System;
using System.Globalization;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.Write("Insira as medidas do Retângulo \n Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write(" Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture) +
                "\nPERÍMETRO: " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture) +
                "\nDIAGONAL: " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
