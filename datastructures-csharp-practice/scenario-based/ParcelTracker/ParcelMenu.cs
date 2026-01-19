using System;

namespace ParcelTrackerApp
{
    public class ParcelMenu
    {
        private ParcelUtilityImpl Tracker = new ParcelUtilityImpl();

        public void ShowMenu()
        {
            //Default stages
            Tracker.AddStage("Tracked");
            Tracker.AddStage("Shipped");
            Tracker.AddStage("In Transit");
            Tracker.AddStage("Delivered");

            while (true)
            {
                Console.WriteLine("\n1. Track Parcel");
                Console.WriteLine("2. Add custom checkpoint");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter a choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Tracker.TrackParcel();
                        break;

                    case 2:
                        Console.WriteLine("Enter existing stage: ");
                        string Existing = Console.ReadLine();
                        Console.WriteLine("Enter new checkpoint");
                        string NewStage = Console.ReadLine();

                        Tracker.AddCheckpointAfter(Existing, NewStage);
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}