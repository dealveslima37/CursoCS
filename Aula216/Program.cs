using Aula216.Entities;

Client a= new Client{Name = "Alexandre", Email = "alexandre@gmail.com"};
Client b = new Client{Name = "Maria", Email = "maria@gmail.com"};
Client c = new Client{Name = "Mary", Email = "alexandre@gmail.com"};

Console.WriteLine(a.Equals(b));
Console.WriteLine(a.Equals(c));
Console.WriteLine(a.GetHashCode());
Console.WriteLine(c.GetHashCode());


