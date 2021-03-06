﻿
namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Deposit : Acount, IWithdraw
    {
        // Constructor
        public Deposit()
            : this(new Customer(), 0, 0) { }

        public Deposit(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate) { }

        // Methods
        public override double CalculateInterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterestAmount(months);
        }

        public void Withdraw(double amount)
        {
            if (this.Balance < amount)
            {
                throw new ArgumentException();
            }
            this.Balance -= amount;
        }
    }
}