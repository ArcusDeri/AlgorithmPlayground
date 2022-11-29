using System.Text;

namespace AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._03_IntroductionToString;

public static class _07_AddBinary
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/array-and-string/203/introduction-to-string/1160/
    /// </summary>
    public static string AddBinary(string a, string b)
    {
        var resultBuilder = new StringBuilder();
        var aIndex = a.Length - 1;
        var bIndex = b.Length - 1;
        var carry = 0;

        while (aIndex >= 0 || bIndex >= 0 || carry > 0)
        {
            var valA = aIndex >= 0 ? int.Parse(a[aIndex--].ToString()) : 0;
            var valB = bIndex >= 0 ? int.Parse(b[bIndex--].ToString()) : 0;
            var valC = valA + valB + carry;

            if (valC == 0)
            {
                resultBuilder.Insert(0, '0');
            }
            else if (valC == 1)
            {
                carry = 0;
                resultBuilder.Insert(0, '1');
            }
            else if (valC == 2)
            {
                carry = 1;
                resultBuilder.Insert(0, '0');
            }
            else if (valC == 3)
            {
                carry = 1;
                resultBuilder.Insert(0, '1');
            }
        }

        return resultBuilder.ToString();
    }
}