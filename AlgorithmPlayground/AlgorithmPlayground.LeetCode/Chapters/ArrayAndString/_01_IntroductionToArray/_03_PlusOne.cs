namespace AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._01_IntroductionToArray;

public static class _03_PlusOne
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1148/
    /// </summary>
    public static int[] PlusOne(int[] digits)
    {
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        var newDigits = new int[digits.Length + 1];
        newDigits[0] = 1;
        Array.Copy(digits, 0, newDigits, 1, digits.Length);

        return newDigits;
    }
}