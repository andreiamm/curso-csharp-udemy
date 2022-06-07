using System;
using System.Globalization;

namespace retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Base do retangulo: ");
            float b = float.Parse(Console.ReadLine(), CI);
            Console.Write("Altura do retangulo: ");
            float h = float.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"AREA = {(b * h).ToString("F4", CI)}");
            Console.WriteLine($"PERIMETRO = {(2 * (b + h)).ToString("F4", CI)}");
            Console.WriteLine($"DIAGONAL = {(Math.Sqrt(Math.Pow(b,2) + Math.Pow(h,2))).ToString("F4", CI)}");

            Console.Read();
        }
    }
}
