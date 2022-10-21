namespace AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide._01_ChallengeProblems;

public static class _01_1480_RunningSumOf1DArray
{
    /// <summary>
    /// https://leetcode.com/problems/running-sum-of-1d-array/
    /// </summary>
    public static int[] RunningSum(int[] nums)
    {
        var runningSum = new int[nums.Length];
        runningSum[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            runningSum[i] = runningSum[i - 1] + nums[i];
        }

        return runningSum;
    }
}