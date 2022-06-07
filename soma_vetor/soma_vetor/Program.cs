using System;
using System.Globalization;

namespace soma_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos numeros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            float[] vet = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = float.Parse(Console.ReadLine(), CI);
            }

            float soma = 0;
            Console.WriteLine();
            Console.Write("VALORES =");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + vet[i].ToString("F1", CI));
                soma += vet[i];
            }
            
            Console.WriteLine();
            Console.WriteLine($"SOMA = {soma.ToString("F2", CI)}");
            Console.WriteLine($"MEDIA = {(soma / n).ToString("F2", CI)}");
        }
    }
}
