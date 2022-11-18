using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1;

public class _11_UniqueBinarySearchTreesII
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/253/conclusion/2384/
    /// </summary>
    public static IList<TreeNode?> GenerateTrees(int n)
    {
        return n == 0 ? new List<TreeNode?>() : InnerGenerateTrees(1, n);
    }

    private static IList<TreeNode?> InnerGenerateTrees(int start, int end)
    {
        if (start > end)
        {
            return new List<TreeNode?> {null};
        }

        var allTrees = new List<TreeNode?>();
        for (var currentRootValue = start; currentRootValue < end + 1; currentRootValue++)
        {
            var allLeftSubtrees = InnerGenerateTrees(start, currentRootValue - 1);
            var allRightSubtrees = InnerGenerateTrees(currentRootValue + 1, end);

            foreach (var leftSubTree in allLeftSubtrees)
            {
                foreach (var rightSubtree in allRightSubtrees)
                {
                    allTrees.Add(new TreeNode(currentRootValue, leftSubTree, rightSubtree));
                }
            }
        }

        return allTrees;
    }
}