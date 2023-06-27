List<String> lista = new();

lista.Add("Amalia");
lista.Add("Jia");
lista.Add("Kelly");
lista.Insert(0, "Stefany");
lista.Insert(1, "Sofa");
lista.Add("Sasha");
lista.Add("Stacy");
lista.Add("Lola");
lista.Insert(2, "Liya");
lista.Add("Mary");
lista.Add("Hello");
lista.Add("Angel");


foreach (var item in lista)
{
    Console.Write($"{item} ");
}

Console.WriteLine($"\nTamanho da lista {lista.Count}");

var firstS = lista.Find(x => x.StartsWith("S"));

Console.WriteLine(firstS);

var lastM = lista.FindLast(x => x.StartsWith("S"));
Console.WriteLine(lastM);

var fistIndexA = lista.FindIndex(x => x.StartsWith("A"));
var lastIndexA = lista.FindLastIndex(x => x[0] == 'A');
Console.WriteLine(fistIndexA);
Console.WriteLine(lastIndexA);

var lista2 = lista.FindAll(x => x.StartsWith("S"));

lista2.ForEach(x => Console.Write($"{x} "));

lista.Remove("Stacy");
lista.ForEach(x => Console.Write($"\nLista 3: {x} "));

lista.RemoveAll(x => x.StartsWith("S"));
Console.WriteLine();
lista.ForEach(x => Console.Write($"{x} "));

lista.RemoveAt(4);
Console.WriteLine();
lista.ForEach(x => Console.Write($"{x} "));