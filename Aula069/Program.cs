using System.Globalization;

var locale = CultureInfo.InvariantCulture;
var alturas = new double[3];
var soma = 0.0;

Console.WriteLine("Digite a alturas de três pessoas");

for (var i = 0; i < 3; i++)
{
    alturas[i] = double.Parse(Console.ReadLine()!, locale);
    soma += alturas[i];
}

var avg = soma / alturas.Length;

Console.WriteLine($"Média das alturas: {avg.ToString("F2", locale)}");


