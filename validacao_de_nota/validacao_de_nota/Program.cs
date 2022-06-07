using System;
using System.Globalization;

namespace validacao_de_nota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a primeira nota: ");
            float n1 = float.Parse(Console.ReadLine(), CI);

            while (n1 < 0.0f || n1 > 10.0f)
            {
                Console.Write("Valor invalido! Tente novamente: ");
                n1 = float.Parse(Console.ReadLine(), CI);
            }

            Console.Write("Digite a segunda nota: ");
            float n2 = float.Parse(Console.ReadLine(), CI);

            while (n2 < 0.0f || n2 > 10.0f)
            {
                Console.Write("Valor invalido! Tente novamente: ");
                n2 = float.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine($"MEDIA = {((n1 + n2) / 2.0f).ToString("F2", CI)}");
        }
    }
}
