using System;

namespace TrafficManagerApp
{
    public class Roundabout
    {
        private VehicleNode Head;

        public void AddVehicle(Vehicle Vehicle)
        {
            VehicleNode NewNode = new VehicleNode(Vehicle);

            if (Head == null)
            {
                Head = NewNode;
                NewNode.Next = Head;
                return;
            }

            VehicleNode Temp = Head;
            while (Temp.Next != Head)
            {
                Temp = Temp.Next;
            }

            Temp.Next = NewNode;
            NewNode.Next = Head;
        }

        public void RemoveVehicle()
        {
            if (Head == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            if (Head.Next == Head)
            {
                Console.WriteLine("Vehicle exited: " + Head.Data.GetVehicleNumber());
                Head = null;
                return;
            }

            VehicleNode Temp = Head;
            while (Temp.Next != Head)
            {
                Temp = Temp.Next;
            }

            Console.WriteLine("Vehicle exited: " + Head.Data.GetVehicleNumber());
            Temp.Next = Head.Next;
            Head = Head.Next;
        }

        public void PrintRoundabout()
        {
            if (Head == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            VehicleNode Temp = Head;
            Console.Write("Roundabout: ");

            do
            {
                Console.Write(Temp.Data.GetVehicleNumber() + " -> ");
                Temp = Temp.Next;
            }
            while (Temp != Head);

            Console.WriteLine("(back to start)");
        }
    }
}