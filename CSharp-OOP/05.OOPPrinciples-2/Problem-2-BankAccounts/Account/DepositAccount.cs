namespace Problem_2_BankAccounts.Accounts
{
    using Base;
    using Contract;
    using Owner;
    using System.Text;
    using Utilities;

    class DepositAccount : Account, IDeposit, IWithdraw
    {
        public DepositAccount()
        {
        }

        public DepositAccount(Customer owner, decimal deposit) : base(owner, deposit)
        {
            this.Amount = deposit;
        }

        public void Deposit(decimal money)
        {
            this.Amount += money;
            System.Console.WriteLine($"Deposited ${money:F2}");
        }

        public void Withdraw(decimal sum)
        {
            if (sum <= this.Amount)
            {
                this.Amount -= sum;
                System.Console.WriteLine($"Withdrawed ${sum:F2}");
            }
            else
            {
                throw new NotEnoughMoneyException($"Not enough money in your account {sum} is less than {this.Amount}!");
            }
        }

        public override decimal CalculateInterest(int months, decimal interest)
        {
            if (this.Amount > 1000 )
            {
                return base.CalculateInterest(months, interest);
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendLine(new string('=', Constants.Delimiter));
            info.AppendLine("Deposit Account");
            info.AppendLine($"Number: {this.Number}");
            info.AppendLine($"Amount available: ${this.Amount:F2}");
            info.AppendLine(new string('=', Constants.Delimiter));
            return info.ToString();
        }

    }
}
