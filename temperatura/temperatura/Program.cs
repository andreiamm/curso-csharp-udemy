using System;
using System.Globalization;

namespace temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            float f, c;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            char escala = char.Parse(Console.ReadLine());

            if (escala == 'F' || escala == 'f')
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                f = float.Parse(Console.ReadLine(), CI);

                c = 5.0f / 9.0f * (f - 32.0f);

                Console.WriteLine($"Temperatura equivalente em Celsius: {c.ToString("F2", CI)}");
            }
            else
            {
                Console.Write("Digite a temperatura em Celsius: ");
                c = float.Parse(Console.ReadLine(), CI);

                f = 9.0f * c / 5.0f + 32.0f;

                Console.WriteLine($"Temperatura equivalente em Fahrenheit: {f.ToString("F2", CI)}");
            }

            Console.ReadLine();
        }
    }
}
