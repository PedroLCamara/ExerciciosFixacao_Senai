using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada:");
            Console.WriteLine();
            for (var i = 0; i < 10; i++)
            {
                    Console.WriteLine("==============================");

                    Console.WriteLine($"{(i+1)} x 1 = {(1*(i+1))}");
                
                    Console.WriteLine($"{(i+1)} x 2 = {(2*(i+1))}");
               
                    Console.WriteLine($"{(i+1)} x 3 = {(3*(i+1))}");
               
                    Console.WriteLine($"{(i+1)} x 4 = {(4*(i+1))}");
               
                    Console.WriteLine($"{(i+1)} x 5 = {(5*(i+1))}");
                
                    Console.WriteLine($"{(i+1)} x 6 = {(6*(i+1))}");
                
                    Console.WriteLine($"{(i+1)} x 7 = {(7*(i+1))}");
                
                    Console.WriteLine($"{(i+1)} x 8 = {(8*(i+1))}");
                
                    Console.WriteLine($"{(i+1)} x 9 = {(9*(i+1))}");
                
                    Console.WriteLine($"{(i+1)} x 10 = {(10*(i+1))}");
            }
            //Código do professor:
            // for (var i = 0; i < 11; i++)
            // {
            //     for (var c = 0; c < 11; c++)
            //     {
            //         Console.WriteLine($"{i}x{c}={i*c}");
            //     }
            // }
        }
    }
}
