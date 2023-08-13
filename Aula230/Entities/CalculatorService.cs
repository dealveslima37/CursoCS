namespace Aula230.Entities
{
    internal class CalculatorService
    {

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static void MinusTen(double x)
        {
            Console.WriteLine($"{x} - 10 = {x - 10}");
        }

    }
}
