using Aula241.Entities;

List<Product> productList = new List<Product>
        {
            new Product("TV", 900.00),
            new Product("Mouse", 50.00),
            new Product("Tablet", 350.50),
            new Product("HD Case", 80.90),
            new Product("Computer", 850.00),
            new Product("Monitor", 290.00)
        };

var avgPrice = productList.Select(p => p.Price).DefaultIfEmpty().Average();
var result = productList.Where(p => avgPrice > p.Price).Select(p => new { p.Name }).OrderByDescending(p => p.Name).ToList();

Console.WriteLine($"Média dos preços R$ {avgPrice.ToString("F2")}");
result.ForEach(p => Console.WriteLine(p));

