using System;
using System.Globalization;

namespace media_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, qtdePares, somaPares;

            Console.Write("Quantos elementos vai ter o vetor? ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            qtdePares = 0;
            somaPares = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());

                if (vet[i] % 2 == 0)
                {
                    qtdePares++;
                    somaPares += vet[i];
                }
            }

            if (qtdePares == 0)
            {
                Console.WriteLine("NENHUM NUMERO PAR");
            }
            else
            {
                Console.WriteLine($"MEDIA DOS PARES = {((float)somaPares / qtdePares).ToString("F1", CI)}");
            }
        }
    }
}
