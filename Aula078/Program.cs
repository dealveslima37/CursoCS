using Aula078;
using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.Write("Quantos funcionários serão registrados? ");
var n = int.Parse(Console.ReadLine()!);

List<Employee> employees = new();

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Funcionário #{i + 1}");
    while (true)
    {
        Console.Write("Id: ");
        var id = int.Parse(Console.ReadLine()!);
        if (employees.Find(x => x.Id == id) != null)
        {
            Console.WriteLine("Id já existente. Digite um Id diferente.");

        }
        else
        {
            Console.Write("Nome: ");
            var name = Console.ReadLine()!;
            Console.Write("Salário R$: ");
            var salary = double.Parse(Console.ReadLine()!, locale);

            employees.Add(new Employee(id, name, salary));
            break;
        }

    }
}

Console.WriteLine();
employees.ForEach(e => Console.WriteLine(e));

Console.Write("Entre com o id do funcionário que terá aumento: ");
var idEmp = int.Parse((Console.ReadLine()!));

var emp = employees.Find(x => x.Id == idEmp);

if (emp != null)
{
    Console.Write("Entre com a porcentagem: ");
    var percentage = double.Parse(Console.ReadLine()!, locale);
    emp.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("Id inexistente");
}

Console.WriteLine();
Console.WriteLine("Lista Atualizada de funcionários");
employees.ForEach((e) => Console.WriteLine(e));