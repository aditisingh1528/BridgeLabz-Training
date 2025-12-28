using System;

public class CountVowelsConsonants{
    static void Main(){
		//taking input string  and converting each character to lowercase
        Console.Write("Enter a string: ");
        string text = Console.ReadLine().ToLower();
		
        int vowels = 0, consonants = 0;
		//counting vowels and consonants
		foreach (char ch in text){
			
            if (ch >= 'a' && ch <= 'z'){
                if ("aeiou".Contains(ch))
                    vowels++;
                else
                    consonants++;
            }
        }
		//output
		Console.WriteLine($"Vowels: {vowels}");
		Console.WriteLine($"Consonants: {consonants}");
    }
}
