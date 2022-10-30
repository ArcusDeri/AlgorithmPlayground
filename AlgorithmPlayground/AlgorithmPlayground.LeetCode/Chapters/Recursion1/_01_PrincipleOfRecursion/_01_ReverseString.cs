namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1._01_PrincipleOfRecursion
{
    public static class _01_ReverseString
    {
        public static void ReverseString(char[] s)
        {
            Helper(0, s.Length - 1, s);
        }

        private static void Helper(int left, int right, char[] s)
        {
            if (left < right)
            {
                (s[left], s[right]) = (s[right], s[left]);
                Helper(left + 1, right - 1, s);
            }
        }
    }
}
