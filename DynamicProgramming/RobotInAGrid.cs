namespace DynamicProgramming;

public class RobotInAGrid
{
    public static (bool, int[,]) FindWay(int[,] grid)
    {
        var n = grid.GetLength(0);
        var m = grid.GetLength(1);
        var result = new int[n,m];

        bool FindWay(int[,] grid, int i, int j)
        {
            if (grid[i,j] == 1) return false;
            if (i == n-1 && j == m-1) 
            {
                result[i,j] = 1;
                return true;
            }

            bool canGoRight = j+1 < m && FindWay(grid, i, j+1);
            bool canGoDown = i+1 < n && FindWay(grid, i+1, j);

            if (canGoRight || canGoDown)
            {
                result[i,j] = 1;
            }

            return canGoRight || canGoDown;
        }

        return (FindWay(grid, 0, 0), result);
    }

    public static (bool, int[,]) FindWayMemo(int[,] grid)
    {
        var n = grid.GetLength(0) - 1;
        var m = grid.GetLength(1) - 1;
        var failedFields = new HashSet<(int,int)>();
        var result = new int[n+1,m+1];

        bool FindWay(int[,] grid, int i, int j)
        {
            if (i > n || j > m || grid[i,j] == 1) return false;
            if (failedFields.Contains((i,j))) return false;

            if ((i == n && j == m) || FindWay(grid, i, j+1) || FindWay(grid, i+1, j))
            {
                result[i,j] = 1;
                return true;
            }

            failedFields.Add((i,j));
            return false;
        }

        return (FindWay(grid, 0, 0), result);
    }
}