using System;

namespace fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, fatorial;

            Console.Write("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine());

            fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"FATORIAL = {fatorial}");
        }
    }
}
