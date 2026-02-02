using System;
using System.Text.RegularExpressions;
using FutureLogistics.Model;

namespace FutureLogistics.Utility
{
    // Utility methods
    public class TransportUtility
    {
        // Validate transportId
        public bool ValidateTransportId(string transportId)
        {
            bool valid = Regex.IsMatch(transportId, "^RTS[0-9]{3}[A-Z]$");

            if (!valid)
            {
                Console.WriteLine($"Transport id {transportId} is invalid");
                Console.WriteLine("Please provide a valid record");
            }

            return valid;
        }

        // Parse input and return object
        public GoodsTransport ParseDetails(string input)
        {
            string[] data = input.Split(':');
            string type = data[3];

            if (type.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
            {
                return new BrickTransport(
                    data[0], data[1], int.Parse(data[2]),
                    float.Parse(data[4]), int.Parse(data[5]),
                    float.Parse(data[6]));
            }
            else
            {
                return new TimberTransport(
                    data[0], data[1], int.Parse(data[2]),
                    float.Parse(data[4]), float.Parse(data[5]),
                    data[6], float.Parse(data[7]));
            }
        }

        // Identify object type
        public string FindObjectType(GoodsTransport obj)
        {
            if (obj is BrickTransport) return "BrickTransport";
            return "TimberTransport";
        }
    }
}