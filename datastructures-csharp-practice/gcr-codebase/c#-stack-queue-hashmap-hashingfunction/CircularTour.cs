using System;
using System.Collections.Generic;

class CircularTour
{
    // Returns starting petrol pump index
    static int FindStartingPump(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        Queue<int> queue = new Queue<int>(); // Stores pump indices

        int balance = 0;
        int index = 0;
        int count = 0;

        while (count < 2 * n) // Loop for circular check
        {
            int diff = petrol[index] - distance[index];
            balance += diff;
            queue.Enqueue(index);

            // Remove pumps if balance becomes negative
            while (balance < 0 && queue.Count > 0)
            {
                int removed = queue.Dequeue();
                balance -= (petrol[removed] - distance[removed]);
            }

            if (queue.Count == n)
            {
                return queue.Peek(); // Valid start found
            }

            index = (index + 1) % n;
            count++;
        }

        return -1; // No possible tour
    }

    static void Main(string[] args)
    {
        int[] petrol = { 6, 3, 7 };
        int[] distance = { 4, 6, 3 };

        int start = FindStartingPump(petrol, distance);

        if (start != -1)
            Console.WriteLine("Start at petrol pump index: " + start);
        else
            Console.WriteLine("No possible circular tour");
    }
}