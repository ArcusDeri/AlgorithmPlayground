namespace AlgorithmPlayground.LeetCode.Chapters.ArrayAndString.IntroductionToArray;

public static class _03_PlusOne
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1148/
    /// </summary>
    public static int[] PlusOne(int[] digits)
    {
        var carry = 0;
        digits[digits.Length - 1] += 1;

        for (var i = digits.Length - 1; i > -1; i--)
        {
            digits[i] += carry;
            if (digits[i] > 9)
            {
                digits[i] %= 10;
                carry = 1;
            }
            else
            {
                carry = 0;
            }
        }
        
        return carry == 0 ? digits : (new[] {1}).Concat(digits).ToArray();
    }
}