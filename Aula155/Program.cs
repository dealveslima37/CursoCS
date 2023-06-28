using Aula155.Entities;
using Aula155.Exceptions;

Console.WriteLine("Entre com os dados da conta: ");
Console.Write("Número: ");
var number = int.Parse(Console.ReadLine()!);
Console.Write("Titular: ");
var holder = Console.ReadLine();
Console.Write("Deposito inicial: ");
var initialBalance = double.Parse(Console.ReadLine()!);
Console.Write("Limite de saque R$: ");
var withDrawLimit = double.Parse(Console.ReadLine()!);

var account = new Account(number, holder, initialBalance, withDrawLimit);

try
{

    Console.Write("Entre com o valor de saque R$: ");
    var amount = double.Parse(Console.ReadLine()!);
    account.WithDrawn(amount);
    Console.WriteLine("Saldo atualizado R$: " + account.Balance.ToString("F2"));

}
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}



