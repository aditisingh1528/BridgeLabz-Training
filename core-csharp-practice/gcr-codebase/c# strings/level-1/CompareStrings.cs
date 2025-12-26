using System;

public class CompareStrings{
    static bool CompareUsingCharAt(string s1, string s2){
        if (s1.Length != s2.Length) return false;
		
        for (int i = 0; i < s1.Length; i++){
            if (s1[i] != s2[i]) return false;
        }
        return true;
    }
	
    static void Main(){
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();
		
        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();
		
        Console.WriteLine("Using charAt logic: " + CompareUsingCharAt(s1, s2));
        Console.WriteLine("Using Equals(): " + s1.Equals(s2));
    }
}
