using Aula073;

int a = 10;
int triple;

Calculator.Triple(ref a);
Calculator.Triple(a, out triple);


Console.WriteLine("REF " + a);
Console.WriteLine("OUT " + a);


