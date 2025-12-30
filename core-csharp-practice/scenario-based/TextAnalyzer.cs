using System;

public class TextAnalyzer{
    static void AnalyzeText(string text, string oldWord, string newWord){
        
        int Count = 1; //counting words
        for (int i = 0; i < text.Length; i++){
            if (text[i] == ' ')
            {
                Count++;
            }
        }
        int currentLength = 0;
        int maxLength = 0;
        string longestWord = "";
        string currentWord = ""; //finding longest word

        for (int i = 0; i < text.Length; i++){
            if (text[i] != ' '){
                currentLength++;
                currentWord += text[i];
            }
            else{
                if (currentLength > maxLength){
                    maxLength = currentLength;
                    longestWord = currentWord;
                }
                currentLength = 0;
                currentWord = "";
            }
        }
        string result = "";
        currentWord = ""; // Replacing word

        for (int i = 0; i < text.Length; i++){
            if (text[i] != ' '){
                currentWord += text[i];
            }
            else{
                if (currentWord.ToLower() == oldWord.ToLower()){
                    result += newWord;
                }
                else{
                    result += currentWord;
                }

                result += " ";
                currentWord = "";
            }
        }
        Console.WriteLine();
        Console.WriteLine("Word Count: " + Count);
        Console.WriteLine("Longest Word: " + longestWord);
        Console.WriteLine("Updated Paragraph: " + result);
    }
	
    static void Main(string[] args){
        int choice;

        do{
            Console.WriteLine("TEXT ANALYZER MENU");
            Console.WriteLine("1. Analyze Text");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice){
                case 1:
                    Console.WriteLine("Enter paragraph:");
                    string text = Console.ReadLine();

                    Console.WriteLine("Enter word to replace:");
                    string oldWord = Console.ReadLine();

                    Console.WriteLine("Enter replacement word:");
                    string newWord = Console.ReadLine();

                    AnalyzeText(text, oldWord, newWord);
                    break;

                case 2:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        }
		while (choice != 2);
    }
}