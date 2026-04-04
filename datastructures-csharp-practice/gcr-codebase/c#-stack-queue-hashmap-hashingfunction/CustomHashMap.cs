using System;

class HashNode
{
    public int Key;
    public int Value;
    public HashNode Next; // For chaining

    public HashNode(int key, int value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}

class CustomHashMap
{
    private HashNode[] buckets;
    private int size;

    public CustomHashMap(int size)
    {
        this.size = size;
        buckets = new HashNode[size]; // Bucket array
    }

    private int GetIndex(int key)
    {
        return Math.Abs(key) % size; // Hash function
    }

    public void Put(int key, int value)
    {
        int index = GetIndex(key);
        HashNode head = buckets[index];

        if (head == null)
        {
            buckets[index] = new HashNode(key, value);
            return;
        }

        HashNode current = head;
        while (current != null)
        {
            if (current.Key == key)
            {
                current.Value = value; // Update value
                return;
            }

            if (current.Next == null)
                break;

            current = current.Next;
        }

        current.Next = new HashNode(key, value); // Collision handling
    }

    public int Get(int key)
    {
        int index = GetIndex(key);
        HashNode current = buckets[index];

        while (current != null)
        {
            if (current.Key == key)
                return current.Value;

            current = current.Next;
        }

        return -1; // Not found
    }

    public void Remove(int key)
    {
        int index = GetIndex(key);
        HashNode current = buckets[index];
        HashNode prev = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (prev == null)
                    buckets[index] = current.Next;
                else
                    prev.Next = current.Next;
                return;
            }

            prev = current;
            current = current.Next;
        }
    }

    public void Display()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("Bucket " + i + ": ");
            HashNode current = buckets[i];

            while (current != null)
            {
                Console.Write("[" + current.Key + "," + current.Value + "] -> ");
                current = current.Next;
            }

            Console.WriteLine("null");
        }
    }
}