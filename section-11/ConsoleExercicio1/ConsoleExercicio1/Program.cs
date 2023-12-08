using ConsoleExercicio1.Entities;
using ConsoleExercicio1.Entities.Exceptions;

namespace ConsoleExercicio1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("___Entre com os dado para CRIAR a reserva___");
                Console.WriteLine("Número do quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Data de entrada (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Data de saída (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine(reservation.ToString());

                Console.WriteLine();
                Console.WriteLine("___Entre com os dado para ATUALIZAR a reserva___");
                Console.WriteLine("Data de entrada (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Data de saída (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine(reservation.ToString());
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Formato inválido: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
        }
    }
}
