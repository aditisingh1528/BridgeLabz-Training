using System;

class Patient
{
    public static string HospitalName = "City Hospital";
    private static int totalPatients = 0;

    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    public Patient(string name, int age, string ailment, int id)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = id;
        totalPatients++;
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    public void Display(object obj)
    {
        if (obj is Patient)
        {
            Console.WriteLine(Name + " - " + Ailment);
        }
    }
}

class Program
{
    static void Main()
    {
        Patient p1 = new Patient("Neha", 25, "Fever", 301);
        p1.Display(p1);
        Patient.GetTotalPatients();
    }
}
