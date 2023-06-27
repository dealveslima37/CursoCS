using Aula129.Entities;
using Aula129.Entities.Enums;

Console.Write("Entre com o nome do departamento: ");
var department = Console.ReadLine();
Console.WriteLine("Entre com os dados do trabalhador");
Console.Write("Nome: ");
var name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
var level = Console.ReadLine();
Console.Write("Salário Base R$: ");
var baseSalary = double.Parse(Console.ReadLine()!);

Console.Write("Quantos contratos para esse trabalhador? ");
var numberOfContracts = int.Parse(Console.ReadLine()!);

var worker = new Worker(name, Enum.Parse<WorkerLevel>(level!), baseSalary, new Department(department));

for (var i = 0; i < numberOfContracts; i++)
{
    Console.Write($"Entre com os dados do {i + 1}º contrato");
    Console.Write("Data (DD/MM/YYY): ");
    var date = DateTime.Parse(Console.ReadLine()!);
    Console.Write("Valor por hora R$: ");
    var valuePerHour = double.Parse(Console.ReadLine()!);
    Console.Write("Duração: ");
    var hours = int.Parse(Console.ReadLine()!);

    worker.AddContract(new HourContract { Date = date, ValuePerHour = valuePerHour, Hours = hours });
}

Console.Write("Entre com o mês e o ano para calculo da renda  (MM/YYYY): ");
var monthAndYear = Console.ReadLine()?.Split("/");
var month = int.Parse(monthAndYear![0]);
var year = int.Parse(monthAndYear![1]);

var income = worker.Income(year, month);

Console.WriteLine(
    $"Nome: {worker.Name}\nDepartamento: {worker.Department.Name} \nRenda para {month}/{year}: {income.ToString("F2")}");