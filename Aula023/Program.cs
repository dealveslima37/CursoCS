using System.Globalization;

var locale = CultureInfo.CurrentCulture;

Console.Write("Entre com seu nome completo: ");
var nomeCompleto = Console.ReadLine();
Console.Write("Quantos quartos tem na sua casa? ");
var quartos = Console.ReadLine();
Console.Write("Entre com o preço do produto: ");
var precoProduto = double.Parse(Console.ReadLine()!, locale);
Console.WriteLine("Entre seu último nome, idade e altura(mesma linha)");
var dados = Console.ReadLine()!.Split(" ");

Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(precoProduto.ToString("F2", locale));
Console.WriteLine(dados[2]);
Console.WriteLine(dados[1]);
Console.WriteLine(dados[0]);


