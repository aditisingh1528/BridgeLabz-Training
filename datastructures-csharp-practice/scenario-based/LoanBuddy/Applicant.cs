using System;

class Applicant{
    public string Name;
    public double Income;
    public double LoanAmount;

    private int creditScore;

    public Applicant(string name, int creditScore, double income, double loanAmount){
        Name = name;
        this.creditScore = creditScore;
        Income = income;
        LoanAmount = loanAmount;
    }

    public int GetCreditScore(){
        return creditScore;
    }
}