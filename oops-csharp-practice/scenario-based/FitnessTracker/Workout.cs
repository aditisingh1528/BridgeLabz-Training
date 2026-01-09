using System;

// Abstract base class
public abstract class Workout : ITrackable
{
    protected string workoutName;
    protected bool isActive;

    // Constructor
    public Workout(string workoutName)
    {
        this.workoutName = workoutName;
        isActive = false;
    }

    public abstract void StartWorkout();
    public abstract void EndWorkout();
}