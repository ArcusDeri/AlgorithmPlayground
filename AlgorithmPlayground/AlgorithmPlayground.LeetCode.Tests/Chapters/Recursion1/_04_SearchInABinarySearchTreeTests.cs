using AlgorithmPlayground.LeetCode.Chapters.Recursion1._02_RecurrenceRelation;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Recursion1;

public class _04_SearchInABinarySearchTreeTests
{
    [Fact]
    public void _01_SearchBST_ShouldReturnExpectedTreeNode_WhenTreeContainsSearchedValue()
    {
        // Arrange
        const int searchedValue = 2;
        var expectedNode = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        var root = new TreeNode(4, expectedNode, new TreeNode(7));

        // Act
        var resultNode = _04_SearchInABinarySearchTree.SearchBST(root, searchedValue);

        // Assert
        Assert.NotNull(resultNode);
        Assert.Same(expectedNode, resultNode);
    }

    [Fact]
    public void _02_SearchBST_ShouldReturnExpectedTreeNode_WhenTreeDoesNotContainSearchedValue()
    {
        // Arrange
        const int searchedValue = 5;
        var subTree = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        var root = new TreeNode(4, subTree, new TreeNode(7));

        // Act
        var resultNode = _04_SearchInABinarySearchTree.SearchBST(root, searchedValue);

        // Assert
        Assert.Null(resultNode);
    }
}