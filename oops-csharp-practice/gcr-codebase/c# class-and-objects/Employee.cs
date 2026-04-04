using System;

public class Employee{

    public string Name;
    public int Id;
    public double Salary;

    public void DisplayDetails(){
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Program{

    static void Main(){

        // creating employee object
        Employee emp = new Employee();

        // assigning values
        emp.Name = "Maxine";
        emp.Id = 7244;
        emp.Salary = 90000;

        // displaying details
        emp.DisplayDetails();
    }
}
