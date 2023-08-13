using Aula230.Entities;

double a = 13;
double b = 7;

BinaryNumericOperation sum = CalculatorService.Sum;
BinaryNumericOperation max = CalculatorService.Max;
UnaryNumericOperation op = Calculator.Pot;
op += Calculator.Square;
op(5);
UnaryNumericOperation minus = CalculatorService.MinusTen;
minus(100);

var soma = sum(a, b);
var maxNumber = max(a, b);

Console.WriteLine($"Soma de {a} + {b} = {soma}");
Console.WriteLine($"Maior número entre {a} é {b} = {maxNumber} ");

delegate double BinaryNumericOperation(double x, double y);
delegate void UnaryNumericOperation(double x);