using System;

// Cardio workout class
public class CardioWorkout : Workout
{
    public CardioWorkout(string name) : base(name) { }

    public override void StartWorkout()
    {
        if (!isActive)
        {
            isActive = true;
            Console.WriteLine("Cardio workout started");
        }
        else
        {
            Console.WriteLine("Cardio workout already running");
        }
    }

    public override void EndWorkout()
    {
        if (isActive)
        {
            isActive = false;
            Console.WriteLine("Cardio workout ended");
        }
        else
        {
            Console.WriteLine("Cardio workout not active");
        }
    }
}