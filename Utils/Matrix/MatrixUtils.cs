namespace Utils.Matrix;

public static class MatrixUtils
{
    public static void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t"); // Print each value with a tab space
            }
            Console.WriteLine(); // New line after each row
        }
    }
}