using System;
using System.Globalization;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Cachorro Quente R$4.00
            //2. X-Salada R$4.50
            //3. X-Bacon R$5.00
            //4. Torrada simples R$2.00
            //5. Refrigerante R$1.50

            Console.WriteLine("Insira o código do produto seguido da quantidade:");
            string[] item = Console.ReadLine().Split();

            double total, qtd, cod;

            cod = double.Parse(item[0]);
            qtd = double.Parse(item[1]);
            total = 0;

            if (cod == 1.0)
            {
                total = qtd * 4.00;
            }
            else if(cod == 2.0)
            {
                total = qtd * 4.50;
            }
            else if(cod == 3.0)
            {
                total = qtd * 5.00;
            }
            else if (cod == 4.0)
            {
                total = qtd * 2.00;
            }
            else if (cod == 5.0)
            {
                total = qtd * 1.50;
            }

            Console.WriteLine("Total: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
