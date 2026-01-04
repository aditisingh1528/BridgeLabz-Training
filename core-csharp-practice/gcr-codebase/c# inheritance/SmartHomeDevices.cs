using System;

class Device
{
    protected int DeviceId;
    protected string Status;

    public Device(int id, string status)
    {
        DeviceId = id;
        Status = status;
    }
}

class Thermostat : Device
{
    private int Temperature;

    public Thermostat(int id, string status, int temp) : base(id, status)
    {
        Temperature = temp;
    }

    public void Display()
    {
        Console.WriteLine($"Temp: {Temperature} | Status: {Status}");
    }
}

class Program
{
    static void Main()
    {
        Thermostat t = new Thermostat(1, "ON", 24);
        t.Display();
    }
}
