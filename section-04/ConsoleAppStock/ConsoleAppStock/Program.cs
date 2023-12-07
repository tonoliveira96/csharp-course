using System;
using System.Globalization;

namespace ConsoleAppStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();  

            Console.WriteLine("Entre os dados do produto:");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque:");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado: ");
            int add = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(add);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o número de produtos  a ser removido: ");
            int del = int.Parse(Console.ReadLine());
            p.RemoverProdutos(del);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
