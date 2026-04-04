using System;
using System.Collections.Generic;

interface ILoanable
{
    void ApplyForLoan();
    bool CalculateLoanEligibility();
}

abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    protected double balance;

    protected BankAccount(string accNo, string name, double balance)
    {
        accountNumber = accNo;
        holderName = name;
        this.balance = balance;
    }

    public void Deposit(double amount) => balance += amount;

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
    }

    public abstract double CalculateInterest();
}

class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(string accNo, string name, double bal)
        : base(accNo, name, bal) { }

    public override double CalculateInterest() => balance * 0.04;

    public void ApplyForLoan() => Console.WriteLine("Loan Applied");
    public bool CalculateLoanEligibility() => balance > 5000;
}
