using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankSystem.Logic;
using Moq;

namespace BankSyste.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorShouldSetMoneeyToZero()
        {
            var bankAccount = new BankAccount();
            Assert.AreEqual(0, bankAccount.Money);
        }

        [TestMethod]
        public void DepositShouldAddToMOney()
        {
            var bankAccount = new BankAccount();
            bankAccount.Deposit(100);
            Assert.AreEqual(100, bankAccount.Money);
        }

        [TestMethod]
        public void DepositShouldRemoveToMOney()
        {
            var bankAccount = new BankAccount();
            bankAccount.Deposit(100);
            bankAccount.Withdraw(50);
            Assert.AreEqual(50, bankAccount.Money);
        }

        [TestMethod]
        public void DepositShouldLogTransactions()
        {
            var loggerMock = new Mock<ILogger>();
            var bankAccount = new BankAccount(loggerMock.Object);
            bankAccount.Deposit(1000);
            loggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Once());
        }

        /*
        [TestMethod]
        public void DepositShouldLogTransactions()
        {
            var mockedLogger = new IsLogMethodCalledLogger();
            var bankAccount = new BankAccount(mockedLogger);
            bankAccount.Deposit(100);
            Assert.IsTrue(mockedLogger.LogIsCalled);
        }
        */
    }

    /*
    public class IsLogMethodCalledLogger : ILogger
    {
        public bool LogIsCalled { get; private set; }
        public void Log(string message)
        {
            this.LogIsCalled = true;
        }
    }
    */
}
