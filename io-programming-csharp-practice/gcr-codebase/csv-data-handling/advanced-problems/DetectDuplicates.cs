using System;
using System.IO;
using System.Collections.Generic;

class DetectDuplicates
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("students.csv");
        HashSet<string> ids = new HashSet<string>();

        for (int i = 1; i < lines.Length; i++){
            string id = lines[i].Split(',')[0];

            if (!ids.Add(id)){
                Console.WriteLine("Duplicate Record: " + lines[i]);
            
			}
        
		}
    
	}
}