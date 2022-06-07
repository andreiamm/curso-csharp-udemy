using System;


namespace multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros inteiros:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("Sao multiplos");
            }
            else {
                Console.WriteLine("Nao Sao multiplos");
            }

            Console.ReadLine();
        }
    }
}
