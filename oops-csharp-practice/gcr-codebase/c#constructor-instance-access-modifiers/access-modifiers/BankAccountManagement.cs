using System;

public class BankAccount
{
    public int accountNumber;        // public
    protected string accountHolder;  // protected
    private double balance;          // private

    public BankAccount(int accNo, string holder, double balance)
    {
        accountNumber = accNo;
        accountHolder = holder;
        this.balance = balance;
    }

    // Public access to balance
    public double GetBalance()
    {
        return balance;
    }

    public void SetBalance(double amount)
    {
        balance = amount;
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(int accNo, string holder, double balance)
        : base(accNo, holder, balance) { }

    public void Display()
    {
        Console.WriteLine($"Account: {accountNumber}, Holder: {accountHolder}, Balance: {GetBalance()}");
    }

    static void Main()
    {
        SavingsAccount sa = new SavingsAccount(5551, "Aditi", 20000);
        sa.Display();
    }
}