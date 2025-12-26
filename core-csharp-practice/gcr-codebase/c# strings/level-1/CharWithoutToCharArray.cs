using System;

public class CharWithoutToCharArray{
    static char[] GetChars(string str){
		
        char[] chars = new char[str.Length];
        for (int i = 0; i < str.Length; i++){
            chars[i] = str[i];
        }
        return chars;
    }
	
    static void Main(){
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
		
        Console.WriteLine("Using loop:");
        foreach (char c in GetChars(str))
            Console.Write(c + " ");
			
        Console.WriteLine("\nUsing ToCharArray():");
        foreach (char c in str.ToCharArray())
            Console.Write(c + " ");
    }
}