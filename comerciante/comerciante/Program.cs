using System;
using System.Globalization;

namespace comerciante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI  = CultureInfo.InvariantCulture;

            int n, lucroMenor, lucroEntre, lucroMaior;
            float compraTotal, vendaTotal;

            Console.Write("Serao digitados dados de quantos produtos? ");
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            float[] precosCompra = new float[n];
            float[] precosVenda = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Produto {i + 1}:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Preco de compra: ");
                precosCompra[i] = float.Parse(Console.ReadLine(), CI);
                Console.Write("Preco de venda: ");
                precosVenda[i] = float.Parse(Console.ReadLine(), CI);
            }

            lucroMenor = 0;
            lucroEntre = 0;
            lucroMaior = 0;
            compraTotal = 0;
            vendaTotal = 0;
            for (int i = 0; i < n; i++)
            {
                float lucro = (precosVenda[i] - precosCompra[i]) / precosCompra[i];
                if (lucro < 0.1f)
                {
                    lucroMenor++;
                }
                else if (lucro < 0.2f)
                {
                    lucroEntre++;
                } 
                else
                {
                    lucroMaior++;
                }

                compraTotal += precosCompra[i];
                vendaTotal += precosVenda[i];
            }

            Console.WriteLine("\nRELATORIO:");
            Console.WriteLine($"Lucro abaixo de 10%: {lucroMenor}");
            Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntre}");
            Console.WriteLine($"Lucro acima de 20%: {lucroMaior}");
            Console.WriteLine($"Valor total de compra: {compraTotal.ToString("F2", CI)}");
            Console.WriteLine($"Valor total de venda: {vendaTotal.ToString("F2",CI)}");
            Console.WriteLine($"Lucro total: {(vendaTotal - compraTotal).ToString("F2",CI)}");
        }
    }
}
