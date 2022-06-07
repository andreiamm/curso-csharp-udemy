using System;
using System.Globalization;

namespace experiencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, qtdeCobaias, coelhos, ratos, sapos, total;
            char tipoCobaia;

            Console.Write("Quantos casos de teste serao digitados? ");
            n = int.Parse(Console.ReadLine());

            coelhos = 0;
            ratos = 0;
            sapos = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Quantidade de cobaias: ");
                qtdeCobaias = int.Parse(Console.ReadLine());
                Console.Write("Tipo de cobaia: ");
                tipoCobaia = char.Parse(Console.ReadLine());

                switch (tipoCobaia)
                {
                    case 'C':
                    case 'c': 
                        coelhos += qtdeCobaias;
                        break;
                    case 'R':
                    case 'r':
                        ratos += qtdeCobaias;
                        break;
                    case 'S':
                    case 's':
                        sapos += qtdeCobaias;
                        break;
                }
            }

            total = coelhos + ratos + sapos;

            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL:");
            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {(coelhos * 100.0f / total).ToString("F2", CI)}");
            Console.WriteLine($"Percentual de ratos: {(ratos * 100.0f / total).ToString("F2", CI)}");
            Console.WriteLine($"Percentual de sapos: {(sapos * 100.0f / total).ToString("F2", CI)}");
        }
    }
}
