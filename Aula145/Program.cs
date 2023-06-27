using Aula145.Entities;
using Aula145.Entities.Enums;

Console.Write("Entre com o número de formas: ");
var n = int.Parse(Console.ReadLine()!);
List<Shape> shapes = new();

for (var i = 0; i < n; i++)
{
    Console.WriteLine($"Dados da {i + 1}º Forma");
    Console.Write("Retângulo ou circulo? (r/c): ");
    var option = Console.ReadLine()!.ToLower();
    Console.Write("Cor (Black/Blue/Red): ");
    var color = Enum.Parse<Color>(Console.ReadLine()!);
    if (option.StartsWith("r"))
    {
        Console.Write("Largura: ");
        var width = double.Parse(Console.ReadLine()!);
        Console.Write("Altura: ");
        var height = double.Parse((Console.ReadLine()!));
        shapes.Add(new Rectangle(width, height, color));
    }
    else if (option.StartsWith("c"))
    {
        Console.Write("Radius: ");
        var radius = double.Parse(Console.ReadLine()!);
        shapes.Add(new Circle(radius, color));
    }
}

Console.WriteLine("Área das formas");
foreach (var shape in shapes)
{
    Console.WriteLine(shape.Area().ToString("F2"));
}
