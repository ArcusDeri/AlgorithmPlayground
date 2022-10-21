namespace AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide._01_ChallengeProblems;

public static class _06_383_RansomNote
{
    /// <summary>
    /// https://leetcode.com/problems/ransom-note/
    /// </summary>
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        var dict = new Dictionary<char, int>();

        foreach (var key in magazine)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }

        foreach (var key in ransomNote)
        {
            if (!dict.ContainsKey(key) || dict[key] == 0)
            {
                return false;
            }

            dict[key]--;
        }

        return true;
    }
}