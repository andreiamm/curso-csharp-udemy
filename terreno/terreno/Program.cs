using System;
using System.Globalization;

namespace terreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a largura do terreno: ");
            float largura = float.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o comprimento do terreno: ");
            float comprimento = float.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o valor do metro quadrado: ");
            float valorM2 = float.Parse(Console.ReadLine(), CI);

            float area = largura * comprimento;
            float preco = area * valorM2;

            Console.WriteLine($"Area do terreno = {area.ToString("F2", CI)}");
            Console.WriteLine($"Preco do terreno = {preco.ToString("F2", CI)}");

            Console.Read();
        }
    }
}
