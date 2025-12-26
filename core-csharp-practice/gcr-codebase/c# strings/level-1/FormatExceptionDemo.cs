using System;

public class FormatExceptionDemo{
    static void Main(){
        try{
            string value = "abc";
            int number = int.Parse(value);
        }
        catch (FormatException e){
            Console.WriteLine("Exception caught: " + e.GetType().Name);
        }
    }
}
