using System;
using System.Globalization;

namespace lanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            float valor = 0.0f;

            Console.Write("Codigo do produto comprado: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            int qtde = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    valor = qtde * 5.0f;
                    break;
                case 2:
                    valor = qtde * 3.5f;
                    break;
                case 3:
                    valor = qtde * 4.8f;
                    break;
                case 4:
                    valor = qtde * 8.9f;
                    break;
                case 5:
                    valor = qtde * 7.32f;
                    break;
            }

            Console.WriteLine($"Valor a pagar: R$ {valor.ToString("F2", CI)}");

            Console.ReadLine();
        }
    }
}
