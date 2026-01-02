using System;

interface IRefuelable
{
    void Refuel();
}

class Vehicle
{
    protected string Model;
    public Vehicle(string m) { Model = m; }
}

class PetrolVehicle : Vehicle, IRefuelable
{
    public PetrolVehicle(string m) : base(m) { }
    public void Refuel() => Console.WriteLine("Refueling");
}

class Program
{
    static void Main()
    {
        PetrolVehicle v = new PetrolVehicle("Honda");
        v.Refuel();
    }
}
