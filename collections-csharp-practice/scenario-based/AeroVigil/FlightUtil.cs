using System;
using System.Text.RegularExpressions;

namespace AeroVigil.Util
{
    // Utility class for flight validations
    public class FlightUtil
    {
        // Validate flight number (Format: 2 uppercase letters + 3 digits)
        public bool ValidateFlightNumber(string flightNumber)
        {
            if (string.IsNullOrEmpty(flightNumber))
                throw new Exception("Flight number cannot be empty");

            if (!Regex.IsMatch(flightNumber, "^[A-Z]{2}[0-9]{3}$"))
                throw new Exception("Invalid flight number format");

            return true;
        }

        // Validate flight name (minimum 3 characters)
        public bool ValidateFlightName(string flightName)
        {
            if (string.IsNullOrEmpty(flightName))
                throw new Exception("Flight name cannot be empty");

            if (flightName.Length < 3)
                throw new Exception("Flight name must have at least 3 characters");

            return true;
        }

        // Validate passenger count based on flight type
        public bool ValidatePassengerCount(int passengerCount, string flightName)
        {
            if (passengerCount <= 0)
                throw new Exception("Passenger count must be greater than zero");

            if (flightName.ToLower().Contains("international") && passengerCount > 300)
                throw new Exception("International flight cannot exceed 300 passengers");

            if (flightName.ToLower().Contains("domestic") && passengerCount > 180)
                throw new Exception("Domestic flight cannot exceed 180 passengers");

            return true;
        }
    }
}