using System;

class RocketLaunch{
    static void Main(){
		Console.WriteLine("Enter the number: ");
        int counter = int.Parse(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
