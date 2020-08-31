using System;
using System.Globalization;

namespace exerciciodefixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:\n" +
                produto1 + ": R$" + preco1.ToString("F2") + "\n" +
                produto2 + ": R$" + preco2.ToString("F2") + "\n");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine("\nMedida com oito casas decimais: " + medida.ToString("F8") +
                "\nArredondado (três casas decimais): " + medida.ToString("F3") + 
                "\nSeparador decimal invariante culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
