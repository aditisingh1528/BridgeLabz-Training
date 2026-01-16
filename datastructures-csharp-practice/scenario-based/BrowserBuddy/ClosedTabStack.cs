using System;

class ClosedTabStack
{
    private Tab[] stack;
    private int top;

    public ClosedTabStack(int size)
    {
        this.stack = new Tab[size];
        this.top = -1;
    }

    public void Push(Tab tab)
    {
        if (this.top < this.stack.Length - 1)
        {
            this.stack[++this.top] = tab;
            System.Console.WriteLine("Tab closed and saved");
        }
    }

    public Tab Pop()
    {
        if (this.top >= 0)
        {
            System.Console.WriteLine("Tab restored");
            return this.stack[this.top--];
        }

        System.Console.WriteLine("No closed tabs");
        return null;
    }
}