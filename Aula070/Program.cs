using Aula070.Entities;
using System.Globalization;

var locale = CultureInfo.InvariantCulture;

var products = new Product[3];
var soma = 0.0;

Console.WriteLine("Digite nome e preço dos produtos");

for (var i = 0; i < products.Length; i++)
{
    products[i] = new Product
    {
        Nome = Console.ReadLine(),
        Preco = double.Parse(Console.ReadLine()!, locale),
    };

    soma += products[i].Preco;
}

var avgPrice = soma / products.Length;

Console.WriteLine($"Média dos preços {avgPrice.ToString("F2", locale)}");

