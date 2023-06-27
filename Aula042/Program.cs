using System.Globalization;
using Entities;

var locale = CultureInfo.InvariantCulture;

Console.WriteLine("Entre com os dados do produto");
Console.Write("Nome: ");
var nome = Console.ReadLine();
Console.Write("Preço R$: ");
var preco = double.Parse(Console.ReadLine()!, locale);
Console.Write("Quantidade em estoque: ");
var quantidade = int.Parse(Console.ReadLine()!);

var produto = new Produto
{
    Nome = nome,
    Preco = preco,
    Quantidade = quantidade
};

Console.WriteLine($"Dados do produto: {produto.Nome}, R$ {produto.Preco}, {produto.Quantidade} unidades, Total R$: " +
    $"{produto.ValorTotalEmEstoque()}");

Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
quantidade = int.Parse((Console.ReadLine()!));

produto.AdicionarProduto(quantidade);

Console.WriteLine($"Dados do produto: {produto.Nome}, R$ {produto.Preco}, {produto.Quantidade} unidades, Total: " +
    $"{produto.ValorTotalEmEstoque()}");

Console.Write("Digite o número de produtos a ser removido do estoque: ");
quantidade = int.Parse((Console.ReadLine()!));

produto.RemoverProduto(quantidade);

Console.WriteLine($"Dados do produto: {produto.Nome}, R$ {produto.Preco}, {produto.Quantidade} unidades, Total: " +
    $"{produto.ValorTotalEmEstoque()}");






