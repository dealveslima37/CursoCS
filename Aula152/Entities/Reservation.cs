using System.Text;

namespace Aula152.Entities
{
    internal class Reservation
    {

        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            var duration = Checkout.Subtract(Checkin);

            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return $"Reserva: Quarto: {RoomNumber} check-in: {Checkin.ToString("dd/MM/yyyy")} check-out: {Checkout.ToString("dd/MM/yyyy")},     " +
                $"{Duration()} noites";
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            Checkin = checkin;
            Checkout = checkout;
        }

    }
}
