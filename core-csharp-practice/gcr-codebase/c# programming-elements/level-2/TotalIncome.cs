using System;

public class TotalIncome
{
    public static void Main(string[] args)
    {
        //take salary and bonus input
        Console.WriteLine("Enter salary: ");
        double Salary=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter bonus: ");
        double Bonus=Convert.ToDouble(Console.ReadLine());

        //calculate total income
        double Income=Salary+Bonus;

        Console.WriteLine("The salary is rs. "+Salary+" and bonus is rs. "+Bonus+". Hence Total Income is rs. "+Income);
    }
}
