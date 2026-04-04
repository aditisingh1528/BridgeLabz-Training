using System;

// Sealed implementation class
public sealed class FitnessTrackerImpl
{
    // Handles all menu logic
    public void HandleChoice(int choice, Workout cardio, Workout strength)
    {
        switch (choice)
        {
            case 1:
                cardio.StartWorkout();
                break;

            case 2:
                cardio.EndWorkout();
                break;

            case 3:
                strength.StartWorkout();
                break;

            case 4:
                strength.EndWorkout();
                break;

            case 5:
                Console.WriteLine("Exiting FitTrack");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}