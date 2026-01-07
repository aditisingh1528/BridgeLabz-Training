using System;

interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

abstract class Patient
{
    private int patientId;
    private string name;
    protected int age;

    protected Patient(int id, string name, int age)
    {
        patientId = id;
        this.name = name;
        this.age = age;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine($"{name}, Age: {age}");
    }
}

class InPatient : Patient, IMedicalRecord
{
    public InPatient(int id, string name, int age)
        : base(id, name, age) { }

    public override double CalculateBill() => 5000;
    public void AddRecord(string record) { }
    public void ViewRecords() { }
}
