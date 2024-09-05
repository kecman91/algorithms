namespace DynamicProgramming;

public class RecursiveMultiply
{
    public static int Multiply(int a, int b)
    {
        if (b == 1)
        {
            return a;
        }

        return a + Multiply(a, b - 1);
    }

    public static int MultiplyImproved(int a, int b)
    {
        static int MultiplyImprovedHelper(int smaller, int bigger)
        {
            if (smaller == 0) return 0;
            if (smaller == 1) return bigger;

            var s = smaller >> 1; // divide by 2
            var halfProd = MultiplyImprovedHelper(s, bigger);

            if (smaller % 2 == 0)
            {
                return halfProd + halfProd;
            }
            else
            {
                return halfProd + halfProd + bigger;
            }
        }

        int smaller = a < b ? a : b;
        int bigger = a > b ? a : b;

        return MultiplyImprovedHelper(smaller, bigger);
    }
}