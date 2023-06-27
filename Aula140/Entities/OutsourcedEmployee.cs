namespace Aula140.Entities
{
    internal class OutsourcedEmployee : Employee
    {

        public double AddionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addionalCharge) : base(name, hours, valuePerHour)
        {
            AddionalCharge = addionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AddionalCharge * 110 / 100);
        }

    }
}
