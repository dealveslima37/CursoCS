List<double> numbers = new List<double> { 13.0, 25.0, 34.0, 29, 88, 52, 91.5, 17.5 };

var sum = numbers.Sum();
var sum2 = numbers.Aggregate(0.0, (x, y) => x + y);

Console.WriteLine(sum);
Console.WriteLine(sum2);
