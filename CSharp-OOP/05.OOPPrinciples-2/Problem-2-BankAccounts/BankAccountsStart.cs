namespace Problem_2_BankAccounts
{
    using Owner;
    using Problem_2_BankAccounts.Accounts;
    using System;

    class BankAccountsStart
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++ CUSTOMERS ++++");
            var owner = new Individual("Pesho");
            var firm = new Company("BabaMeca");
            Console.WriteLine(owner);
            Console.WriteLine(firm);
            Console.WriteLine("");

            Console.WriteLine("++++ DEPOSIT ++++");
            var myDeposit = new DepositAccount();
            myDeposit.Deposit(1100);
            myDeposit.Amount += myDeposit.CalculateInterest(12, 0.076M);
            myDeposit.Withdraw(200);
            Console.WriteLine(myDeposit);

            Console.WriteLine("++++ LOAN ++++");
            var myLoan = new LoanAccount(owner, 5000);
            myLoan.Amount += myLoan.CalculateInterest(12, 0.053M);
            myLoan.Deposit(500);
            Console.WriteLine(myLoan);

            Console.WriteLine("++++ MORTGAGE ++++");
            var myMortgage = new LoanAccount(owner, 30000);
            myMortgage.Amount += myMortgage.CalculateInterest(12, 0.031M);
            myMortgage.Deposit(600);
            Console.WriteLine(myMortgage);
        }
    }
}
