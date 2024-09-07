namespace DynamicProgramming;

public class Coins
{
    public static int Change(int amount, int[] coins)
    {
        var cache = new Dictionary<(int, int), int>();
        return Change(0, 0);

        int Change(int i, int a)
        {
            if (a == amount) return 1;
            if (a > amount) return 0;
            if (cache.ContainsKey((i, a))) return cache[(i, a)];

            cache[(i, a)] = Change(i, a + coins[i]) + Change(i + 1, a);
            return cache[(i, a)];
        }
    }

    public static int ChangeForNormalPeople(int amount, int[] coins)
    {
        var memo = new int[amount + 1, coins.Length];
        return Change(amount, coins, 0, memo);

        static int Change(int total, int[] coins, int coinIndex, int[,] memo)
        {
            if (memo[total, coinIndex] > 0)
            {
                return memo[total, coinIndex];
            }

            var coin = coins[coinIndex];
            if (coinIndex == coins.Length - 1)
            {
                var remainder = total % coin;
                return remainder == 0 ? 1 : 0;
            }

            var res = 0;
            for (var amount = 0; amount < total; amount += coin)
            {
                res += Change(total - amount, coins, coinIndex + 1, memo);
            }

            memo[total, coinIndex] = res;
            return res;
        }
    }
}