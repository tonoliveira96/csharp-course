using ConsoleInterface.Entities;
using System.Globalization;

namespace ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel: ");
            Console.WriteLine("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.WriteLine("Retirada (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyy hh:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Devolução (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyy hh:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model)); 
        }
    }
}