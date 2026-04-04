using System;

// Light class inherits Appliance
public class Light : Appliance
{
    // Constructor
    public Light(string name) : base(name)
    {
    }

    // Turn ON the light
    public override void TurnOn()
    {
        if (!isOn)
        {
            isOn = true;
            Console.WriteLine("Light turned on");
        }
        else
        {
            Console.WriteLine("Light is already on");
        }
    }

    // Turn OFF the light
    public override void TurnOff()
    {
        if (isOn)
        {
            isOn = false;
            Console.WriteLine("Light turned off");
        }
        else
        {
            Console.WriteLine("Light is already off");
        }
    }
}