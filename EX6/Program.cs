using System;

namespace EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Escreva o {i+1}º nome");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("Digite um nome para consulta");
            string nome_consulta = Console.ReadLine();
            for (var i = 0; i < 1; i++)
            {
                if (nomes[0] == nome_consulta || nomes[1] == nome_consulta || nomes[2] == nome_consulta || nomes[3] == nome_consulta || nomes[4] == nome_consulta || nomes[5] == nome_consulta || nomes[6] == nome_consulta || nomes[7] == nome_consulta || nomes[8] == nome_consulta || nomes[9] == nome_consulta)
                {
                    Console.WriteLine("ACHEI!");
                }
                else{
                    Console.WriteLine("NÃO ACHEI...");
                }
            }
            // "código do professor"
            // bool achou = false;
            // foreach (var nome in nomes)
            // {
            //     if(nome==nome_consulta){
            //         achou= true;
            //     }
            // }
            // if(!achou){
            //     Console.WriteLine("ACHEI!");
            // }
            // else{
            //     Console.WriteLine("NÃO ACHEI...");
            // }
        }
    }
}