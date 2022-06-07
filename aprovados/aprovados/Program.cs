using System;
using System.Globalization;

namespace aprovados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos alunos serao digitados? ");
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            float[] notas1 = new float[n];
            float[] notas2 = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite nome, primeira e segunda nota do {i + 1}o aluno:");
                nomes[i] = Console.ReadLine();
                notas1[i] = float.Parse(Console.ReadLine(), CI);
                notas2[i] = float.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < n; i++)
            {
                if ((notas1[i] + notas2[i]) / 2.0f >= 6.0f)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
