using System;

namespace TrafficManagerApp
{
    public class VehicleNode
    {
        public Vehicle Data;
        public VehicleNode Next;

        public VehicleNode(Vehicle Vehicle)
        {
            Data = Vehicle;
            Next = null;
        }
    }
}