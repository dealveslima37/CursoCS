using Aula154.Entities;
using Aula154.Exceptions;

Console.Write("Número do quarto: ");
var roomNumber = int.Parse(Console.ReadLine()!);
Console.Write("Data de entrada (dd/MM/yyyy): ");
var checkin = DateTime.Parse(Console.ReadLine()!);
Console.Write("Data de saída (dd/MM/yyyy): ");
var checkout = DateTime.Parse(Console.ReadLine()!);

try
{
    var reservation = new Reservation(roomNumber, checkin, checkout);
    Console.WriteLine(reservation);

    Console.WriteLine();
    Console.WriteLine("Entre com os dados para atualizar a reserva");
    Console.Write("Data de entrada (dd/MM/yyyy): ");
    checkin = DateTime.Parse(Console.ReadLine()!);
    Console.Write("Data de saída (dd/MM/yyyy): ");
    checkout = DateTime.Parse(Console.ReadLine()!);

    reservation.UpdateDates(checkin, checkout);

    Console.WriteLine(reservation);

}
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}

