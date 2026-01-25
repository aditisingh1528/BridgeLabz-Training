using System;

class NestedTryCatch
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter index to access: ");
            int index = int.Parse(Console.ReadLine());

            try
            {
                int value = arr[index];

                Console.Write("Enter divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                try
                {
                    int result = value / divisor;
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
			
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        
		}
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        
		}
    }

}