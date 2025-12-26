using System;

public class ToLowerAscii{
    static string ConvertToLower(string text)
    {
        char[] result = new char[text.Length];
		
        for (int i = 0; i < text.Length; i++){
            char c = text[i];
            if (c >= 'A' && c <= 'Z')
                result[i] = (char)(c + 32);
            else
                result[i] = c;
        }
        return new string(result);
    }
	
    static void Main(){
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
		
        Console.WriteLine("Using ASCII logic: " + ConvertToLower(text));
        Console.WriteLine("Using ToLower(): " + text.ToLower());
    }
}
