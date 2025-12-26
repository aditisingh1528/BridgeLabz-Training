using System;

public class SubstringCharAt{
    static string CreateSubstring(string str, int start, int end){
        string result = "";
        for (int i = start; i < end; i++){
            result += str[i];
        }
        return result;
    }
	
    static void Main(){
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
		
        Console.Write("Enter start index: ");
        int start = int.Parse(Console.ReadLine());
		
        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());
		
        Console.WriteLine("Using charAt: " + CreateSubstring(str, start, end));
        Console.WriteLine("Using Substring(): " + str.Substring(start, end - start));
    }
}
