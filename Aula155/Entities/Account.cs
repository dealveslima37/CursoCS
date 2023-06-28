using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula155.Exceptions;

namespace Aula155.Entities
{
    internal class Account
    {

        public int Number { get; set; }
        public string? Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string? holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDrawn(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Saldo insuficiente");
            }
            else if (amount > WithDrawLimit)
            {
                throw new DomainException("Valor excede o limite de saque");
            }

            Balance -= amount;
        }

    }
}
