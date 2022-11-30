namespace AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._03_IntroductionToString;

public static class _08_ImplementStrStr
{
    public static int StrStr(string haystack, string needle)
    {
        var hLength = haystack.Length;
        var nLength = needle.Length;
        var result = -1;
        if (hLength < nLength)
        {
            return result;
        }

        for (int i = 0; i < hLength; i++)
        {
            if (hLength - i < nLength)
            {
                return -1;
            }

            if (haystack[i] != needle[0])
            {
                continue;
            }

            result = i;
            for (int j = 0, k = i; j < nLength; j++, k++)
            {
                if (haystack[k] != needle[j])
                {
                    result = -1;
                    break;
                }
            }

            if (result != -1)
            {
                return result;
            }
        }

        return result;
    }
}