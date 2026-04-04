using System;
using System.IO;
using System.Collections.Generic;


class MergeCSV
{
    static void Main(string[] args)
    {
        string[] file1 = File.ReadAllLines("students1.csv");
        string[] file2 = File.ReadAllLines("students2.csv");

        Dictionary<string, string> marksMap = new Dictionary<string, string>();

        for (int i = 1; i < file2.Length; i++){
            string[] d = file2[i].Split(',');
            marksMap[d[0]] = d[1] + "," + d[2];
        }
		

        using (StreamWriter sw = new StreamWriter("merged.csv")){
            sw.WriteLine("ID,Name,Age,Marks,Grade");

            for (int i = 1; i < file1.Length; i++){
                string[] d = file1[i].Split(',');
                if (marksMap.ContainsKey(d[0]))
                {
                    sw.WriteLine(file1[i] + "," + marksMap[d[0]]);
                
				}
            
			}
        
		}

    }

}