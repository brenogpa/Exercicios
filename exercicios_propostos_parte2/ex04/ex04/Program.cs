using System;
using System.Globalization;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a hora inicial e a hora final do jogo:");
            string[] hour = Console.ReadLine().Split();

            int start = int.Parse(hour[0]);
            int end = int.Parse(hour[1]);

            int time;

            if (start < end)
            {
                time = end - start;
            }
            else
            {
                time = 24 - start + end;
            }

            Console.WriteLine("Duração do jogo: " + time + "h");
        }
    }
}
