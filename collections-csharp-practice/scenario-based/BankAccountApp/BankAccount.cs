using System;

namespace BankAccountApp.Model
{
    // Represents a bank account
    public class BankAccount
    {
        // Property to store balance
        public decimal Balance { get; private set; }

        // Constructor to set initial balance
        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        // Deposit money into account
        public void Deposit(decimal amount)
        {
            if (amount < 0)
                throw new Exception("Deposit amount cannot be negative");

            Balance += amount;
        }

        // Withdraw money from account
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new Exception("Insufficient funds.");

            Balance -= amount;
        }
    }
}