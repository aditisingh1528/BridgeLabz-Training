using System;

// Strength workout class
public class StrengthWorkout : Workout
{
    public StrengthWorkout(string name) : base(name) { }

    public override void StartWorkout()
    {
        if (!isActive)
        {
            isActive = true;
            Console.WriteLine("Strength workout started");
        }
        else
        {
            Console.WriteLine("Strength workout already running");
        }
    }

    public override void EndWorkout()
    {
        if (isActive)
        {
            isActive = false;
            Console.WriteLine("Strength workout ended");
        }
        else
        {
            Console.WriteLine("Strength workout not active");
        }
    }
}
