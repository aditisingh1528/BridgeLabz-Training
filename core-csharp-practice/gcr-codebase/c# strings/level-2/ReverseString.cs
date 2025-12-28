using System;

public class ReverseString{
    static void Main(){
		//taking input
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        string reversed = "";
		//reversing
        for (int i = text.Length - 1; i >= 0; i--)
            reversed += text[i];
		//output
        Console.WriteLine("Reversed String: " + reversed);
    }
}
