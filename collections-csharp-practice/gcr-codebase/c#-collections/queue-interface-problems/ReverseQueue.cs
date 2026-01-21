using System;
using System.Collections.Generic;

class ReverseQueue
{
    static void Main()
    {
        Queue<int> q = new Queue<int>(new[] { 10, 20, 30 });
        Stack<int> s = new Stack<int>();

        while (q.Count > 0)
            s.Push(q.Dequeue());

        while (s.Count > 0)
            q.Enqueue(s.Pop());

        foreach (int x in q)
            Console.Write(x + " ");
    }
}