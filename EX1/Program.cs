using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano_atual = DateTime.Now.Year;
            Console.WriteLine("Em que ano você nasceu?");
            int ano_nasc = int.Parse(Console.ReadLine());
            int idade = ano_atual - ano_nasc;
            if (idade <=15){
                Console.WriteLine("Ainda não há idade para votar.");
            }
            else if(idade >=18 && idade <=70){
                Console.WriteLine("O voto é obrigatório.");
            }
            else{
                Console.WriteLine("O voto é opcional.");
            }
        }
    }
}