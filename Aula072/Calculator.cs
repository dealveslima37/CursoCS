namespace Aula072
{
    internal class Calculator
    {

        public static int Sum(params int[] x)
        {
            int sum = 0;
            for(int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }

            return sum;
        }

    }
}
