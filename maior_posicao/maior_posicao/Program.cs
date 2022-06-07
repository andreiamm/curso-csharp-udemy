using System;
using System.Globalization;

namespace maior_posicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, posicaoMaior;
            float maiorValor;

            Console.Write("Quanto numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            float[] vet = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = float.Parse(Console.ReadLine(), CI); 
            }

            maiorValor = vet[0];
            posicaoMaior = 0;
            for (int i = 1; i < n; i++)
            {
                if (vet[i] > maiorValor)
                {
                    maiorValor = vet[i];
                    posicaoMaior = i;
                }
            }

            Console.WriteLine($"\nMAIOR VALOR = {maiorValor.ToString("F1", CI)}");
            Console.WriteLine($"POSICAO DO MAIOR VALOR = {posicaoMaior}");
        }
    }
}
