using System;

class InsufficientFundsException : Exception
{
}

class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }


    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException();
        }

        if (amount > balance)
        {
            throw new InsufficientFundsException();
        }

        balance -= amount;
        Console.WriteLine("Withdrawal successful, new balance: " + balance);
    }

}


class Bank
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            BankAccount account = new BankAccount(balance);

            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());

            account.Withdraw(amount);
        }

        catch (InsufficientFundsException)
        {
            Console.WriteLine("Insufficient balance!");
        }

        catch (ArgumentException)
        {
            Console.WriteLine("Invalid amount!");

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
    
	}

}