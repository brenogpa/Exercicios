using System;
using System.Globalization;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qtd1, qtd2;
            float preco1, preco2, total;

            Console.WriteLine("Item 1: Insira o código / quantidade / e valor unitário:");
            string[] item1 = Console.ReadLine().Split();                              
                                                                                      
            Console.WriteLine("Item 2: Insira o código / quantidade / e valor unitário:");
            string[] item2 = Console.ReadLine().Split();

            cod1 = int.Parse(item1[0]);
            cod2 = int.Parse(item2[0]);
            qtd1 = int.Parse(item1[1]);
            qtd2 = int.Parse(item2[1]);
            preco1 = float.Parse(item1[2], CultureInfo.InvariantCulture);
            preco2 = float.Parse(item2[2], CultureInfo.InvariantCulture);

            total = preco1 * qtd1 + preco2 * qtd2;

            Console.WriteLine("Total a pagar: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
