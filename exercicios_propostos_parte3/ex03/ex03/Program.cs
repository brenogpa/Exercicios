using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 
            1.Álcool    2.Gasolina   3.Diesel    4.Fim). 
            Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.
            */
            Console.Write(" 1. Álcool\n 2. Gasolina \n 3. Diesel \n 4. Fim \n Insira o código: ");
            int num = int.Parse(Console.ReadLine());
            int diesel = 0;
            int gasolina = 0;
            int alcool = 0;

            while (num != 4)
            {
                if (num == 1)
                {
                    alcool ++;
                }
                else if (num == 2)
                {
                    gasolina ++;
                }
                else if (num == 3)
                {
                    diesel ++;
                }
                else
                {
                    Console.WriteLine("Código Inválido");
                }

                Console.Write("Insira o Código: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado" + 
                "\n Álcool: " + alcool +
                "\n Gasolina: " + gasolina +
                "\n Diesel: " + diesel);
        }
    }
}
