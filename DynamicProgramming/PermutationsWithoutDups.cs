namespace DynamicProgramming;

public class PermutationsWithoutDups
{
    public static List<string> FindPermutations(string str)
    {
        var res = new List<string>();
        if (str.Length == 0)
        {
            res.Add(string.Empty);
            return res;
        }
        
        var firstChar = str.ElementAt(0);
        var permutationsSoFar = FindPermutations(str[1..]);
    
        foreach (var permutation in permutationsSoFar)
        {
            for (var j = 0; j <= permutation.Length; j++)
            {
                res.Add(InsertChar(permutation, firstChar, j));
            }
        }

        return res;
    }

    private static string InsertChar(string str, char c, int index)
    {
        var left = str[..index];
        var right = str[index..];
        return left + c + right;
    }
}