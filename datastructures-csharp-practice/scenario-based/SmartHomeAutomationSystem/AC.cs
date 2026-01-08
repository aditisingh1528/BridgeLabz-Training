using System;

// AC class inherits Appliance
public class AC : Appliance
{
    // Constructor
    public AC(string name) : base(name)
    {
    }

    // Turn ON the AC
    public override void TurnOn()
    {
        if (!isOn)
        {
            isOn = true;
            Console.WriteLine("AC turned on");
        }
        else
        {
            Console.WriteLine("AC is already on");
        }
    }

    // Turn OFF the AC
    public override void TurnOff()
    {
        if (isOn)
        {
            isOn = false;
            Console.WriteLine("AC turned off");
        }
        else
        {
            Console.WriteLine("AC is already off");
        }
    }
}