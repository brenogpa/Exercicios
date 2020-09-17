using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            /**  Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
                 uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
                 que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
                 para ser responsável pelos cálculos.
            **/
            Console.Write("Qual é a cotação do dólar?: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?: ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.ValorTotal(cotacao, qtd);

            Console.Write("Valor a ser pago em reais: R$ " + total.ToString("F2", CultureInfo.InvariantCulture)) ;
        }
    }
}
