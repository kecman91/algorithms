namespace ZeroMatrix;

public static class ZeroMatrix
{
    public static void ZeroRowsColumns(int[,] matrix)
    {
        var n = matrix.GetLength(0);
        var m = matrix.GetLength(1);
        var zeroRows = new bool[n];
        var zeroCols = new bool[m];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                if (matrix[i,j] == 0)
                {
                    zeroRows[i] = true;
                    zeroCols[j] = true;
                }
            }
        }

        // zero rows
        for (var row = 0; row < n; row++)
        {
            if (zeroRows[row])
            {
                NullifyRow(matrix, row);
            }
        }

        // zero columns
        for (var col = 0; col < m; col++)
        {
            if (zeroCols[col])
            {
                NullifyColumn(matrix, col);
            }
        }
    }

    private static void NullifyRow(int[,] matrix, int row)
    {
        for (var col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row,col] = 0;
        }
    }

    private static void NullifyColumn(int[,] matrix, int col)
    {
        for (var row = 0; row < matrix.GetLength(0); row++)
        {
            matrix[row,col] = 0;
        }
    }
}