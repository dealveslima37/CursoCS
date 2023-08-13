namespace Aula230.Entities
{
    internal class Calculator
    {

        public static void Pot(double x)
        {
            double result = x * x;
            Console.WriteLine($"Potenciação de {x} = {result}");
        }

        public static void Square(double x)
        {
            double result = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {result.ToString("F2")}");
        }

    }
}
