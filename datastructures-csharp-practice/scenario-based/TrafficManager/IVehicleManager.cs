using System;

namespace TrafficManagerApp
{
    public interface IVehicleManager
    {
        void EnterVehicle(string VehicleNumber);
        void ExitVehicle();
        void DisplayRoundabout();
    }
}