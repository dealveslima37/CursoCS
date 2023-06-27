using Entities;
using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.Write("Entre com o número da conta: ");
var numeroDaConta = int.Parse(Console.ReadLine()!);
Console.Write("Entre com o titular da conta: ");
var titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)?: ");
var op = Console.ReadLine()?.ToLower();

ContaBancaria contaBancaria;

if (op!.StartsWith('s'))
{
    Console.Write("Entre o valor de depósito inicial: ");
    var valorInicial = double.Parse(Console.ReadLine()!, locale);

    contaBancaria = new ContaBancaria(numeroDaConta, titular, valorInicial);
}
else
{
    contaBancaria = new ContaBancaria(numeroDaConta, titular);
}

Console.WriteLine();

Console.WriteLine("Dados da conta: ");
Console.WriteLine(contaBancaria);

Console.Write("Entre um valor para depósito: ");
var valorDoDeposito = double.Parse(Console.ReadLine()!, locale);

contaBancaria.Deposito(valorDoDeposito);

Console.WriteLine();

Console.WriteLine("Dados atualizados: ");
Console.WriteLine(contaBancaria);

Console.Write("Entre um valor para saque: ");
valorDoDeposito = double.Parse(Console.ReadLine()!, locale);

contaBancaria.Saque(valorDoDeposito);

Console.WriteLine();

Console.WriteLine("Dados atualizados: ");
Console.WriteLine(contaBancaria);