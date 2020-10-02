using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            Fazer um programa para ler dois números inteiros M e N, e depois ler
            uma matriz de M linhas por N colunas contendo números inteiros,
            podendo haver repetições. Em seguida, ler um número inteiro X que
            pertence à matriz. Para cada ocorrência de X, mostrar os valores à
            esquerda, acima, à direita e abaixo de X, quando houver.
            **/

            Console.Write("Insira o número de linhas e colunas:");
            string[] linhaEcoluna = Console.ReadLine().Split(' ');

            int m = int.Parse(linhaEcoluna[0]);
            int n = int.Parse(linhaEcoluna[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Insira a {i+1}ª linha:");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(string.Format("{0}\t ", mat[i, j]));
                }
                Console.WriteLine();
            }

            Console.Write("Escolha um número da matriz: ");
            int choice = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == choice)
                    {
                        Console.WriteLine($"Position {i}, {j}:");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }

                    }
                }
            }

        }
    }
}