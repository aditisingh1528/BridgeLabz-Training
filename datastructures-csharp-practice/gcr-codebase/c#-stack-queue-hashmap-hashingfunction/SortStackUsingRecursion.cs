using System;
using System.Collections.Generic;

class SortStackUsingRecursion
{
    // Sorts stack using recursion
    static void SortStack(Stack<int> stack)
    {
        if (stack.Count == 0)
            return;

        int top = stack.Pop();
        SortStack(stack);
        InsertSorted(stack, top);
    }

    static void InsertSorted(Stack<int> stack, int element)
    {
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element);
            return;
        }

        int top = stack.Pop();
        InsertSorted(stack, element);
        stack.Push(top);
    }
}