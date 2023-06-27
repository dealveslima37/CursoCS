namespace Entities
{
    public class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }


    }
}
