using System;

public class MostFrequentCharacter{
    static void Main(){
		//taking input string
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        int maxCount = 0;
        char mostFrequent = text[0];
		
        for (int i = 0; i < text.Length; i++){
            int count = 0;

            for (int j = 0; j < text.Length; j++){
                if (text[i] == text[j])
                    count++;
            }

            if (count > maxCount){
                maxCount = count;
                mostFrequent = text[i];
            }
        }

        Console.WriteLine($"Most Frequent Character: '{mostFrequent}'");
    }
}
