using System;
using System.Collections.Generic;

class AtmDispenserDSA
{
    static void Main()
    {
        int amount = 880;

        // Scenario A: All notes available
        Console.WriteLine("----- Scenario A: All Notes Available -----");
        LinkedList<int> notesA = new LinkedList<int>(
            new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 }
        );
        Dispense(amount, notesA);

        // Scenario B: 500 note removed
        Console.WriteLine("\n----- Scenario B: Without ₹500 -----");
        LinkedList<int> notesB = new LinkedList<int>(
            new int[] { 200, 100, 50, 20, 10, 5, 2, 1 }
        );
        Dispense(amount, notesB);

        // Scenario C: Fallback case
        Console.WriteLine("\n----- Scenario C: Fallback -----");
        LinkedList<int> limitedNotes = new LinkedList<int>(
            new int[] { 5, 2 }
        );
        Dispense(amount, limitedNotes);
    }

    static void Dispense(int amount, LinkedList<int> denominations)
    {
        // HashMap
        Dictionary<int, int> noteCount = new Dictionary<int, int>();

        // Stack to simulate dispensing notes
        Stack<int> dispensedNotes = new Stack<int>();

        int remaining = amount;

        // Traverse LinkedList
        foreach (int note in denominations)
        {
            int count = remaining / note;
            if (count > 0)
            {
                noteCount[note] = count;
                remaining -= note * count;

                // Push notes into stack
                for (int i = 0; i < count; i++)
                    dispensedNotes.Push(note);
            }
        }

        int dispensedAmount = amount - remaining;

        // Output
        if (remaining == 0)
            Console.WriteLine("Exact amount dispensed: ₹" + dispensedAmount);
        else
            Console.WriteLine("Exact amount not possible. Fallback dispensed: ₹" + dispensedAmount);

        Console.WriteLine("Notes given:");

        // Display using stack
        Dictionary<int, int> display = new Dictionary<int, int>();
        while (dispensedNotes.Count > 0)
        {
            int note = dispensedNotes.Pop();
            if (!display.ContainsKey(note))
                display[note] = 0;
            display[note]++;
        }

        foreach (var item in display)
            Console.WriteLine(item.Key + " x " + item.Value);

        if (remaining > 0)
            Console.WriteLine("Remaining (not dispensable): ₹" + remaining);
    }
}