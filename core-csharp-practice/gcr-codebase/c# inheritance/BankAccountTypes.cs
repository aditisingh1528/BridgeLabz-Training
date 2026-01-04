using System;

class BankAccount
{
    protected double Balance;
    public BankAccount(double b) { Balance = b; }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(double b) : base(b) { }
    public void Show() => Console.WriteLine("Savings Account");
}

class CheckingAccount : BankAccount
{
    public CheckingAccount(double b) : base(b) { }
    public void Show() => Console.WriteLine("Checking Account");
}

class Program
{
    static void Main()
    {
        SavingsAccount s = new SavingsAccount(5000);
        CheckingAccount c = new CheckingAccount(3000);

        s.Show();
        c.Show();
    }
}
