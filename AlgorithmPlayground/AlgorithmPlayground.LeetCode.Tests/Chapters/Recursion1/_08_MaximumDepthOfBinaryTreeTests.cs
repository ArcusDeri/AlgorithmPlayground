using AlgorithmPlayground.LeetCode.Chapters.Recursion1._04_ComplexityAnalysis;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Recursion1;

public class _08_MaximumDepthOfBinaryTreeTests
{
    [Fact]
    public void _01_MaxDepth_ShouldReturnExpectedResult_v1()
    {
        // Arrange
        var solver = new _08_MaximumDepthOfBinaryTree();
        var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        const int expectedDepth = 3;

        // Act
        var result = solver.MaxDepth(root);

        // Assert
        Assert.Equal(expectedDepth, result);
    }

    [Fact]
    public void _02_MaxDepth_ShouldReturnExpectedResult_v2()
    {
        // Arrange
        var solver = new _08_MaximumDepthOfBinaryTree();
        var root = new TreeNode(1, null, new TreeNode(2));
        const int expectedDepth = 2;

        // Act
        var result = solver.MaxDepth(root);

        // Assert
        Assert.Equal(expectedDepth, result);
    }
}