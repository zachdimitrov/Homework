namespace Problem_2_BankAccounts.Accounts
{
    using Base;
    using Owner;
    using System;
    using System.Text;
    using Utilities;

    class MortgageAccount : Account, IDeposit
    {

        public MortgageAccount(Customer owner, decimal debt) : base(owner, debt)
        {
            this.Amount = debt;
            this.Owner = owner;
        }

        public void Deposit(decimal money)
        {
            this.Amount -= money;
            Console.WriteLine($"Deposited ${money:F2}");
        }

        public override decimal CalculateInterest(int months, decimal interest)
        {
            decimal result = 0;
            if (this.Owner is Individual && months > Constants.MortgageIndividualMonths)
            {
                months -= Constants.MortgageIndividualMonths;
                result = base.CalculateInterest(months, interest);
            }
            else if (this.Owner is Company)
            {
                if (months > Constants.MortgageCompanyMonths)
                {
                    months -= Constants.MortgageCompanyMonths;
                    result = 
                        base.CalculateInterest(Constants.MortgageCompanyMonths, interest) +
                        base.CalculateInterest(months, interest);
                }
                else
                {
                    result = base.CalculateInterest(months, interest/2);
                }
            }
            return result;
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendLine(new string('=', Constants.Delimiter));
            info.AppendLine("Mortgage Account");
            info.AppendLine($"Number: {this.Number}");
            info.AppendLine($"Amount left to return: ${this.Amount:F2}");
            info.AppendLine(new string('=', Constants.Delimiter));
            return info.ToString();
        }
    }
}
