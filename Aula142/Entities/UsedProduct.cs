namespace Aula142.Entities
{
    internal class UsedProduct : Product
    {

        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $" (Data de fabricação {ManufactureDate.ToString("dd/MM/yyyy")})";
        }


    }
}
