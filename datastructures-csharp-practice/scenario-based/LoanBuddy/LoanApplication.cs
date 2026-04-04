using System;

class LoanApplication : IApprovable
{
	
    protected int Term;
    protected double InterestRate;
    protected Applicant Applicant;

    private bool isApproved;

    public LoanApplication(Applicant applicant, int term, double interestRate)
    {
        Applicant = applicant;
        Term = term;
        InterestRate = interestRate;
        isApproved = false;
    }


    //Internal approval logic based on credit score and income
    public virtual bool ApproveLoan()
    {
        if (Applicant.GetCreditScore() >= 650 && Applicant.Income >= Applicant.LoanAmount / 2)
        {
            isApproved = true;
        }
        return isApproved;
    }


    //Base EMI calculation
    public virtual double CalculateEMI()
    {
        double P = Applicant.LoanAmount;
        double R = InterestRate / (12 * 100);
        int N = Term;

        return (P * R * Math.Pow(1 + R, N)) / (Math.Pow(1 + R, N) - 1);
    }
}
