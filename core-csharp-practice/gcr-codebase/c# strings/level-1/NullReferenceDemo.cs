using System;

public class NullReferenceDemo{
    static void Main(){
        try{
            string str = null;
            Console.WriteLine(str.Length);
        }
        catch (NullReferenceException e){
            Console.WriteLine("Exception caught: " + e.GetType().Name);
        }
    }
}
