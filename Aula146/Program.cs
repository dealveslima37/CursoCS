using Aula146.Entities;

Console.Write("Digite o número de contribuintes: ");
var n = int.Parse(Console.ReadLine()!);

List<TaxPayer> payers = new();

for (var i = 0; i < n; i++)
{
    Console.WriteLine($"Dados do {i + 1}º contribuinte ");
    Console.Write("Física ou Juridica (f/j): ");
    var option = Console.ReadLine()!.ToLower();
    Console.Write("Nome: ");
    var name = Console.ReadLine()!;
    Console.Write("Renda anual R$: ");
    var anualIncome = double.Parse(Console.ReadLine()!);
    if (option.StartsWith("f"))
    {
        Console.Write("Despesas Médicas R$: ");
        var healthExpenditures = double.Parse(Console.ReadLine()!);

        payers.Add(new Individual(name, anualIncome, healthExpenditures));
    }
    else if (option.StartsWith("j"))
    {
        Console.Write("Número de funcionários: ");
        var numberOfEmployees = int.Parse(Console.ReadLine()!);

        payers.Add(new Company(name, anualIncome, numberOfEmployees));
    }
}

Console.WriteLine();
Console.WriteLine("Taxas pagas");
foreach (var payer in payers)
{
    Console.WriteLine(payer);
}