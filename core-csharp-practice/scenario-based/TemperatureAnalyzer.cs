using System;

public class TemperatureAnalyzer{
    static void AnalyzeTemperatures(float[,] temperatures){
        int hottestDay = 0;
        int coldestDay = 0;

        float maxTemp = temperatures[0, 0];
        float minTemp = temperatures[0, 0];

        float[] dailyAverage = new float[7];
        
        for (int day = 0; day < 7; day++){ // Looping through each day
            float sum = 0;

            for (int hour = 0; hour < 24; hour++){ // Looping through 24 hours of the day
                float currentTemp = temperatures[day, hour];
                sum = sum + currentTemp;
				
                if (currentTemp > maxTemp){ // Checking for hottest temperature
                    maxTemp = currentTemp;
                    hottestDay = day;
                }

                
                if (currentTemp < minTemp){ // Checking for coldest temperature
                    minTemp = currentTemp;
                    coldestDay = day;
                }
            }

            
            dailyAverage[day] = sum / 24; // Calculating average temperature of the day
        }

        Console.WriteLine("Hottest day index: " + hottestDay + " with temperature " + maxTemp);
        Console.WriteLine("Coldest day index: " + coldestDay + " with temperature " + minTemp);

        Console.WriteLine("Average temperature per day:");
        for (int i = 0; i < dailyAverage.Length; i++){
            Console.WriteLine("Day " + i + ": " + dailyAverage[i]);
        }
    }

    static void Main(string[] args){
        float[,] temperatures = new float[7, 24]; // Sample data for 7 days and 24 hours
		
        // Taking input for temperatures
        for (int day = 0; day < 7; day++){
            Console.WriteLine("Enter temperatures for day " + day);
            for (int hour = 0; hour < 24; hour++){
                temperatures[day, hour] = Convert.ToSingle(Console.ReadLine());
            }
        }
        AnalyzeTemperatures(temperatures);
    }
}
