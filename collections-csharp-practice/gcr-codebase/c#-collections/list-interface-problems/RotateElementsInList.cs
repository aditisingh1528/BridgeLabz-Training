using System;
using System.Collections.Generic;

class RotateElementsInList
{
    static void Main()
    {
        List<int> list = new List<int> { 10, 20, 30, 40, 50 };
        int k = 2;
        k = k % list.Count;

        List<int> result = new List<int>();
        result.AddRange(list.GetRange(k, list.Count - k));
        result.AddRange(list.GetRange(0, k));

        foreach (int x in result)
            Console.Write(x + " ");
    }
}