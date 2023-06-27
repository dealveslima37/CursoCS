Console.Write("Digite um número: ");
var x = int.Parse(Console.ReadLine()!);
Console.Write("Digite outro número: ");
var y = int.Parse(Console.ReadLine()!);

var soma = x + y;

Console.WriteLine($"A soma de {x} + {y} = {soma}");