namespace RotateMatrix;

public static class RotateMatrix
{
    public static void Rotate90(int[,] m)
    {
        var n = m.GetLength(0);

        for (var i = 0; i < n/2; i++)
        {
            for (var j = i; j < n-i-1; j++)
            {
                var top = m[i, j];
                m[i, j] = m[j, n-i-1];
                m[j, n-i-1] = m[n-i-1, n-j-1];
                m[n-i-1, n-j-1] = m[n-j-1,i];
                m[n-j-1,i] = top;
            }
        }
    }
}