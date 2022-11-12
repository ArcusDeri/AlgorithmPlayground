using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1._04_ComplexityAnalysis;

public class _08_MaximumDepthOfBinaryTree
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/256/complexity-analysis/2375/
    /// </summary>
    public int MaxDepth(TreeNode? root)
    {
        return InnerMaxDepth(root, 0);
    }

    public int InnerMaxDepth(TreeNode? root, int currentDepth)
    {
        if (root is null)
        {
            return currentDepth;
        }

        currentDepth += 1;
        var leftDepth = InnerMaxDepth(root.left, currentDepth);
        var rightDepth = InnerMaxDepth(root.right, currentDepth);
        return Math.Max(leftDepth, rightDepth);
    }
}