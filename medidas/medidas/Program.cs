using System;
using System.Globalization;

namespace medidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a medida A: ");
            float a = float.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida B: ");
            float b = float.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida C: ");
            float c = float.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"AREA DO QUADRADO = {(Math.Pow(a, 2)).ToString("F4", CI)}");
            Console.WriteLine($"AREA DO TRIANGULO = {(a * b / 2.0f).ToString("F4", CI)}");
            Console.WriteLine($"AREA DO TRAPEZIO = {((a + b) / 2.0f * c).ToString("F4", CI)}");

            Console.ReadLine();
        }
    }
}
