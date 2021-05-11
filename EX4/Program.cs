using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            Console.WriteLine("Digite dez números");
            Console.WriteLine();
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Console.WriteLine();
            Console.WriteLine($"O maior número é o {numeros[numeros.Length-1]} e o menor número é o {numeros[0]}");
        }
    }
}
