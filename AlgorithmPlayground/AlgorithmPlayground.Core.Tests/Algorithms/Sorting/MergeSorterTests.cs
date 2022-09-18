using AlgorithmPlayground.Core.Algorithms.Sorting;
using Xunit;

namespace AlgorithmPlayground.Core.Tests.Algorithms.Sorting;

public class MergeSorterTests
{
    [Fact]
    public void MergeSort_ShouldSortArrayElements_WhenCalledForOddNumberOfElements()
    {
        // Arrange
        var unsorted = new[] {13, 7, 3, 1, 8, 12, 5};
        var sorted = new[] {1, 3, 5, 7, 8, 12, 13};

        // Act
        var result = MergeSorter.MergeSort(unsorted);

        // Assert
        Assert.Equal(sorted, result);
    }

    [Fact]
    public void MergeSort_ShouldSortArrayElements_WhenCalledForEvenNumberOfElements()
    {
        // Arrange
        var unsorted = new[] {13, 7, 3, 1, 8, 12, 5, 18};
        var sorted = new[] {1, 3, 5, 7, 8, 12, 13, 18};

        // Act
        var result = MergeSorter.MergeSort(unsorted);

        // Assert
        Assert.Equal(sorted, result);
    }
}