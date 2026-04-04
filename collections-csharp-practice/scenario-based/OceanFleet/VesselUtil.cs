using System.Collections.Generic;
using OceanFleet.Model;

namespace OceanFleet.Util
{
    // Utility class for vessel operations
    public class VesselUtil
    {
        // List to store vessels
        private List<Vessel> vesselList = new List<Vessel>();

        public List<Vessel> VesselList
        {
            get { return vesselList; }
            set { vesselList = value; }
        }

        // Add vessel to list
        public void AddVesselPerformance(Vessel vessel)
        {
            vesselList.Add(vessel);
        }

        // Get vessel by vesselId (case-sensitive)
        public Vessel GetVesselById(string vesselId)
        {
            foreach (var vessel in vesselList)
            {
                if (vessel.VesselId == vesselId)
                    return vessel;
            }
            return null;
        }

        // Get vessels with highest average speed
        public List<Vessel> GetHighPerformanceVessels()
        {
            List<Vessel> result = new List<Vessel>();

            if (vesselList.Count == 0)
                return result;

            double maxSpeed = vesselList[0].AverageSpeed;

            foreach (var vessel in vesselList)
            {
                if (vessel.AverageSpeed > maxSpeed)
                    maxSpeed = vessel.AverageSpeed;
            }

            foreach (var vessel in vesselList)
            {
                if (vessel.AverageSpeed == maxSpeed)
                    result.Add(vessel);
            }

            return result;
        }
    }
}