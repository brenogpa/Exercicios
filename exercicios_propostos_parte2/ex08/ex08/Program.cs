using System;
using System.Globalization;

namespace ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa. 
            //  Em seguida, calcule e mostre o valor que esta pessoa deve pagar de 
            //  Imposto de Renda, segundo a tabela abaixo.

            //  |            RENDA                | IMPOSTO DE RENDA|
            //  | de 0.00 a $ 2000.00             |      ISENTO     |
            //  | de $ 2000.01 até $ 3000.00      |        8%       |
            //  | de $ 3000.01 até $ 4500.00      |       18%       |
            //  | acima de $ 4500.00              |       28%       |

            //  Lembre que, se o salário for $ 3002.00, a taxa que incide é de 8% apenas sobre $ 1000.00, 
            //  pois a faixa de salário que fica de $ 0.00 até $ 2000.00 é isenta de Imposto de Renda.
            //  Nesse exemplo, a taxa é de 8% sobre $ 1000.00 + 18% sobre $ 2.00,
            //  o que resulta em $ 80.36 no total. O valor deve ser impresso comduas casas decimais.

            double renda, total;

            Console.WriteLine("Insira o salário:");
            renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (renda <= 2000.00)
            {
                total = 0.00;
            }
            else if (renda <= 3000.00)
            {
                total = (renda - 2000.00) * 0.08;
            }
            else if (renda <= 4500.00)
            {
                total = (renda - 3000.00) * 0.18 + 80;
            }
            else
            {
                total = (renda - 4500) * 0.28 + 80 + 270;
            }

            if (total == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
