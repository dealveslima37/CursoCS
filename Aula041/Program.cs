using Entities;
using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.WriteLine("Entre com as medidas do triângulo X");
var a = double.Parse(Console.ReadLine()!, locale);
var b = double.Parse(Console.ReadLine()!, locale);
var c = double.Parse(Console.ReadLine()!, locale);

var trianguloX = new Triangulo()
{
    A = a,
    B = b,
    C = c
};

var areaX = trianguloX.Area();

Console.WriteLine("Entre com as medidas do triângulo Y");
a = double.Parse(Console.ReadLine()!, locale);
b = double.Parse(Console.ReadLine()!, locale);
c = double.Parse(Console.ReadLine()!, locale);

var trianguloY = new Triangulo()
{
    A = a,
    B = b,
    C = c
};

var areaY = trianguloY.Area();

Console.WriteLine($"Área x = {areaX.ToString("F4", locale)}");
Console.WriteLine($"Área x = {areaY.ToString("F4", locale)}");

var maiorArea = (areaX > areaY) ? "Maior área X" : "Maior área Y";

Console.WriteLine(maiorArea);
