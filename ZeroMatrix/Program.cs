// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Define the dimensions of the matrix
int rows = 5;
int cols = 7;

// Create a 5x7 matrix
int[,] matrix = new int[rows, cols];

// Random number generator
Random rand = new Random();

// Initialize the matrix with random values
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        // Randomly decide if the element should be zero or non-zero
        if (rand.Next(0, 10) == 0)
        {
            matrix[i, j] = 0; // 50% chance of zero
        }
        else
        {
            matrix[i, j] = rand.Next(1, 101); // Random number between 1 and 100
        }
    }
}

PrintMatrix(rows, cols, matrix);

Console.WriteLine("-----------------------");
ZeroMatrix.ZeroMatrix.ZeroRowsColumns(matrix);

// Print the matrix
PrintMatrix(rows, cols, matrix);

static void PrintMatrix(int rows, int cols, int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + "\t"); // Print each value with a tab space
        }
        Console.WriteLine(); // New line after each row
    }
}