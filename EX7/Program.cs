using System;

namespace EX7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [15];
            Console.WriteLine("Digite 15 números:");
            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Digite o {i+1}º número");
                numeros[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("A ordem contrária de digitação dos números inseridos é...");
            for (var i = 15; i > 1; i--)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}