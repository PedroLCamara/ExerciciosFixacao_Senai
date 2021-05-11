using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual nome do produto?");
            string nome= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Qual a quantidade de produtos adquirida?");
            float quantidade= float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Qual o preço por unidade?");
            float preco_unidade= float.Parse(Console.ReadLine());
            float preco= preco_unidade * quantidade;
            Console.WriteLine();
            if(quantidade<=5){
                Console.WriteLine($"O preço do lote de {quantidade} itens do produto {nome}, com um desconto de 2%, é igual a {(preco*0.98).ToString("N2")}");
            }
            else if(quantidade<=10){
                Console.WriteLine($"O preço do lote de {quantidade} itens do produto {nome}, com um desconto de 3%, é igual a {(preco*0.97).ToString("N2")}");
            } 
            else{
                Console.WriteLine($"O preço do lote de {quantidade} itens do produto {nome}, com um desconto de 5%, é igual a {(preco*0.95).ToString("N2")}");
            }
        }
    }
}