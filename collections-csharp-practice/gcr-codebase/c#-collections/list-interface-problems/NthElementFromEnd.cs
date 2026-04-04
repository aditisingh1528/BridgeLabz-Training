using System;
using System.Collections.Generic;

class NthElementFromEnd
{
    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>(new[] { "A", "B", "C", "D", "E" });
        int n = 2;

        var first = list.First;
        var second = list.First;

        for (int i = 0; i < n; i++)
            first = first.Next;

        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        Console.WriteLine(second.Value);
    }
}