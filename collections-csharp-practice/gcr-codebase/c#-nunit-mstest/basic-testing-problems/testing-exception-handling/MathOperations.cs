using System;

public class MathOperations
{
    //method to divide two numbers
    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new ArithmeticException("Division by zero is not allowed");
        }

        return a / b;
    }
}
