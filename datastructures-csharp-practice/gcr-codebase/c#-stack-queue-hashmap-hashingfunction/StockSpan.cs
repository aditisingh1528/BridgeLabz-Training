using System;
using System.Collections.Generic;

class StockSpan
{
    // Calculates stock span
    static int[] CalculateSpan(int[] prices, int n)
    {
        int[] span = new int[n];
        Stack<int> st = new Stack<int>(); // Store indices

        span[0] = 1;
        st.Push(0);

        for (int i = 1; i < n; i++)
        {
            while (st.Count > 0 && prices[st.Peek()] <= prices[i])
                st.Pop(); // Remove smaller prices

            span[i] = (st.Count == 0) ? (i + 1) : (i - st.Peek());
            st.Push(i);
        }

        return span;
    }
}