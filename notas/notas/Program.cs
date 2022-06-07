using System;
using System.Globalization;

namespace notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"NOTA FINAL = {(nota1 + nota2).ToString("F1", CI)}");

            if (nota1 + nota2 < 60.0f){
                Console.WriteLine("REPROVADO");
            }

            Console.ReadLine();
        }
    }
}
