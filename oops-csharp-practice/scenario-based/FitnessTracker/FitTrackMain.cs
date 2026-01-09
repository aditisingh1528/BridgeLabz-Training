using System;

// Main class
class FitTrackMain
{
    static void Main()
    {
        UserProfile user = new UserProfile("Aditi", 21);

        Workout cardio = new CardioWorkout("Running");
        Workout strength = new StrengthWorkout("Weight Training");

        FitnessTrackerImpl tracker = new FitnessTrackerImpl();

        while (true)
        {
            Console.WriteLine("\nFitTrack Menu");
            Console.WriteLine("1. Start Cardio Workout");
            Console.WriteLine("2. End Cardio Workout");
            Console.WriteLine("3. Start Strength Workout");
            Console.WriteLine("4. End Strength Workout");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            // Delegating switch case to impl class
            tracker.HandleChoice(choice, cardio, strength);
        }
    }
}
