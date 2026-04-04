using System;
using System.Collections;

class ReverseLists
{
    static void Main()
    {
        // ArrayList
        ArrayList arr = new ArrayList { 1, 2, 3, 4, 5 };
        for (int i = 0, j = arr.Count - 1; i < j; i++, j--)
        {
            object temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        Console.WriteLine("Reversed ArrayList:");
        foreach (var x in arr)
            Console.Write(x + " ");

        Console.WriteLine();

        // LinkedList
        LinkedList<int> list = new LinkedList<int>(new[] { 1, 2, 3, 4, 5 });
        Stack<int> stack = new Stack<int>(list);
        list.Clear();

        while (stack.Count > 0)
            list.AddLast(stack.Pop());

        Console.WriteLine("Reversed LinkedList:");
        foreach (var x in list)
            Console.Write(x + " ");
    }
}