using System;

namespace menor_de_tres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            int n3 = int.Parse(Console.ReadLine());
            
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine($"MENOR = {n1}");
            }
            else if (n2 < n3)
            {
                Console.WriteLine($"MENOR = {n2}");
            }
            else
            {
                Console.WriteLine($"MENOR = {n3}");
            }

            Console.ReadLine();
        }
    }
}
