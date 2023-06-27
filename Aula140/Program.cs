using Aula140.Entities;

Console.Write("Entre com o número de funcionários: ");
var n = int.Parse(Console.ReadLine()!);

List<Employee> employees = new();

for (var i = 1; i <= n; i++)
{
    Console.WriteLine($"Dados do {i}º funcionário");
    Console.Write($"Funcionário Tercerizado (s/n)?: ");
    var op = Console.ReadLine()!.ToLower();
    Console.Write("Nome: ");
    var name = Console.ReadLine()!;
    Console.Write("Horas: ");
    var hours = int.Parse(Console.ReadLine()!);
    Console.Write("Valor por hora R$: ");
    var valuePerHour = double.Parse(Console.ReadLine()!);
    if (op.StartsWith("s"))
    {
        Console.Write("Despesa adicinal R$: ");
        var additionalCharge = double.Parse(Console.ReadLine()!);
        Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
        employees.Add(employee);
    }
    else
    {
        Employee employee = new Employee(name, hours, valuePerHour);
        employees.Add(employee);
    }
}

Console.WriteLine();
Console.WriteLine("Pagamentos");
foreach (var emp in employees)
{
    Console.WriteLine(emp);
}