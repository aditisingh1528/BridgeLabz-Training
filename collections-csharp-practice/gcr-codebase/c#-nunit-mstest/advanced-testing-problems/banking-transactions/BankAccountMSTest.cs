using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class BankAccountMSTest
{
    private BankAccount account;

    [TestInitialize]
    public void Setup()
    {
        account = new BankAccount();
    }

    [TestMethod]
    public void Deposit_ValidAmount_BalanceIncreases()
    {
        account.Deposit(1000);
        Assert.AreEqual(1000, account.GetBalance());
    }

    [TestMethod]
    public void Withdraw_ValidAmount_BalanceDecreases()
    {
        account.Deposit(800);
        account.Withdraw(300);

        Assert.AreEqual(500, account.GetBalance());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Withdraw_InsufficientFunds_ThrowsException()
    {
        account.Deposit(200);
        account.Withdraw(500);
    }
}
