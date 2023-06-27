namespace Aula015;

using System;

internal class Program
{
    static void Main(string[] args)
    {

        bool completo = false;
        char genero = 'F';
        byte n1 = 126;
        int n2 = 1000;
        int n3 = 2147483647;
        long n4 = 21474836478L;
        float n5 = 4.5F;
        double n6 = 4.7;
        String nome = "Maria Green";

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(completo);
        Console.WriteLine(genero);
        Console.WriteLine(n5);
        Console.WriteLine(n6);
        Console.WriteLine(nome);

        int n7 = int.MinValue;
        int n8 = int.MaxValue;

        Console.WriteLine(n7);
        Console.WriteLine(n8);

    }
}
