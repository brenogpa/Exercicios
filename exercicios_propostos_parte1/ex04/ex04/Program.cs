using System;
using System.Globalization;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número do funcionário:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de horas trabalhadas:");
            int hour = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor que recebe por hora: ");
            float valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float salary = valor * hour;

            Console.WriteLine("Number: " + num +
                "\nSalary: U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
