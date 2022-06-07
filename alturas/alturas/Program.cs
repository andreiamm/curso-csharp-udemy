using System;
using System.Globalization;

namespace alturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            float somaAlturas;
            int n, menores16;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];
            float[] alturas = new float[n];

            somaAlturas = 0;
            menores16 = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dados da {i + 1}a pessoa:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                alturas[i] = float.Parse(Console.ReadLine(), CI);

                somaAlturas += alturas[i];

                if (idades[i] < 16)
                {
                    menores16++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Altura média: {(somaAlturas / n).ToString("F2", CI)}");
            Console.WriteLine($"Pessoas com menos de 16 anos: {(menores16 * 100.0f / n).ToString("F1", CI)}%");

            for (int i = 0; i < n; i++)
            {
                if (idades[i] < 16)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
