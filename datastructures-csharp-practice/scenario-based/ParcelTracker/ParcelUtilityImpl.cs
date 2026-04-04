using System;

namespace ParcelTrackerApp
{
    public class ParcelUtilityImpl : IParcelTracker
    {
        private ParcelStage Head;

        public void AddStage(string StageName)
        {
            ParcelStage NewStage = new ParcelStage(StageName);

            if (Head == null)
            {
                Head = NewStage;
                return;
            }

            ParcelStage Temp = Head;
            while (Temp.GetNext() != null)
            {
                Temp = Temp.GetNext();
            }
            Temp.SetNext(NewStage);
        }

        public void AddCheckpointAfter(string ExistingStage, string NewStage)
        {
            ParcelStage Temp = Head;

            while (Temp != null)
            {
                if (Temp.GetStageName().Equals(ExistingStage))
                {
                    ParcelStage NewNode = new ParcelStage(NewStage);
                    NewNode.SetNext(Temp.GetNext());
                    Temp.SetNext(NewNode);
                    Console.WriteLine("Checkpoint added successfully");
                    return;
                }

                Temp = Temp.GetNext();
            }

            Console.WriteLine("Stage not found");
        }
        

        public void TrackParcel()
        {
            if (Head == null)
            {
                Console.WriteLine("Parcel is missing (No tracking data)");
                return;
            }

            ParcelStage Temp = Head;
            Console.Write("Tracking Status: ");

            while (Temp != null)
            {
                Console.Write(Temp.GetStageName());

                if (Temp.GetNext() != null)
                    Console.Write(" -> ");

                Temp = Temp.GetNext();
            }
            Console.WriteLine();
        }
    }
}