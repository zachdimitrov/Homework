using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Logic
{
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Money { get; private set; }
        private ILogger filelogger;

        public BankAccount()
        {
            this.filelogger = new FileLogger();
        }

        public BankAccount(ILogger logger)
        {
            this.filelogger = logger;
        }

        public void Withdraw(decimal money)
        {
            if (this.Money < money)
            {
                throw new ArgumentException("Not enough money");
            }

            this.filelogger.Log(string.Format("{0} withdraws {1}", this.Name, money));

            this.Money -= money;
        }

        public void Deposit(decimal money)
        {
            this.filelogger.Log(string.Format("{0} deposits {1}", this.Name, money));
            this.Money += money;
        }
    }
}
