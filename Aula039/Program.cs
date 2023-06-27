using Entities;
using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.WriteLine("Entre com as medidas do triângulo X:");
var a = double.Parse(Console.ReadLine()!, locale);
var b = double.Parse(Console.ReadLine()!, locale);
var c = double.Parse(Console.ReadLine()!, locale);

var trianguloX = new Triangulo();

var p = (trianguloX.A + trianguloX.B + trianguloX.C) / 2.0;

var areaX = Math.Sqrt(p * (p - trianguloX.A) * (p - trianguloX.B) * (p - trianguloX.C));

Console.WriteLine("Entre com as medidas do triângulo Y:");
a = double.Parse(Console.ReadLine()!, locale);
b = double.Parse(Console.ReadLine()!, locale);
c = double.Parse(Console.ReadLine()!, locale);

var trianguloY = new Triangulo();

p = (trianguloY.A + trianguloY.B + trianguloY.C) / 2.0;

var areaY = Math.Sqrt(p * (p - trianguloX.A) * (p - trianguloX.B) * (p - trianguloX.C));

Console.WriteLine($"Área X = {areaX.ToString("F3", locale)}");
Console.WriteLine($"Área Y = {areaY.ToString("F3", locale)}");

var maiorTriangulo = (areaX > areaY) ? "Maior Triângulo X" : "Maior Triângulo Y";

Console.WriteLine($"{maiorTriangulo}");




