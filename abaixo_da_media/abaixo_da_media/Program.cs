using System;
using System.Globalization;

namespace abaixo_da_media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos elementos vai ter o vetor? ");
            int n = int.Parse(Console.ReadLine());

            float[] vet = new float[n];
            float soma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = float.Parse(Console.ReadLine(), CI);
                soma += vet[i];
            }

            float media = soma / n;

            Console.WriteLine($"\nMEDIA DO VETOR = {media.ToString("F3", CI)}");
            Console.WriteLine("ELEMENTOS ABAIXO DA MEDIA:");
            for (int i = 0; i < n; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CI));
                }
            }
        }
    }
}
