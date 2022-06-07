using System;
using System.Globalization;

namespace operadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a quantidade de minutos: ");
            int minutos = int.Parse(Console.ReadLine());

            float cobranca = 50.0f;
            if (minutos > 100)
            {
                cobranca += (minutos - 100) * 2.0f;
            }

            Console.WriteLine($"Valor a pagar: R$ {cobranca.ToString("F2", CI)}");

            Console.ReadLine();
        }
    }
}
