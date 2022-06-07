using System;
using System.Globalization;

namespace soma_linhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz? ");
            int n = int.Parse(Console.ReadLine());

            float[,] mat = new float[m, n];
            float[] vet = new float[m];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Digite os elementos da {i}a. linha:");
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = float.Parse(Console.ReadLine(), CI);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    vet[i] += mat[i, j];
                }
            }

            Console.WriteLine("VETOR GERADO:");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CI));
            }
        }
    }
}
