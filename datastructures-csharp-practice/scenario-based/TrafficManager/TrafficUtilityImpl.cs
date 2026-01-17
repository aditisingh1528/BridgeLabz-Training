using System;

namespace TrafficManagerApp
{
    public sealed class TrafficUtilityImpl : IVehicleManager
    {
        private Roundabout Roundabout;
        private WaitingQueue WaitingQueue;

        public TrafficUtilityImpl()
        {
            Roundabout = new Roundabout();
            WaitingQueue = new WaitingQueue();
        }

        public void EnterVehicle(string VehicleNumber)
        {
            Vehicle Vehicle = new Vehicle(VehicleNumber);
            Roundabout.AddVehicle(Vehicle);
            Console.WriteLine("Vehicle entered roundabout.");
        }

        public void ExitVehicle()
        {
            Roundabout.RemoveVehicle();
        }

        public void DisplayRoundabout()
        {
            Roundabout.PrintRoundabout();
        }
    }
}