using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            Fazer um programa para ler um número inteiro N e depois os dados(id, nome e salario) de
            N funcionários.Não deve haver repetição de id.
            Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            Para isso, o programa deve ler um id e o valor X.Se o id informado não existir, mostrar uma
            mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
            conforme exemplos.
            Lembre - se de aplicar a técnica de encapsulamento para não permitir que o salário possa
              ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
            aumento por porcentagem dada.
            **/

            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered?: ");
            int qty = int.Parse(Console.ReadLine());

            for (int emp = 1; emp <= qty; emp++)
            {
                Console.WriteLine($"\nEmployee #{emp}: ");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: $");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee foundId = employees.Find(id => id.Id == searchId);
            if (foundId != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                foundId.SalaryIncrease(percentage);
            }
            else
            {
                Console.WriteLine("\nThis id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
