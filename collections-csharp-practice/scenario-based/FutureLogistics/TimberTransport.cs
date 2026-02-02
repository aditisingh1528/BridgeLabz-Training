using System;

namespace FutureLogistics.Model
{
    // Handles timber transport
    public class TimberTransport : GoodsTransport
    {
        private float timberLength;
        private float timberRadius;
        private string timberType;
        private float timberPrice;

        public TimberTransport(string transportId, string transportDate,
            int transportRating, float timberLength,
            float timberRadius, string timberType, float timberPrice)
            : base(transportId, transportDate, transportRating)
        {
            this.timberLength = timberLength;
            this.timberRadius = timberRadius;
            this.timberType = timberType;
            this.timberPrice = timberPrice;
        }

        // Select vehicle based on area
        public override string VehicleSelection()
        {
            double area = 2 * 3.147 * timberRadius * timberLength;

            if (area < 250) return "Truck";
            if (area <= 400) return "Lorry";
            return "MonsterLorry";
        }

        // Calculate total charge
        public override float CalculateTotalCharge()
        {
            double volume = 3.147 * timberRadius * timberRadius * timberLength;

            double rate = timberType.Equals("Premium",
                StringComparison.OrdinalIgnoreCase) ? 0.25 : 0.15;

            double price = volume * timberPrice * rate;
            double tax = price * 0.3;
            double discount = GetDiscount(price);
            double vehiclePrice = GetVehiclePrice();

            return (float)((price + tax + vehiclePrice) - discount);
        }

        private double GetVehiclePrice()
        {
            string vehicle = VehicleSelection().ToLower();

            if (vehicle == "truck") return 1000;
            if (vehicle == "lorry") return 1700;
            return 3000;
        }

        private double GetDiscount(double price)
        {
            if (transportRating == 5) return price * 0.20;
            if (transportRating == 3 || transportRating == 4) return price * 0.10;
            return 0;
        }

        public string TimberType => timberType;
        public float TimberPrice => timberPrice;
    }
}