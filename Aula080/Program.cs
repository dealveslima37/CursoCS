Console.Write("Informe o número de linhas e colunas: ");
var n = int.Parse(Console.ReadLine()!);

int[,] mat = new int[n, n];
var sum = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < mat.GetLength(0); j++)
    {
        Console.Write("Digite um número: ");
        mat[i, j] = int.Parse(Console.ReadLine()!);
        if (mat[i, j] < 0)
        {
            sum += 1;
        }
    }
}

Console.WriteLine("Diagonal Principal");
for (int i = 0; i < n; i++)
{
    Console.Write(mat[i, i] + " ");
}
Console.WriteLine();
Console.WriteLine("Quantidade de negativos = " + sum);
