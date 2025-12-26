using System;

public class IndexOutOfRangeDemo{
    static void Main(){
        try{
            string str = "Hello";
            Console.WriteLine(str[10]);
        }
        catch (IndexOutOfRangeException e){
            Console.WriteLine("Exception caught: " + e.GetType().Name);
        }
    }
}
