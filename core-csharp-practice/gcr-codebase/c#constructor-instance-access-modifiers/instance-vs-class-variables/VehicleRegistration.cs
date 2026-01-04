using System;

class Vehicle
{
    // Instance variables
    string ownerName;
    string vehicleType;

    // Class variable
    static double registrationFee = 2000;

    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance method
    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner: {ownerName}, Vehicle: {vehicleType}, Fee: {registrationFee}");
    }

    // Class method
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }

    static void Main()
    {
        Vehicle v1 = new Vehicle("Aditi", "Car");
        Vehicle v2 = new Vehicle("Aman", "Bike");

        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();

        Vehicle.UpdateRegistrationFee(2500);

        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();
    }
}