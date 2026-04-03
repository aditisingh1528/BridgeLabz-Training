using System;

public class TextFormatter{
    static string Format(string text){
        string formatted = ""; // Stores the final formatted string
        bool SentenceStart = true;

        for (int i = 0; i < text.Length; i++){
            char character = text[i];
            if (character == ' '){ //skipping extra spaces
                if (formatted.Length == 0 || formatted[formatted.Length - 1] == ' '){ // If string is empty or last char is also space, skip
                    continue;
                }

                formatted += ' ';
                continue;
            }
            if (SentenceStart && character >= 'a' && character <= 'z'){ // Capitalize first letter of a sentence
				
                character = (char)(character - 32);
                SentenceStart = false;
            }
            if (character == '.' || character == '?' || character == '!' || character == ','){ //handles punctuation marks
                formatted += character;
                SentenceStart = true;

                if (i + 1 < text.Length && text[i + 1] != ' '){
                    formatted += ' ';
                }

                continue;
            }
			
            formatted += character; //add normal characters
        }
		
        if (formatted.Length > 0 && formatted[formatted.Length - 1] == ' '){ 
            formatted = formatted.Substring(0, formatted.Length - 1);
        }

        return formatted;
    }

    static void Main(string[] args){
		
        Console.WriteLine("Enter your text:");
        string text = Console.ReadLine();

        Console.WriteLine(Format(text));
    }
}