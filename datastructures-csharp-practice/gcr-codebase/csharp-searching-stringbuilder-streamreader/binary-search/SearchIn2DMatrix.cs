using System;

class SearchIn2DMatrix
{
    static bool SearchMatrix(int[,] matrix, int rows, int cols, int target)
    {
        int low = 0;
        int high = rows * cols - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            int row = mid / cols;
            int col = mid % cols;

            if (matrix[row, col] == target)
            {
                return true;
            }
            else if (matrix[row, col] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of columns:");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter matrix elements row by row:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter target value:");
        int target = Convert.ToInt32(Console.ReadLine());

        bool found = SearchMatrix(matrix, rows, cols, target);

        if (found)
        {
            Console.WriteLine("Target found in matrix");
        }
        else
        {
            Console.WriteLine("Target not found in matrix");
        }
    }
}