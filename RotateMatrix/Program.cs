using RM = RotateMatrix.RotateMatrix;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Define the size of the matrix
int rows = 6;
int cols = 6;

// Create a 5x5 matrix
int[,] matrix = new int[rows, cols];

// Initialize the matrix with some values
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = i * cols + j; // Example value
    }
}

Print(matrix);

Console.WriteLine("Matrix rotated 90 degrees");
RM.Rotate90(matrix);

Print(matrix);

// Print the matrix
static void Print(int[,] matrix)
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