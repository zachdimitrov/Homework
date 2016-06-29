namespace Problem_2_BankAccounts.Accounts.Base
{
    using Owner;
    using System;

    public abstract class Account
    {
        private decimal amount;
        private int number;
        private Customer owner;

        public Account()
        {
            this.Number = int.Parse(DateTime.Now.ToString("yyMMddHHmm"));
        }

        public Account(Customer owner, decimal amount)
        {
            this.Number = int.Parse(DateTime.Now.ToString("yyMMddHHmm"));
            this.Amount = amount;
            this.owner = Owner;
        }

        public Customer Owner
        {
            get { return owner; }
            internal set { owner = value; }
        }

        public int Number
        {
            get { return number; }
            internal set { number = value; }
        }

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
            internal set
            {
                if (value >= 0)
                {
                    this.amount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Amount cannot be negative!");
                }
            }
        }

        public virtual decimal CalculateInterest(int months, decimal interest)
        {
            return this.amount * months * interest;
        }
    }
}