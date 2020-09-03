using System;
using System.Globalization;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Você deve fazer um programa que leia um valor qualquer e 
            //    apresente uma mensagem dizendo em qual dos seguintes intervalos
            //    ([0, 25], (25, 50], (50, 75], (75, 100]) este valor se encontra.
            //    Obviamente se o valor não estiver em nenhum destes intervalos,
            //    deverá ser impressa a mensagem “Fora de intervalo”.


            Console.WriteLine("Insira o valor(c/ 2 casas decimais):");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string intervalo = "";

            if (valor >= 0.00 && valor <= 25.00)
            {
                intervalo = "[0,25]";
            }
            else if (valor > 25.00 && valor <= 50.00)
            {
                intervalo = "(25,50]";
            }
            else if (valor > 50.00 && valor <= 75.00)
            {
                intervalo = "(50,75]";
            }
            else if (valor > 75.00 && valor <= 100.00)
            {
                intervalo = "(75,100]";
            }
            else
            {
                intervalo = "Fora de intervalo";
            }

            Console.WriteLine("Intervalo: " + intervalo);
        }
    }
}
