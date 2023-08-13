using Aula242.Entities;

List<Employee> employeeList = new List<Employee>
        {
            new Employee("Maria", "maria@gmail.com", 3200.00),
            new Employee("Alex", "alex@gmail.com", 1900.00),
            new Employee("Marco", "marco@gmail.com", 1700.00),
            new Employee("Bob", "bob@gmail.com", 3500.00),
            new Employee("Anna", "anna@gmail.com", 2800.00)
        };

Console.Write("Informe o salário R$: ");
var salary = Double.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine($"Funcionários que ganham mais de {salary.ToString("F2")}");
employeeList
    .Where(p => p.Salary > salary)
    .Select(p => new { p.Email })
    .OrderBy(p => p.Email)
    .ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine();
var sum = employeeList.Where(e => e.Name!.StartsWith("M")).Select(p => p.Salary).Sum();
Console.WriteLine($"Soma do salário das pessoas que começam com a letra M = {sum.ToString("F2")}");




