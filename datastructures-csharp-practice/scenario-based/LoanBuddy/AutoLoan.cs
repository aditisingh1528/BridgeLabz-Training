using System;

class AutoLoan : LoanApplication{
    public AutoLoan(Applicant applicant, int term)
        : base(applicant, term, 10.0){
    }

    //Polymorphism:different EMI behavior possible later
    public override double CalculateEMI(){
        return base.CalculateEMI();
    }
}
