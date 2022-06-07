using System;

namespace crescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("DECRESCENTE!");
                }
                else
                {
                    Console.WriteLine("CRESCENTE!");
                }

                Console.WriteLine("Digite outros dois numeros:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }

        }
    }
}
