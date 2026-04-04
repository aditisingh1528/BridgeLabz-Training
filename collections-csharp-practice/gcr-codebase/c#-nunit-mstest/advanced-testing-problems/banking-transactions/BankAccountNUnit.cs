using NUnit.Framework;
using System;

[TestFixture]
public class BankAccountNUnit
{
    private BankAccount account;

    [SetUp]
    public void Setup()
    {
        account = new BankAccount();
    }

    [Test]
    public void Deposit_ValidAmount_BalanceIncreases()
    {
        account.Deposit(500);
        Assert.AreEqual(500, account.GetBalance());
    }

    [Test]
    public void Withdraw_ValidAmount_BalanceDecreases()
    {
        account.Deposit(1000);
        account.Withdraw(400);

        Assert.AreEqual(600, account.GetBalance());
    }

    [Test]
    public void Withdraw_InsufficientFunds_ThrowsException()
    {
        account.Deposit(300);

        Assert.Throws<InvalidOperationException>(() => account.Withdraw(500));
    }
}
