using Aula142.Entities;

Console.Write("Entre com o número de produtos: ");
var n = int.Parse(Console.ReadLine()!);

List<Product> products = new();

for (var i = 1; i <= n; i++)
{
    Console.WriteLine($"Dados do produto #{i}");
    Console.Write("Comum, Usado ou importado (c,u,i): ");
    var option = Console.ReadLine()?.ToLower();
    Console.Write("Nome: ");
    var name = Console.ReadLine();
    Console.Write("Preço R$: ");
    var price = double.Parse(Console.ReadLine()!);
    if (option!.StartsWith('i'))
    {
        Console.Write("Taxa Alfandegária R$: ");
        var customsFee = double.Parse((Console.ReadLine()!));
        products.Add(new ImportedProduct(name!, price, customsFee));
    }
    else if (option!.StartsWith('u'))
    {
        Console.Write("Data de fabricação: (DD/MM/YYYY): ");
        var manufactureDate = DateTime.Parse(Console.ReadLine()!);
        products.Add(new UsedProduct(name!, price, manufactureDate));
    }
    else
    {
        products.Add(new Product(name!, price));
    }
}

Console.WriteLine();
Console.WriteLine("Etiqueta de preços");
foreach (var product in products)
{
    Console.WriteLine(product.PriceTag());
}
