using System;

public class WordLength2D{
    static int GetLength(string word){
        int count = 0;
        foreach (char c in word)
            count++;
        return count;
    }
	
    static string[,] SplitWords(string text){
        string[] wordsTemp = new string[100];
        int wordCount = 0;
        string current = "";
		
        for (int i = 0; i < text.Length; i++){
            if (text[i] != ' ')
                current += text[i];
            else{
                wordsTemp[wordCount++] = current;
                current = "";
            }
        }
        wordsTemp[wordCount++] = current;
		
        string[,] result = new string[wordCount, 2];
        for (int i = 0; i < wordCount; i++){
            result[i, 0] = wordsTemp[i];
            result[i, 1] = GetLength(wordsTemp[i]).ToString();
        }
        return result;
    }
	
    static void Main(){
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
		
        string[,] data = SplitWords(text);
		
        Console.WriteLine("Word\tLength");
        for (int i = 0; i < data.GetLength(0); i++)
            Console.WriteLine(data[i, 0] + "\t" + data[i, 1]);
    }
}
