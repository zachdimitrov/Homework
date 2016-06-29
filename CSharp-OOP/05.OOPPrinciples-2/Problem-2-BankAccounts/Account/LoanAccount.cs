namespace Problem_2_BankAccounts.Accounts
{
    using Base;
    using Contract;
    using Owner;
    using System;
    using System.Text;
    using Utilities;

    class LoanAccount : Account, IDeposit
    {
        
        public LoanAccount(Customer owner, decimal debt) : base(owner, debt)
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
            if (this.Owner is Individual && months > Constants.LoanIndividualMonths)
            {
                months -= Constants.LoanIndividualMonths;
                result = base.CalculateInterest(months, interest);
            }
            else if (this.Owner is Company && months > Constants.LoanCompanyMonths)
            {
                months -= Constants.LoanCompanyMonths;
                result = base.CalculateInterest(months, interest);
            }
            return result;
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendLine(new string('=', Constants.Delimiter));
            info.AppendLine("Loan Account");
            info.AppendLine($"Number: {this.Number}");
            info.AppendLine($"Amount left to return: ${this.Amount:F2}");
            info.AppendLine(new string('=', Constants.Delimiter));
            return info.ToString();
        }
    }
}
