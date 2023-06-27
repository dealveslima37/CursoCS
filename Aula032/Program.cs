using System.Globalization;

var flag = true;
var locale = CultureInfo.InvariantCulture;

while (flag)
{
    Console.WriteLine("Digite um número: ");
    var n = int.Parse(Console.ReadLine()!);
    if (n > 0.0)
    {
        double raiz = Math.Sqrt(n);
        Console.WriteLine($"Raiz de {n} = {raiz.ToString("F3", locale)}");
    }
    else
    {
        flag = false;
    }
}

Console.WriteLine("Número negativo!");