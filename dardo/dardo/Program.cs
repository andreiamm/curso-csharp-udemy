using System;
using System.Globalization;

namespace dardo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            float maior;

            Console.WriteLine("Digite as tres distancias:");
            float d1 = float.Parse(Console.ReadLine(), CI);
            float d2 = float.Parse(Console.ReadLine(), CI);
            float d3 = float.Parse(Console.ReadLine(), CI);

            if (d1 > d2 && d1 > d3)
            {
                maior = d1;
            }
            else if (d2 > d3)
            {
                maior = d2;
            }
            else
            {
                maior = d3;
            }

            Console.WriteLine($"MAIOR DISTANCIA = {maior.ToString("F2", CI)}");

            Console.ReadLine();
        }
    }
}
