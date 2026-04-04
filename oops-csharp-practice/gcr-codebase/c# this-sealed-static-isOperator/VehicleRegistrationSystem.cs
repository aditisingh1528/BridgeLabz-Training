using System;

class Vehicle
{
    public static double RegistrationFee = 5000;
    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string ownerName, string vehicleType, string regNumber)
    {
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = regNumber;
    }

    public static void UpdateRegistrationFee(double fee)
    {
        RegistrationFee = fee;
    }

    public void Display(object obj)
    {
        if (obj is Vehicle)
        {
            Console.WriteLine(OwnerName + " - " + VehicleType);
        }
    }
}

class Program
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("Rahul", "Car", "MH12AB1234");
        v1.Display(v1);
        Vehicle.UpdateRegistrationFee(6000);
    }
}
