using Aula154.Exceptions;

namespace Aula154.Entities
{
    internal class Reservation
    {

        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {

            if (checkout <= checkin)
            {
                throw new DomainException("A data de entrada não pode ser superior a data de saída");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            var duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {

            var now = DateTime.Now;

            if (checkin <= now || checkout <= now)
            {
                throw new DomainException("Erro na reserva: Digite datas futuras");
            }
            else if (checkout <= checkin)
            {
                throw new DomainException("A data de entrada não pode ser superior a data de saída");
            }

            Checkin = checkin;
            Checkout = checkout;

        }

        public override string ToString()
        {
            return $"Reserva: Quarto {RoomNumber}, Check-in: {Checkin.ToString("dd/MM/yyyy")}, check-out: {Checkout.ToString("dd/MM/yyyy")}, " +
                $"{Duration()} noites";
        }

    }
}
