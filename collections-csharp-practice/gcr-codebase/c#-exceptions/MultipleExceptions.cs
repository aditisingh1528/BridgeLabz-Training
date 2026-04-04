using System;

class MultipleExceptions
{
    static void Main(string[] args)
    {
        int[] arr = null;

        try
        {
            Console.Write("Enter number of elements: ");
            int size = int.Parse(Console.ReadLine());

            if (size > 0)
            {
                arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter element " + i + ": ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Enter index to access: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Value at index " + index + ": " + arr[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}