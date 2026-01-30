using System;
using AeroVigil.Util;

namespace AeroVigil.Menu
{
    // Handles user interaction and menu
    public class FlightMenu
    {
        private readonly FlightUtil flightUtil = new FlightUtil();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n✈️ AeroVigil – Flight Validation System");
                Console.WriteLine("1. Validate Flight");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ValidateFlight();
                        break;

                    case 2:
                        Console.WriteLine("Exiting AeroVigil...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private void ValidateFlight()
        {
            try
            {
                Console.Write("Enter Flight Number: ");
                string flightNumber = Console.ReadLine();

                Console.Write("Enter Flight Name: ");
                string flightName = Console.ReadLine();

                Console.Write("Enter Passenger Count: ");
                int passengerCount = int.Parse(Console.ReadLine());

                // Perform validations
                flightUtil.ValidateFlightNumber(flightNumber);
                flightUtil.ValidateFlightName(flightName);
                flightUtil.ValidatePassengerCount(passengerCount, flightName);

                Console.WriteLine("✅ All validations passed. Flight cleared for takeoff.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Validation failed: " + ex.Message);
            }
        }
    }
}