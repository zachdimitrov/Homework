﻿using BankSystem.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(new ConsoleLogger())
            {
                Name = "Pesho"
            };

            bankAccount.Deposit(1000m);
            bankAccount.Withdraw(150);
            Console.WriteLine(bankAccount.Money);
        }
    }
}
