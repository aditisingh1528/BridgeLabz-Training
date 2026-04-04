using System;
using System.IO;


class LargeCSVReader
{
    static void Main(string[] args)
    {
        int count = 0;
        int batchSize = 100;

        using (StreamReader sr = new StreamReader("bigfile.csv")){
            string line;
            int batchCount = 0;


            while ((line = sr.ReadLine()) != null){
                batchCount++;
                count++;

                if (batchCount == batchSize){
                    Console.WriteLine("Processed records: " + count);
                    batchCount = 0;
                
				}
            
			
			}
    
		}

	}
}