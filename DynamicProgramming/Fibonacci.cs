namespace DynamicProgramming;

public class Fibonacci
{
    public static uint FibonacciInefficient(uint n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        return FibonacciInefficient(n - 1) + FibonacciInefficient(n - 2);
    }

    public static uint FibonacciMemo(uint n)
    {
        static uint FiboancciMemo(uint n, uint[] memo)
        {
            if (n == 0 || n == 1) return n;

            if (memo[n] == 0)
            {
                memo[n] = FiboancciMemo(n - 1, memo) + FiboancciMemo(n - 2, memo);
            }

            return memo[n];
        }

        var memo = new uint[n + 1];
        return FiboancciMemo(n, memo);
    }

    public static uint FibonacciTopDown(uint n)
    {
        if (n == 0) return 0;
        uint a = 0;
        uint b = 1;

        for (var i = 2; i < n; i++)
        {
            var c = a + b;
            a = b;
            b = c;
        }

        return a + b;
    }
}