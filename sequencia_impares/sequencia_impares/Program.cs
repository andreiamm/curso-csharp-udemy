using System;

namespace sequencia_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de X: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i+= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
