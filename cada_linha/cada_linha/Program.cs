using System;

namespace cada_linha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a ordem da matriz? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA: ");
            for (int i = 0; i < n; i++)
            {
                int maior = mat[i, 0];
                for (int j = 1; j < n; j++)
                {
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}
