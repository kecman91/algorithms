namespace DynamicProgramming;

public class Staircase
{
    public static int CountSteps(int n)
    {
        if (n < 0) return 0;
        if (n == 0) return 1;

        return CountSteps(n - 1) + CountSteps(n - 2) + CountSteps(n - 3);
    }

    public static int CountStepsMemo(int n)
    {
        var memo = new int[n + 1];
        for (int i = 0; i <= n ; i++)
        {
            memo[i] = -1;
        }

        static int CountStepsMemo(int n, int[] memo)
        {
            if (n < 0) return 0;
            if (n == 0) return 1;
            if (memo[n] > -1) return memo[n];

            memo[n] = CountStepsMemo(n - 1, memo) + CountStepsMemo(n - 2, memo) + CountStepsMemo(n - 3, memo);
            return memo[n];
        }

        return CountStepsMemo(n, memo);
    }
}