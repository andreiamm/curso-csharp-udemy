using System;

namespace pares_consecutivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    x++;
                }

                Console.WriteLine($"SOMA = { 5 * x + 20}");

                Console.Write("Digite um numero inteiro: ");
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
