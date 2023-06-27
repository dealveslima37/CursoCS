using Aula071.Entities;

Console.Write("Quantos quartos serão alugados? ");
var n = int.Parse(Console.ReadLine()!);

var alugueis = new Aluguel[10];

for (var i = 0; i < n; i++)
{
    Console.WriteLine($"Aluguel {i + 1}");
    Console.Write("Nome: ");
    var nome = Console.ReadLine();
    Console.Write("Email: ");
    var email = Console.ReadLine();
    Console.Write("Quarto: ");
    var quarto = int.Parse(Console.ReadLine()!);

    alugueis[quarto] = new Aluguel { Nome = nome, Email = email, Quarto = quarto };
}

Console.WriteLine("Quartos ocupados");
foreach (var x in alugueis)
{
    if (x != null)
    {
        Console.WriteLine(x);
    }
}

