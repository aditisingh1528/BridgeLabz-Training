using System;

namespace TrafficManagerApp
{
    public class Vehicle
    {
        private string VehicleNumber;

        public Vehicle(string VehicleNumber)
        {
            this.VehicleNumber = VehicleNumber;
        }

        public string GetVehicleNumber()
        {
            return VehicleNumber;
        }

        public void SetVehicleNumber(string VehicleNumber)
        {
            this.VehicleNumber = VehicleNumber;
        }

    }
}