using System;

namespace TrafficManagerApp
{
    public class WaitingQueue
    {
        private Vehicle[] Queue;
        private int Front;
        private int Rear;
        private int Capacity;

        public WaitingQueue()
        {
            Capacity = 3;
            Queue = new Vehicle[Capacity];
            Front = 0;
            Rear = -1;
        }

        public void Enqueue(Vehicle Vehicle)
        {
            if (Rear == Capacity - 1)
            {
                Console.WriteLine("Waiting Queue Overflow.");
                return;
            }

            Rear++;
            Queue[Rear] = Vehicle;
            Console.WriteLine("Vehicle added to waiting queue.");
        }

        public Vehicle Dequeue()
        {
            if (Front > Rear)
            {
                Console.WriteLine("Waiting Queue Underflow.");
                return null;
            }

            Vehicle Vehicle = Queue[Front];
            Front++;
            return Vehicle;
        }
    }
}