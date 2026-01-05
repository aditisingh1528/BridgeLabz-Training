using System;

// Abstraction
interface IPayable
{
    double CalculateBill();
}

// Base Class
abstract class Patient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    protected Patient(int id, string name, int age)
    {
        PatientId = id;
        Name = name;
        Age = age;
    }

    public abstract void DisplayInfo();
}

// InPatient
class InPatient : Patient, IPayable
{
    public int DaysAdmitted { get; set; }
    public double DailyCharge { get; set; }

    public InPatient(int id, string name, int age, int days, double charge)
        : base(id, name, age)
    {
        DaysAdmitted = days;
        DailyCharge = charge;
    }

    public double CalculateBill()
    {
        return DaysAdmitted * DailyCharge;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("\nIn-Patient Details");
        Console.WriteLine($"ID: {PatientId}, Name: {Name}, Age: {Age}");
        Console.WriteLine($"Bill Amount: {CalculateBill()}");
    }
}

// OutPatient
class OutPatient : Patient, IPayable
{
    public double ConsultationFee { get; set; }

    public OutPatient(int id, string name, int age, double fee)
        : base(id, name, age)
    {
        ConsultationFee = fee;
    }

    public double CalculateBill()
    {
        return ConsultationFee;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("\nOut-Patient Details");
        Console.WriteLine($"ID: {PatientId}, Name: {Name}, Age: {Age}");
        Console.WriteLine($"Bill Amount: {CalculateBill()}");
    }
}

// Doctor
class Doctor
{
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    public Doctor(int id, string name, string specialization)
    {
        DoctorId = id;
        Name = name;
        Specialization = specialization;
    }

    public void DisplayDoctor()
    {
        Console.WriteLine($"\nDoctor: {Name}, Specialization: {Specialization}");
    }
}

// Main
class Program
{
    static void Main()
    {
        Console.Write("Enter Doctor ID: ");
        int dId = int.Parse(Console.ReadLine());

        Console.Write("Enter Doctor Name: ");
        string dName = Console.ReadLine();

        Console.Write("Enter Specialization: ");
        string spec = Console.ReadLine();

        Doctor doctor = new Doctor(dId, dName, spec);
        doctor.DisplayDoctor();

        Console.Write("\nEnter Patient Type (1-InPatient, 2-OutPatient): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter Patient ID: ");
        int pId = int.Parse(Console.ReadLine());

        Console.Write("Enter Patient Name: ");
        string pName = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Patient patient;

        if (choice == 1)
        {
            Console.Write("Enter Days Admitted: ");
            int days = int.Parse(Console.ReadLine());

            Console.Write("Enter Daily Charge: ");
            double charge = double.Parse(Console.ReadLine());

            patient = new InPatient(pId, pName, age, days, charge);
        }
        else
        {
            Console.Write("Enter Consultation Fee: ");
            double fee = double.Parse(Console.ReadLine());

            patient = new OutPatient(pId, pName, age, fee);
        }

        patient.DisplayInfo(); // Polymorphism
    }
}