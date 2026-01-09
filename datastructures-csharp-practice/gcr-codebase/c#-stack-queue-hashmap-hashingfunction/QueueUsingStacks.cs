using System;
using System.Collections.Generic;

class QueueUsingStacks
{
    private Stack<int> inStack = new Stack<int>();  // For enqueue
    private Stack<int> outStack = new Stack<int>(); // For dequeue

    public void Enqueue(int data)
    {
        inStack.Push(data); // Add element
        Console.WriteLine(data + " enqueued");
    }

    public int Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        if (outStack.Count == 0)
        {
            while (inStack.Count > 0)
                outStack.Push(inStack.Pop()); // Transfer elements
        }

        return outStack.Pop(); // Remove front
    }

    public bool IsEmpty()
    {
        return inStack.Count == 0 && outStack.Count == 0;
    }
}
