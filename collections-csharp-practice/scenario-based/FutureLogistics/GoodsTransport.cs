using System;

namespace FutureLogistics.Model
{
    // Base abstract class
    public abstract class GoodsTransport
    {
        protected string transportId;
        protected string transportDate;
        protected int transportRating;

        // Constructor
        public GoodsTransport(string transportId,
                              string transportDate,
                              int transportRating)
        {
            this.transportId = transportId;
            this.transportDate = transportDate;
            this.transportRating = transportRating;
        }

        public string TransportId { get { return transportId; } }
        public string TransportDate { get { return transportDate; } }
        public int TransportRating { get { return transportRating; } }

        // Abstract methods
        public abstract string VehicleSelection();
        public abstract float CalculateTotalCharge();
    }
}