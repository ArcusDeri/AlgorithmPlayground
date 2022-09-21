namespace AlgorithmPlayground.LeetCode.Chapters.Arrays;

public static class _12_MoveZeroes
{
    public static void MoveZeroes(int[] nums)
    {
        var zeroIterator = -1;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0 && zeroIterator == -1)
            {
                zeroIterator = i;
                continue;
            }

            if (nums[i] != 0 && zeroIterator > -1)
            {
                nums[zeroIterator++] = nums[i];
                nums[i] = 0;   
            }
        }
    }
}
