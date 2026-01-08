using System;

// Abstract base class for all appliances
public abstract class Appliance : IControllable
{
	
    protected string name;
    protected bool isOn;

    // Constructor to initialize appliance name
    public Appliance(string name){
		
        this.name = name;
        isOn = false;
    }

    // Abstract methods to be implemented by child classes
    public abstract void TurnOn();
    public abstract void TurnOff();
}