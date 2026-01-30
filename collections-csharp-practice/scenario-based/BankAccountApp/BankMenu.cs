using System;
using BankAccountApp.Model;

namespace BankAccountApp.Menu
{
    // Handles user interaction
    public class BankMenu
    {
        private readonly BankAccount account;

        public BankMenu()
        {
            // Initial balance set here
            account = new BankAccount(1000);
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n🏦 Bank Account System");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            DepositAmount();
                            break;

                        case 2:
                            WithdrawAmount();
                            break;

                        case 3:
                            Console.WriteLine($"Current Balance: {account.Balance}");
                            break;

                        case 4:
                            Console.WriteLine("Exiting Bank System...");
                            return;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                }
            }
        }

        private void DepositAmount()
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.WriteLine("✅ Amount deposited successfully");
        }

        private void WithdrawAmount()
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            account.Withdraw(amount);
            Console.WriteLine("✅ Amount withdrawn successfully");
        }
    }
}