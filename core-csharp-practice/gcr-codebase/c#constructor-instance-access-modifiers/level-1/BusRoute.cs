using System;

class BusRoute
{
    int totalDistance = 0;

    public void AddDistance(int distance)
    {
        totalDistance += distance;
    }

    public void ShowTotalDistance()
    {
        Console.WriteLine("\nJourney completed");
        Console.WriteLine("Total distance travelled: " + totalDistance + " km");
    }
}

class BusRouteDistanceTracker
{
    static void Main()
    {
        BusRoute bus = new BusRoute();
        int stopNumber = 1;
        string getOff = "no";

        Console.WriteLine("Welcome to the Bus Route Distance Tracker\n");

        while (getOff != "yes")
        {
            Console.WriteLine("Arrived at Stop " + stopNumber);

            // ✅ message changes after first stop
            if (stopNumber == 1)
            {
                Console.Write("Enter the distance covered till this stop (in km): ");
            }
            else
            {
                Console.Write("Enter the distance covered from last stop to this stop (in km): ");
            }

            int distance = Convert.ToInt32(Console.ReadLine());
            bus.AddDistance(distance);

            while (true)
            {
                Console.Write("Would you like to get off at this stop? (yes/no): ");
                getOff = Console.ReadLine().ToLower();

                if (getOff == "yes" || getOff == "no")
                    break;

                Console.WriteLine("Invalid input. Please type only yes or no.");
            }

            stopNumber++;
            Console.WriteLine();
        }

        bus.ShowTotalDistance();
    }
}
