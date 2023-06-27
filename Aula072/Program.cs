namespace Aula072;

class Program
{
    public static void Main(string[] args)
    {
        var calc1 = Calculator.Sum(13, 21, 34, 57, 89);
        var calc2 = Calculator.Sum(10, 10, 10, 10);

        Console.WriteLine(calc1);
        Console.WriteLine(calc2);

    }
}
