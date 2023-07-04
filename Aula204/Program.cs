using Aula204.Entities;
using Aula204.Services;

Console.WriteLine("Entre com os dados da locação");
Console.Write("Model do carro: ");
var model = Console.ReadLine();
Console.Write("Retirada (dd/MM/yyyy hh:mm): ");
var start = DateTime.Parse(Console.ReadLine()!);
Console.Write("Devolução (dd/MM/yyyy hh:mm): ");
var finish = DateTime.Parse(Console.ReadLine()!);

Console.Write("Entre com o preço por hora R$: ");
var pricePerHour = double.Parse(Console.ReadLine()!);
Console.Write("Entre com o preço por dia R$: ");
var pricePerDay = double.Parse(Console.ReadLine()!);

var vehicle = new Vehicle { Model = model };
var carRental = new CarRental(start, finish, vehicle);
var rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine("Nota");
Console.WriteLine(carRental.Invoice);





