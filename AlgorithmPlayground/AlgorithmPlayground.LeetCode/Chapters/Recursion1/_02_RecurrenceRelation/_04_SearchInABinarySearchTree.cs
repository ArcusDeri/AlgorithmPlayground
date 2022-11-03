// ReSharper disable InconsistentNaming
using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1._02_RecurrenceRelation;

public static class _04_SearchInABinarySearchTree
{
    public static TreeNode? SearchBST(TreeNode? root, int val)
    {
        if (root is null || root.val == val)
        {
            return root;
        }

        return SearchBST(val < root.val ? root.left : root.right, val);
    }
}