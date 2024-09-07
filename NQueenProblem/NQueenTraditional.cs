using System.Text;

namespace NQueenProblem;

public class NQueenTraditional
{
    private List<string> _solutions = [];
    private int _n;
    private int[,] _matrix;

    public NQueenTraditional(int n)
    {
        _n = n;
        _matrix = new int[n,n];
    }

    public void PlaceNQueens()
    {
        Backtrack(0);

        foreach (var solution in _solutions)
        {
            Console.WriteLine(solution);
        }
    }

    private void Backtrack(int row)
    {
        if (row == _n)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _n; j++)
                {
                    sb.Append(_matrix[i,j] + ",");
                }
                sb.Append('\n');
            }
            _solutions.Add(sb.ToString());
            return;
        }

        for (var col = 0; col < _n; col++)
        {
            if (CheckColumn(col) || CheckNegativeDiagonal(row, col) || CheckPositiveDiagonal(row, col))
            {
                continue;
            }

            _matrix[row,col] = 1;

            Backtrack(row + 1);

            _matrix[row,col] = 0;
        }
    }

    private bool CheckColumn(int col)
    {
        for (var i = 0; i < _n; i++)
        {
            if (_matrix[i, col] == 1)
            {
                return true;
            }
        }

        return false;
    }

    private bool CheckNegativeDiagonal(int row, int col)
    {
        var i = row;
        var j = col;
        while (i < _n && j < _n)
        {
            if (_matrix[i++,j++] == 1)
            {
                return true;
            }
        }

        i = row;
        j = col;
        while (i >= 0 && j >= 0)
        {
            if (_matrix[i--,j--] == 1)
            {
                return true;
            }
        }

        return false;
    }

    private bool CheckPositiveDiagonal(int row, int col)
    {
        var i = row;
        var j = col;
        while (i < _n && j >= 0)
        {
            if (_matrix[i++,j--] == 1)
            {
                return true;
            }
        }

        i = row;
        j = col;
        while (i >= 0 && j < _n)
        {
            if (_matrix[i--,j++] == 1)
            {
                return true;
            }
        }

        return false;
    }
}