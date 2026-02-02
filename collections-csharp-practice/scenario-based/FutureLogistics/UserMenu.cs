using System;
using FutureLogistics.Model;
using FutureLogistics.Utility;

namespace FutureLogistics.Menu
{
    // Handles input/output
    public class UserMenu
    {
        private TransportUtility util = new TransportUtility();

        public void ShowMenu()
        {
            Console.WriteLine("Enter the Goods Transport details");
            string input = Console.ReadLine();

            string transportId = input.Split(':')[0];

            if (!util.ValidateTransportId(transportId))
                return;

            GoodsTransport obj = util.ParseDetails(input);
            string type = util.FindObjectType(obj);

            Console.WriteLine($"Transporter id : {obj.TransportId}");
            Console.WriteLine($"Date of transport : {obj.TransportDate}");
            Console.WriteLine($"Rating of the transport : {obj.TransportRating}");

            if (type == "BrickTransport")
            {
                BrickTransport bt = (BrickTransport)obj;
                Console.WriteLine($"Quantity of bricks : {bt.BrickQuantity}");
                Console.WriteLine($"Brick price : {bt.BrickPrice}");
            }
            else
            {
                TimberTransport tt = (TimberTransport)obj;
                Console.WriteLine($"Type of the timber : {tt.TimberType}");
                Console.WriteLine($"Timber price per kilo : {tt.TimberPrice}");
            }

            Console.WriteLine($"Vehicle for transport : {obj.VehicleSelection()}");
            Console.WriteLine($"Total charge : {obj.CalculateTotalCharge()}");
        }
    }
}