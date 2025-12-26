using System;

public class CollinearPoints{
    static void Main(){
        // Sample input points
        int x1 = 2, y1 = 4;
        int x2 = 4, y2 = 6;
        int x3 = 6, y3 = 8;
		
        // Check using slope method
        bool slopeResult = AreCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
		
        // Check using area of triangle method
        bool areaResult = AreCollinearUsingArea(x1, y1, x2, y2, x3, y3);
		
        Console.WriteLine("Using Slope Method: " + (slopeResult ? "Collinear" : "Not Collinear"));
        Console.WriteLine("Using Area Method: " + (areaResult ? "Collinear" : "Not Collinear"));
    }
	
    // Method to check collinearity using slope formula
    static bool AreCollinearUsingSlope(int x1, int y1, int x2, int y2, int x3, int y3){
        // Avoid division, compare cross multiplication
        return (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);
    }
	
    // Method to check collinearity using area of triangle formula
    static bool AreCollinearUsingArea(int x1, int y1, int x2, int y2, int x3, int y3){
        double area = 0.5 * (x1 * (y2 - y3) +
                             x2 * (y3 - y1) +
                             x3 * (y1 - y2));
							 
        return area == 0;
    }
}
