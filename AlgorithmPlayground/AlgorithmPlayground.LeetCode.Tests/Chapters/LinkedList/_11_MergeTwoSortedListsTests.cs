using AlgorithmPlayground.LeetCode.Chapters.LinkedList;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _11_MergeTwoSortedListsTests
{
    [Fact]
    public void _1_MergeTwoLists_ShouldReturnListOfExpectedShape_ForTwoPopulatedLists()
    {
        // Arrange
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var expectedValues = new[] {1, 1, 2, 3, 4, 4};
        var resultValues = new List<int>(expectedValues.Length);

        // Act
        var resultList = _11_MergeTwoSortedLists.MergeTwoLists(list1, list2);
        while (resultList is { })
        {
            resultValues.Add(resultList.val);
            resultList = resultList.next;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues.ToArray());
    }

    [Fact]
    public void _2_MergeTwoLists_ShouldReturnNull_WhenGivenListsAreNull()
    {
        // Arrange
        ListNode? list1 = null;
        ListNode? list2 = null;

        // Act
        var result = _11_MergeTwoSortedLists.MergeTwoLists(list1, list2);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _3_MergeTwoLists_ShouldReturnListOfExpectedShape_WhenOneListIsNullAndOtherHasOneElement()
    {
        // Arrange
        const int expectedValue = 0;
        ListNode? list1 = null;
        var list2 = new ListNode(expectedValue);

        // Act
        var resultList = _11_MergeTwoSortedLists.MergeTwoLists(list1, list2);

        // Assert
        Assert.NotNull(resultList);
        Assert.Equal(expectedValue, resultList.val);
        Assert.Null(resultList.next);
    }
}