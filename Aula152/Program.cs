using Aula152.Entities;

Console.Write("Número do quarto: ");
var roomNumber = int.Parse(Console.ReadLine()!);
Console.Write("Data do check-in (dd/MM/yyyy): ");
var checkin = DateTime.Parse(Console.ReadLine()!);
Console.Write("Data de check-out (dd/MM/yyyy): ");
var checkout = DateTime.Parse(Console.ReadLine()!);

if (checkout <= checkin)
{
    Console.WriteLine("Erro na reserva: Data de saída deve ser superior a data de entrada");
}
else
{
    var reservation = new Reservation(roomNumber, checkin, checkout);
    Console.WriteLine("Reserva: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Entre com os dados para atualizar a reserva");
    Console.Write("Data do check-in (dd/MM/yyyy): ");
    checkin = DateTime.Parse(Console.ReadLine()!);
    Console.Write("Data de check-out (dd/MM/yyyy): ");
    checkout = DateTime.Parse(Console.ReadLine()!);

    DateTime now = DateTime.Now;

    if (checkin < now || checkout < now)
    {
        Console.WriteLine("Erro na reserva: Datas para atualização devem ser datas futuras");
    }
    else if (checkout <= checkin)
    {
        Console.WriteLine("Erro na reserva: Data de saída deve ser superior a data de entrada");
    }
    else
    {
        reservation.UpdateDates(checkin, checkout);
        Console.WriteLine("Reservation: " + reservation);
    }
}



