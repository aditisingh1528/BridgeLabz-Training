using System;

public class BankAccount
{
    private double balance;

    //method to deposit money
    public void Deposit(double amount)
    {
        balance += amount;
    }

    //method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }

        balance -= amount;
    }

    //method to get current balance
    public double GetBalance()
    {
        return balance;
    }
}
