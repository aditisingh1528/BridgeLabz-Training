using System;

namespace TrafficManagerApp
{
    public class TrafficMenu
    {
        public static void ShowMenu()
        {
            IVehicleManager Manager = new TrafficUtilityImpl();
            int Choice;

            do
            {
                Console.WriteLine("\n--- Traffic Manager Menu ---");
                Console.WriteLine("1. Enter Vehicle");
                Console.WriteLine("2. Exit Vehicle");
                Console.WriteLine("3. Display Roundabout");
                Console.WriteLine("0. Exit");
                Console.Write("Enter Choice: ");

                Choice = int.Parse(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        Console.Write("Enter Vehicle Number: ");
                        string VehicleNumber = Console.ReadLine();
                        Manager.EnterVehicle(VehicleNumber);
                        break;

                    case 2:
                        Manager.ExitVehicle();
                        break;

                    case 3:
                        Manager.DisplayRoundabout();
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            while (Choice != 0);
        }
    }
}