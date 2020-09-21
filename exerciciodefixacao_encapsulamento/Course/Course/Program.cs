using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
             titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
             inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
             conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
             Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
             o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
             exemplo).
             Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
             isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
             realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
             suficiente para realizar o saque e/ou pagar a taxa.
             Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
             informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
             mostrando os dados da conta após cada operação.
            */

            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?: ");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }

            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da conta: \n" + conta.ToString());

            Console.Write("\nEntre um valor para deposito: $ ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta Atualizados: \n" + conta.ToString());

            Console.Write("\nEntre um valor para saque: $ ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta Atualizados: \n" + conta.ToString());
        }
    }
}
