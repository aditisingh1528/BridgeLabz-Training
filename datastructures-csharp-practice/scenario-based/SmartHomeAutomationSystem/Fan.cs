using System;

// Fan class inherits Appliance
public class Fan : Appliance
{
    // Constructor
    public Fan(string name) : base(name)
    {
    }

    // Turn ON the fan
    public override void TurnOn()
    {
        if (!isOn)
        {
            isOn = true;
            Console.WriteLine("Fan turned on");
        }
        else
        {
            Console.WriteLine("Fan is already on");
        }
    }

    // Turn OFF the fan
    public override void TurnOff()
    {
        if (isOn)
        {
            isOn = false;
            Console.WriteLine("Fan turned off");
        }
        else
        {
            Console.WriteLine("Fan is already off");
        }
    }
}