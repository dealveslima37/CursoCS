using System.Text;
using Aula132.Entities.Enums;

namespace Aula132.Entities;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client? Client { get; set; }
    public List<OrderItem> Items { get; private set; } = new();

    public Order(DateTime moment, OrderStatus stat, Client? client)
    {
        Moment = moment;
        Status = stat;
        Client = client;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        Items.Remove(item);
    }

    public double Total()
    {
        var sum = 0.0;
        foreach (var item in Items)
        {
            sum += item.SubTotal();
        }

        return sum;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Momento do pedido {Moment}");
        sb.AppendLine($"Status do pedido {Status.ToString()}");
        sb.AppendLine($"Client: {Client?.Name} ({Client?.BirthDate.ToString("dd/MM/yyyy")}) - {Client?.Email}");
        sb.AppendLine("Items do pedido");
        foreach (var item in Items)
        {
            sb.AppendLine(
                $"{item?.Product?.Name}, R$ {item?.Price.ToString("F2")} Quantidade: {item?.Quantity}, " +
                $"Subtotal R$: {item?.SubTotal().ToString("F2")}");
        }

        sb.AppendLine($"Preço Total: R$ {Total().ToString("F2")}");

        return sb.ToString();
    }
}