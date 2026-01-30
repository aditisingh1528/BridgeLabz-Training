using System;
using OceanFleet.Model;
using OceanFleet.Util;

namespace OceanFleet.Menu
{
    // Handles user interaction
    public class OceanFleetMenu
    {
        private VesselUtil util = new VesselUtil();

        public void ShowMenu()
        {
            Console.WriteLine("Enter the number of vessels to be added");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter vessel details");
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split(':');

                Vessel vessel = new Vessel(
                    data[0],
                    data[1],
                    double.Parse(data[2]),
                    data[3]
                );

                util.AddVesselPerformance(vessel);
            }

            Console.WriteLine("Enter the Vessel Id to check speed");
            string searchId = Console.ReadLine();

            Vessel found = util.GetVesselById(searchId);

            if (found != null)
            {
                Console.WriteLine(
                    $"{found.VesselId} | {found.VesselName} | {found.VesselType} | {found.AverageSpeed} knots");
            }
            else
            {
                Console.WriteLine($"Vessel Id {searchId} not found");
            }

            Console.WriteLine("High performance vessels are");

            var highSpeedVessels = util.GetHighPerformanceVessels();

            foreach (var vessel in highSpeedVessels)
            {
                Console.WriteLine(
                    $"{vessel.VesselId} | {vessel.VesselName} | {vessel.VesselType} | {vessel.AverageSpeed} knots");
            }
        }
    }
}