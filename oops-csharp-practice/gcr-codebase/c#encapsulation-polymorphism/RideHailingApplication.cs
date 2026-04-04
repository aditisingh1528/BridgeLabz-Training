using System;
using System.Collections.Generic

interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string location);
}

abstract class Vehicle
{
    private int vehicleId;
    private string driverName;
    protected double ratePerKm;

    protected Vehicle(int id, string driver, double rate)
    {
        vehicleId = id;
        driverName = driver;
        ratePerKm = rate;
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine($"Driver: {driverName}");
    }
}

class Car : Vehicle, IGPS
{
    public Car(int id, string driver, double rate)
        : base(id, driver, rate) { }

    public override double CalculateFare(double distance) => distance * ratePerKm;
    public string GetCurrentLocation() => "Current Location";
    public void UpdateLocation(string location) { }
}