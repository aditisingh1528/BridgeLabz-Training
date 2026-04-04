using System;

class LoanBuddy
{
    static void Main(string[] args)
    {
		
        Console.WriteLine("Enter applicant name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter credit score:");
        int creditScore = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter income:");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter loan amount:");
        double loanAmount = Convert.ToDouble(Console.ReadLine());

        Applicant applicant = new Applicant(name, creditScore, income, loanAmount);

        Console.WriteLine("Select loan type:");
        Console.WriteLine("1.Home Loan");
        Console.WriteLine("2.Auto Loan");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter loan term in months:");
        int term = Convert.ToInt32(Console.ReadLine());

        LoanApplication loan;


        if (choice == 1)
        {
            loan = new HomeLoan(applicant, term);
        }
        else
        {
            loan = new AutoLoan(applicant, term);
        }

        if (loan.ApproveLoan())
        {
            Console.WriteLine("Loan Approved");
            Console.WriteLine("Monthly EMI: " + loan.CalculateEMI());
        }
        else
        {
            Console.WriteLine("Loan Rejected");
        }
    }
}