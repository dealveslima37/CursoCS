using Aula204.Entities;

namespace Aula204.Services
{
    internal class RentalService
    {

        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }
        public BrazilTaxService? BrazilTaxService { get; set; }

        public RentalService(double pricePerHour, double pricePerDay, BrazilTaxService? brazilTaxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            BrazilTaxService = brazilTaxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            var duration = carRental.Finish.Subtract(carRental.Start);
            var basicPayment = 0.0;

            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            var taxService = BrazilTaxService!.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, taxService);

        }

    }
}
