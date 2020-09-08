using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
            incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
            */

            Console.Write("Password: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida");
                Console.Write("Password: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.Write("Acesso Permitido");
        }
    }
}
