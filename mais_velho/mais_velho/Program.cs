using System;

namespace mais_velho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, maiorIdade;
            string maisVelho;

            Console.Write("Quantas pessoas voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dados da {i + 1}a pessoa:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            maiorIdade = idades[0];
            maisVelho = nomes[0];
            for (int i = 1; i < n; i++)
            {
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    maisVelho = nomes[i];
                }
            }

            Console.WriteLine($"PESSOA MAIS VELHA: {maisVelho}");
        }
    }
}
