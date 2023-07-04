using System.Text;

namespace Aula204.Entities
{
    internal class Invoice
    {

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment()
        {
            return BasicPayment + Tax;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Pagamento básico R$ {BasicPayment.ToString("F2")}");
            sb.AppendLine($"Taxa R$ {Tax.ToString("F2")}");
            sb.AppendLine($"Pagamento Total R$: {TotalPayment().ToString("F2")}");

            return sb.ToString();
        }

    }
}
