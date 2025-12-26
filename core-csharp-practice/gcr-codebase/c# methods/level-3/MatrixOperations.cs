using System;

public class MatrixOperations{
    static void Main(){
        int rows = 3, cols = 3;

        int[,] A = CreateRandomMatrix(rows, cols);
        int[,] B = CreateRandomMatrix(rows, cols);

        Console.WriteLine("Matrix A:");
        DisplayMatrix(A);

        Console.WriteLine("\nMatrix B:");
        DisplayMatrix(B);

        Console.WriteLine("\nAddition (A + B):");
        DisplayMatrix(AddMatrices(A, B));

        Console.WriteLine("\nSubtraction (A - B):");
        DisplayMatrix(SubtractMatrices(A, B));

        Console.WriteLine("\nMultiplication (A x B):");
        DisplayMatrix(MultiplyMatrices(A, B));

        Console.WriteLine("\nTranspose of A:");
        DisplayMatrix(TransposeMatrix(A));

        Console.WriteLine("\nDeterminant of A (3x3): " + Determinant3x3(A));

        Console.WriteLine("\nInverse of A (3x3):");
        double[,] inverse = Inverse3x3(A);
        if (inverse != null)
            DisplayMatrix(inverse);
        else
            Console.WriteLine("Inverse not possible (Determinant = 0)");
    }
	
    // Create random matrix
    static int[,] CreateRandomMatrix(int rows, int cols){
        Random rand = new Random();
        int[,] matrix = new int[rows, cols];
		
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = rand.Next(1, 10);

        return matrix;
    }
	
    // Add matrices
    static int[,] AddMatrices(int[,] A, int[,] B){
        int[,] result = new int[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                result[i, j] = A[i, j] + B[i, j];
        return result;
    }
	
    // Subtract matrices
    static int[,] SubtractMatrices(int[,] A, int[,] B){
        int[,] result = new int[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
                result[i, j] = A[i, j] - B[i, j];
        return result;
    }

    // Multiply matrices
    static int[,] MultiplyMatrices(int[,] A, int[,] B){
        int[,] result = new int[A.GetLength(0), B.GetLength(1)];

        for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < B.GetLength(1); j++)
                for (int k = 0; k < A.GetLength(1); k++)
                    result[i, j] += A[i, k] * B[k, j];

        return result;
    }
	
    // Transpose matrix
    static int[,] TransposeMatrix(int[,] matrix){
        int[,] transpose = new int[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                transpose[j, i] = matrix[i, j];
        return transpose;
    }
	
    // Determinant of 2x2
    static int Determinant2x2(int[,] m){
        return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
    }
	
    // Determinant of 3x3
    static int Determinant3x3(int[,] m){
        return m[0,0] * (m[1,1] * m[2,2] - m[1,2] * m[2,1])
             - m[0,1] * (m[1,0] * m[2,2] - m[1,2] * m[2,0])
             + m[0,2] * (m[1,0] * m[2,1] - m[1,1] * m[2,0]);
    }
	
    // Inverse of 3x3 matrix
    static double[,] Inverse3x3(int[,] m){
        int det = Determinant3x3(m);
        if (det == 0) return null;
		
        double[,] inv = new double[3, 3];
		
        inv[0,0] =  (m[1,1]*m[2,2] - m[1,2]*m[2,1]) / (double)det;
        inv[0,1] = -(m[0,1]*m[2,2] - m[0,2]*m[2,1]) / (double)det;
        inv[0,2] =  (m[0,1]*m[1,2] - m[0,2]*m[1,1]) / (double)det;
		
        inv[1,0] = -(m[1,0]*m[2,2] - m[1,2]*m[2,0]) / (double)det;
        inv[1,1] =  (m[0,0]*m[2,2] - m[0,2]*m[2,0]) / (double)det;
        inv[1,2] = -(m[0,0]*m[1,2] - m[0,2]*m[1,0]) / (double)det;
		
        inv[2,0] =  (m[1,0]*m[2,1] - m[1,1]*m[2,0]) / (double)det;
        inv[2,1] = -(m[0,0]*m[2,1] - m[0,1]*m[2,0]) / (double)det;
        inv[2,2] =  (m[0,0]*m[1,1] - m[0,1]*m[1,0]) / (double)det;
		
        return inv;
    }
	
    // Display matrix (int / double)
    static void DisplayMatrix(int[,] matrix){
        for (int i = 0; i < matrix.GetLength(0); i++){
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }
	
    static void DisplayMatrix(double[,] matrix){
        for (int i = 0; i < matrix.GetLength(0); i++){
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(Math.Round(matrix[i, j], 2) + "\t");
            Console.WriteLine();
        }
    }
}
