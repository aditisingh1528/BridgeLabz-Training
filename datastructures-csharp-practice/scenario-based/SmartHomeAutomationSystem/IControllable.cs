using System;

// Interface that defines basic ON/OFF actions
public interface IControllable
{
	// Method to turn appliance ON
    void TurnOn();
	
	// Method to turn appliance OFF
    void TurnOff();
}