using ConsoleGenerics.Entities;
using ConsoleGenerics.Services;
using System.Globalization;

namespace ConsoleGenerics
{
    class Program
    {
        static void Main(string[] args)

        {
            PrintService<Product> printService = new PrintService<Product>();
            Console.Write("Quantos valores você vai digitar: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(",");
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                
                list.Add(new Product(name, price));
            }
            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(list);

            Console.WriteLine("Primeiro: " + max);
        }
    }
}
