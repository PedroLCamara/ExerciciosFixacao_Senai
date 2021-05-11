using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool denovo= false;
            do
            {
                
            Console.WriteLine("Qual combustível você deseja? (A/G)");
            string combustivel = Console.ReadLine().ToUpper();
            double litros;
            double valor;
            Console.WriteLine();
            switch (combustivel)
            {
                case "A":
                    denovo= false;
                    Console.WriteLine("Qual a quantidade de álcool em litros desejada?");
                    litros= double.Parse(Console.ReadLine());
                    valor= litros*4.90;
                    Console.WriteLine();
                    if(litros <=20){
                        Console.WriteLine($"O valor a ser pago é igual a R${(valor-(3*(valor/100))).ToString("N2")}");
                    }
                    else{
                        Console.WriteLine($"O valor a ser pago é igual a R${(valor-(5*(valor/100))).ToString("N2")}");
                    }
                    break;
                case "G":
                    denovo= false;
                    Console.WriteLine("Qual a quantidade de álcool em litros desejada?");
                    litros= double.Parse(Console.ReadLine());
                    valor= litros*5.30;
                    Console.WriteLine();
                    if(litros <=20){
                        Console.WriteLine($"O valor a ser pago é igual a R${(valor-(4*(valor/100))).ToString("N2")}");
                    }
                    else{
                        Console.WriteLine($"O valor a ser pago é igual a R${(valor-(6*(valor/100))).ToString("N2")}");
                    }
                    break;
                default:
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Erro 001: Opção inválida, digite 'A' para álcool e 'G' para gasolina");
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.WriteLine();
                    denovo= true;
                    break;
                }   
            } while (denovo==true);
        }
    }
}