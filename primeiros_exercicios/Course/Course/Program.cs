using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  EXERCÍCIO 01
            
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.Write("PRIMEIRA PESSOA \n Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.Write("SEGUNDA PESSOA \n Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }
            */

            //   EXERCÍCIO 02

            Funcionario x1 = new Funcionario();
            Funcionario x2 = new Funcionario();

            Console.Write("PRIMEIRO FUNCIONÁRIO \n Nome: ");
            x1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            x1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("SEGUNDO FUNCIONÁRIO \n Nome: ");
            x2.Nome = Console.ReadLine();
            Console.Write("Sálario: ");
            x2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (x1.Salario + x2.Salario) / 2;
            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
