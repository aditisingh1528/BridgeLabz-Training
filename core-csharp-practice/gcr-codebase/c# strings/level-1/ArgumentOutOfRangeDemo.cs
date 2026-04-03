using System;

public class ArgumentOutOfRangeDemo{
    static void Main(){
        try{
            string str = "Hello";
            Console.WriteLine(str.Substring(4, 5));
        }
        catch (ArgumentOutOfRangeException e){
            Console.WriteLine("Exception caught: " + e.GetType().Name);
        }
    }
}
