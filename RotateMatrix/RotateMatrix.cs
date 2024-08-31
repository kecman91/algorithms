namespace RotateMatrix;

public static class RotateMatrix
{
    public static void Rotate90(int[,] m)
    {
        var n = m.GetLength(0)-1;

        for (var layer = 0; layer <= n/2; layer++)
        {
            for (var i = layer; i <= n-layer; i++)
            {
                int offset = i - layer;
                var top = m[layer, i];
                m[layer, i] = m[n-layer-offset, layer];
                m[n-layer-offset, layer] = m[n-layer, n-layer-offset];
                m[n-layer, n-layer-offset] = m[i,n-layer];
                m[i,n-layer] = top;
            }
        }
    }
}