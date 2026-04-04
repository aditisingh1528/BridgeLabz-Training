using System;
using System.Collections.Generic;

class GenerateBinaryNumbers
{
    static void Main()
    {
        int N = 5;
        Queue<string> q = new Queue<string>();
        q.Enqueue("1");

        for (int i = 0; i < N; i++)
        {
            string curr = q.Dequeue();
            Console.Write(curr + " ");
            q.Enqueue(curr + "0");
            q.Enqueue(curr + "1");
        }
    }
}