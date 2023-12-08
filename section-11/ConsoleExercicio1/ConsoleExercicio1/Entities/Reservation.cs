using ConsoleExercicio1.Entities.Exceptions;

namespace ConsoleExercicio1.Entities
{
    internal class Reservation
    {

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }


        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            ValidateReservation(checkin, checkout);

            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            ValidateReservation(checkin, checkout);

            CheckIn = checkin;
            CheckOut = checkout;
        }

        private void ValidateReservation(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservas só podem ser feitas em data futuras.");
            }
            else if (checkout <= checkin)
            {
                throw new DomainException("Data de saída deve ser maior que a entrada.");
            }
        }

        public override string ToString()
        {
            return " - Quarto:"
                + RoomNumber
                + "\n"
                + " - CheckIn: "
                + CheckIn.ToString("dd/MM/yyyy")
                + "\n"
                + " - CheckOut: "
                + CheckOut.ToString("dd/MM/yyyy")
                + "\n - Total de "
                + Duration()
                + " noites";
        }
    }
}
