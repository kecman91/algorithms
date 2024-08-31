using System.Linq;
using System.Text;

namespace NQueenProblem;

public class NQueen
{
    private List<string> _solutions = [];
    private int _n;
    private int[,] _matrix;
    private HashSet<int> _columns = []; // queen in column
    private HashSet<int> _positiveDiagonal = []; // (r + c)
    private HashSet<int> _negativeDiagonal = []; // (r - c)

    public NQueen(int n)
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
            StringBuilder sb = new();
            for (int i = 0; i < _n; i++)
            {
                var stringRow = Enumerable.Range(0, _n)
                                    .Select(j => _matrix[i, j].ToString())
                                    .ToArray();
                string rowString = string.Join(",", stringRow);
                sb.Append(rowString + "\n");
            }
            _solutions.Add(sb.ToString());
            return;
        }

        for (int col = 0; col < _n; col++)
        {
            if (_columns.Contains(col) || _positiveDiagonal.Contains(row + col) || _negativeDiagonal.Contains(row - col))
            {
                continue;
            }

            _matrix[row, col] = 1;
            _columns.Add(col);
            _positiveDiagonal.Add(row + col);
            _negativeDiagonal.Add(row - col);

            Backtrack(row + 1);

            _matrix[row, col] = 0;
            _columns.Remove(col);
            _positiveDiagonal.Remove(row + col);
            _negativeDiagonal.Remove(row - col);
        }
    }
}