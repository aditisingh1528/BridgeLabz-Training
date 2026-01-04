using System;

class Vehicle
{
    protected int MaxSpeed;
    protected string FuelType;

    public Vehicle(int speed, string fuel)
    {
        MaxSpeed = speed;
        FuelType = fuel;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{MaxSpeed} km/h | {FuelType}");
    }
}

class Car : Vehicle
{
    public Car(int s, string f) : base(s, f) { }
    public override void DisplayInfo() => Console.WriteLine("Car");
}

class Truck : Vehicle
{
    public Truck(int s, string f) : base(s, f) { }
    public override void DisplayInfo() => Console.WriteLine("Truck");
}

class Motorcycle : Vehicle
{
    public Motorcycle(int s, string f) : base(s, f) { }
    public override void DisplayInfo() => Console.WriteLine("Motorcycle");
}

class Program
{
    static void Main()
    {
        Vehicle v1 = new Car(180, "Petrol");
        Vehicle v2 = new Truck(120, "Diesel");
        Vehicle v3 = new Motorcycle(150, "Petrol");

        v1.DisplayInfo();
        v2.DisplayInfo();
        v3.DisplayInfo();
    }
}
