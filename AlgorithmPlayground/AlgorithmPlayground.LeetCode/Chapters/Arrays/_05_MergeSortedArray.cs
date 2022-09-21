namespace AlgorithmPlayground.LeetCode.Chapters.Arrays;

public static class _05_MergeSortedArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3253/
    /// </summary>
    public static void Merge(int[] nums1, int m, int[] nums2, int n) {
        int tail1 = m - 1, tail2 = n - 1, finished = m + n - 1;
        while (tail1 >= 0 && tail2 >= 0)
        {
            nums1[finished] = nums1[tail1] > nums2[tail2] ? nums1[tail1--] : nums2[tail2--];
            finished--;
        }

        while (tail2 >= 0)
        {
            nums1[finished] = nums2[tail2];
            finished--;
            tail2--;
        }
    }
}