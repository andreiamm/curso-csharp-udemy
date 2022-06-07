using System;

namespace par_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            
            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULO");
                }
                else if (x < 0)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("PAR NEGATIVO");
                    }
                    else
                    {
                        Console.WriteLine("IMPAR NEGATIVO");
                    }
                }
                else
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("PAR POSITIVO");
                    }
                    else
                    {
                        Console.WriteLine("IMPAR POSITIVO");
                    }
                }
            }
        }
    }
}
