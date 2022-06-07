using System;
using System.Globalization;

namespace consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Distancia percorrida: ");
            int distancia = int.Parse(Console.ReadLine());
            Console.Write("Combustível gasto: ");
            float combustivel = float.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"Consumo medio = {(distancia / combustivel).ToString("F3", CI)}");

            Console.ReadLine();
        }
    }
}
