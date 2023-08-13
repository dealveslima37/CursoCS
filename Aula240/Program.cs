using Aula240.Entities;

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

var r1 = from p in products
         where p.Category!.Tier == 1 && p.Price < 900
         select p;

var r2 = from p in products
         where p.Category!.Name == "Tools"
         select p.Name;

var r3 = from p in products
         where p.Name!.StartsWith("C")
         select new { p.Name, p.Price, CategoryName = p.Category!.Name };

var r4 = from p in products
         where p.Category!.Tier == 1
         orderby p.Name
         orderby p.Price
         select p;

var r5 = (from p in r4
          select p).Skip(2).Take(4);

Console.WriteLine("Tier = 1 e produtos com preços menor que R$ 900.00");
r1.ToList().ForEach(p => Console.WriteLine(p));
Console.WriteLine();
Console.WriteLine("Nome dos produtos da categoria Ferramentas");
r2.ToList().ForEach(p => Console.WriteLine(p));
Console.WriteLine();
Console.WriteLine("Nome dos produtos que começam com a letra c");
r3.ToList().ForEach(p => Console.WriteLine(p));
Console.WriteLine();
Console.WriteLine("Tier 1 ordernado por preço e nome");
r4.ToList().ForEach(p => Console.WriteLine(p));
Console.WriteLine();
Console.WriteLine("Pulando dois e pegando 4");
r5.ToList().ForEach(p => Console.WriteLine(p));