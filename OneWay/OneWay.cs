namespace OneWay;

public static class OneWay
{
    public static bool OneEditAway(char[] str1, char[] str2)
    {
        if (str1.Length <= str2.Length)
        {
            return IsOneEditAway(str1, str2);
        }
        else
        {
            return IsOneEditAway(str2, str1);
        }
    }

    private static bool IsOneEditAway(char[] str1, char[] str2)
    {
        var foundDiff = false;
        var addToStr2Index = 0;
        for (int i = 0; 0 < str1.Length; i++)
        {
            if (str1[i] != str2[i+addToStr2Index])
            {
                if (foundDiff)
                {
                    return false;
                }

                foundDiff = true;
                if (str2.Length > str1.Length - addToStr2Index)
                {
                    addToStr2Index++;
                }
            }
        }

        return true;
    }
}