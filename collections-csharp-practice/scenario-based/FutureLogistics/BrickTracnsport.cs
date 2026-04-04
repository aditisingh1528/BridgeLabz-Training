using System;

namespace FutureLogistics.Model
{
    // Handles brick transport
    public class BrickTransport : GoodsTransport
    {
        private float brickSize;
        private int brickQuantity;
        private float brickPrice;

        public BrickTransport(string transportId, string transportDate,
            int transportRating, float brickSize,
            int brickQuantity, float brickPrice)
            : base(transportId, transportDate, transportRating)
        {
            this.brickSize = brickSize;
            this.brickQuantity = brickQuantity;
            this.brickPrice = brickPrice;
        }

        // Select vehicle based on quantity
        public override string VehicleSelection()
        {
            if (brickQuantity < 300)
                return "Truck";
            if (brickQuantity <= 500)
                return "Lorry";
            return "MonsterLorry";
        }

        // Calculate total charge
        public override float CalculateTotalCharge()
        {
            float price = brickPrice * brickQuantity;
            float tax = price * 0.3f;
            float discount = GetDiscount(price);
            float vehiclePrice = GetVehiclePrice();

            return (price + tax + vehiclePrice) - discount;
        }

        private float GetVehiclePrice()
        {
            string vehicle = VehicleSelection().ToLower();

            if (vehicle == "truck") return 1000;
            if (vehicle == "lorry") return 1700;
            return 3000;
        }

        private float GetDiscount(float price)
        {
            if (transportRating == 5) return price * 0.20f;
            if (transportRating == 3 || transportRating == 4) return price * 0.10f;
            return 0;
        }

        public int BrickQuantity => brickQuantity;
        public float BrickPrice => brickPrice;
    }
}