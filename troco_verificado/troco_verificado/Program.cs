using System;
using System.Globalization;

namespace troco_verificado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Preço unitário do produto: ");
            float preco = float.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            int qtde = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            float recebido = float.Parse(Console.ReadLine(), CI);

            if (recebido > preco * qtde)
            {
                Console.WriteLine($"TROCO = R$ {(recebido - preco * qtde).ToString("F2", CI)}");
            }
            else
            {
                Console.WriteLine($"DINHEIRO INSUFICIENTE. FALTAM {(preco * qtde - recebido).ToString("F2", CI)} REAIS");
            }

            Console.ReadLine();
        }
    }
}
