namespace AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide._01_ChallengeProblems;

public static class _04_1342_NumberOfStepsToReduceANumberToZero
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    /// </summary>
    public static int NumberOfSteps(int num)
    {
        var stepCount = 0;
        while (num > 0)
        {
            if ((num & 1) == 0)
            {
                num >>= 1;
            }
            else
            {
                num -= 1;
            }

            stepCount++;
        }

        return stepCount;
    }
}