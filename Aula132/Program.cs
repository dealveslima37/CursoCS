using Aula132.Entities;
using Aula132.Entities.Enums;

namespace Aula132;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do cliente");
        Console.Write("Nome: ");
        var name = Console.ReadLine();
        Console.Write("Email: ");
        var email = Console.ReadLine();
        Console.Write("Data de nascimento: (DD/MM/YYYY): ");
        var birthDate = DateTime.Parse(Console.ReadLine()!);

        var client = new Client(name, email, birthDate);

        Console.WriteLine("Entre com os dados do pedido");
        Console.Write("Status: ");
        var status = Enum.Parse<OrderStatus>(Console.ReadLine()!);

        var order = new Order(DateTime.Now, status, client);

        Console.Write("Quantos items contém o pedido? ");
        var nItems = int.Parse(Console.ReadLine()!);
        for (var i = 1; i <= nItems; i++)
        {
            Console.WriteLine($"Dados do {i}º item");
            Console.Write("Nome do produto: ");
            var productName = Console.ReadLine();
            Console.Write("Preço do produto: ");
            var productPrice = double.Parse(Console.ReadLine()!);
            Console.Write("Quatidade: ");
            var quantity = int.Parse(Console.ReadLine()!);

            var orderItem = new OrderItem(quantity, productPrice, new Product(productName, productPrice));

            order.AddItem(orderItem);
        }

        Console.WriteLine();
        Console.WriteLine("Resumo do pedido");
        Console.WriteLine(order);
    }
}