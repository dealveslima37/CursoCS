using Aula228.Entities;

List<Product> products = new();

products.Add(new Product("TV", 900.00));
products.Add(new Product("Notebook", 5000.00));
products.Add(new Product("X BOX One", 4500.00));
products.Add(new Product("PS5", 6000.00));
products.Add(new Product("Tablet", 1350.00));
products.Add(new Product("Mouse", 50.00));
products.Add(new Product("Aparador de pelos", 125.00));

Console.WriteLine("Ordenado por nome");
products.Sort((p1, p2) => p1.Name!.ToUpper().CompareTo(p2.Name!.ToUpper()));

products.ForEach((p) => Console.WriteLine(p));

products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));

Console.WriteLine();
Console.WriteLine("Ordenado por preço");
products.ForEach((p) => Console.WriteLine(p));