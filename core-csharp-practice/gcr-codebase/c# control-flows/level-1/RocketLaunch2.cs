using System;

class RocketLaunch2{
    static void Main(){
		
		Console.WriteLine("Enter the countdown number: ");
        int counter = int.Parse(Console.ReadLine());

        for (int i = counter; i >= 1; i--){
            Console.WriteLine(i);
        }
    }
}
