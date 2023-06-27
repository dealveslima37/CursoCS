Console.WriteLine("Digite três números inteiros: ");
var n1 = int.Parse(Console.ReadLine()!);
var n2 = int.Parse(Console.ReadLine()!);
var n3 = int.Parse(Console.ReadLine()!);

var maior = Maior(n1, n2, n3);
Console.WriteLine($"Maior número {maior}");

static int Maior(int n1, int n2, int n3)
{
    if (n1 > n2 && n2 > n3) return n1;
    else if (n2 > n3) return n2;
    else return n3;
}
