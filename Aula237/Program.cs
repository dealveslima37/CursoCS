using Aula237.Entities;

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

Console.WriteLine("Tier 1 e preço < 900");
var result = products.Where(x => x.Category!.Tier == 1 && x.Price < 900.00).ToList();
result.Sort((p1, p2) => p1.Name!.CompareTo(p2.Name));

result.ForEach(x => Console.WriteLine($"Produto: {x.Name} || Preço: {x.Price} || Tier: {x.Category!.Tier}"));

Console.WriteLine("Produtos da categoria tools");
var tools = products.Where(p => p.Category!.Name == "Tools").Select(p => p.Name).ToList();
tools.ForEach(x => Console.WriteLine(x));

Console.WriteLine("Produtos que começam com a letra c");
var result3 = products.Where(p => p.Name!.StartsWith("C")).Select(p => p.Name).ToList();
result3.ForEach(x => Console.WriteLine(x));

Console.WriteLine("Produtos que o Tier d categoria seja == 1");
var result4 = products.Where(p => p.Category!.Tier == 1).Select(p => new
{
    p.Name,
    p.Price,
    CategoryName = p.Category!.Name,
    p.Category.Tier
}).OrderByDescending(x => x.Price).ThenBy(p => p.Name).ToList();

result4.ForEach(x => Console.WriteLine(x));

Console.WriteLine("Pulando 2 e pegando 4");
var result5 = result4.Skip(2).Take(4).ToList();
result5.ForEach(x => Console.WriteLine(x));

var r6 = products.FirstOrDefault();
Console.WriteLine("First R6 " + r6);

var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
Console.WriteLine("Teste 2 = " + r7);

var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
Console.WriteLine("Teste 3 = " + r8);

var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
Console.WriteLine("Teste 4 = " + r9);

var r10 = products.Max(p => p.Price);
Console.WriteLine("Maior preço " + r10);

var r11 = products.Min(p => p.Price);
Console.WriteLine("Menor preço R$ " + r11);

var r12 = products.Where(p => p.Category!.Id == 1).Sum(p => p.Price);
Console.WriteLine("Categoria 1 soma = R$ " + r12);

var r13 = products.Where(p => p.Category!.Id == 1).Average(p => p.Price);
Console.WriteLine("Média = " + r13);

var r14 = products.Where(p => p.Category!.Id == 13).Select(p => p.Price).DefaultIfEmpty().Average();
Console.WriteLine("Média = " + r14);

var r15 = products.Where(p => p.Category!.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
Console.WriteLine("Soma categoria 1 " + r15);

var r16 = products.GroupBy(p => p.Category).ToList();

r16.ForEach(p => Console.WriteLine());