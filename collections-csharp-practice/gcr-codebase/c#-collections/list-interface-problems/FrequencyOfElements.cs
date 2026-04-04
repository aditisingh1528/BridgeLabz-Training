using System;
using System.Collections.Generic;

class FrequencyOfElements
{
    static void Main()
    {
        string[] items = { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (string item in items)
        {
            if (freq.ContainsKey(item))
                freq[item]++;
            else
                freq[item] = 1;
        }

        foreach (var kv in freq)
            Console.WriteLine(kv.Key + " : " + kv.Value);
    }
}