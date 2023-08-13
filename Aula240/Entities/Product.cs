using System.Text;

namespace Aula240.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public Category? Category { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Id: {Id} ");
            sb.Append($"Name: {Name} ");
            sb.Append($"Preço R$ {Price.ToString("F2")} ");
            sb.Append($"Categoria: {Category!.Name}");

            return sb.ToString();
        }
    }
}
