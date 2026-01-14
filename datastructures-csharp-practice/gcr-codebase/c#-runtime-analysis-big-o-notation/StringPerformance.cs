using System;
using System.Diagnostics;
using System.Text;

class StringPerformance
{
    static void Main()
    {
        int n = 10000;
        Stopwatch sw = new Stopwatch();

        // string
        sw.Start();
        string s = "";
        for (int i = 0; i < n; i++)
            s += "A";
        sw.Stop();
        Console.WriteLine("String Time: " + sw.ElapsedMilliseconds + " ms");

        // StringBuilder
        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
            sb.Append("A");
        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
    }
}