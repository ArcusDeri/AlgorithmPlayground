using AlgorithmPlayground.LeetCode.Chapters.Arrays;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays;

public class ArrayChapterTests
{
    [Theory]
    [InlineData(3, new[] {1, 1, 0, 1, 1, 1})]
    [InlineData(2, new[] {1, 0, 1, 1, 0, 1})]
    public void _01_FindMaxConsecutiveOnes_ShouldReturnExpectedResult(int expected, int[] array)
    {
        // Arrange
        // Act
        var result = _01_MaxConsecutiveOnes.FindMaxConsecutiveOnes(array);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, new[] {12, 345, 2, 6, 7896})]
    [InlineData(1, new[] {555, 901, 482, 1771})]
    public void _02_FindNumbers_ShouldReturnExpectedResult(int expected, int[] array)
    {
        // Arrange
        // Act
        var result = _02_FindNumbersWithEvenNumberOfDigits.FindNumbers(array);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] {0, 1, 9, 16, 100}, new[] {-4, -1, 0, 3, 10})]
    [InlineData(new[] {4, 9, 9, 49, 121}, new[] {-7, -3, 2, 3, 11})]
    public void _03_SortedSquares_ShouldReturnExpectedResult(int[] expected, int[] array)
    {
        // Arrange
        // Act
        var result = _03_SquaresOfSortedArray.SortedSquares(array);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] {1, 0, 0, 2, 3, 0, 0, 4}, new[] {1, 0, 2, 3, 0, 4, 5, 0})]
    [InlineData(new[] {1, 2, 3}, new[] {1, 2, 3})]
    public void _04_DuplicateZeros_ShouldReturnExpectedResult(int[] expected, int[] array)
    {
        // Arrange
        // Act
        _04_DuplicateZeros.DuplicateZeros(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Theory]
    [InlineData(new[] {1, 2, 2, 3, 5, 6}, new[] {1, 2, 3, 0, 0, 0}, 3, new[] {2, 5, 6}, 3)]
    [InlineData(new[] {1}, new[] {1}, 1, new int[0], 0)]
    [InlineData(new[] {1}, new[] {0}, 0, new[] {1}, 1)]
    public void _05_MergeSortedArray_ShouldReturnExpectedResult(int[] expected, int[] nums1, int m, int[] nums2, int n)
    {
        // Arrange
        // Act
        _05_MergeSortedArray.Merge(nums1, m, nums2, n);

        // Assert
        Assert.Equal(expected, nums1);
    }

    [Theory]
    [InlineData(new[] {2, 2, 0, 0}, new[] {3, 2, 2, 3}, 3)]
    [InlineData(new[] {0, 1, 4, 0, 3, 0, 0, 0}, new[] {0, 1, 2, 2, 3, 0, 4, 2}, 2)]
    public void _06_RemoveElement_ShouldReturnExpectedResult(int[] expected, int[] array, int val)
    {
        // Arrange
        // Act
        var result = _06_RemoveElement.RemoveElement(array, val);

        // Assert
        Assert.Equivalent(expected.Take(result), array.Take(result));
    }

    [Theory]
    [InlineData(new[] {1, 2, 0}, new[] {1, 2, 2})]
    [InlineData(new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4}, new[] {0, 1, 2, 3, 4, 0, 0, 0, 0, 0})]
    public void _07_RemoveDuplicatesFromSortedArray_ShouldReturnExpectedResult(int[] expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _07_RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expected.Take(result), nums.Take(result));
    }

    [Theory]
    [InlineData(true, new[] {10, 2, 5, 3})]
    [InlineData(false, new[] {3, 1, 7, 11})]
    public void _08_CheckIfNAndItsDoubleExist_ShouldReturnExpectedResult(bool expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _08_CheckIfNAndItsDoubleExist.CheckIfExist(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(false, new[] {2, 1})]
    [InlineData(false, new[] {3, 5, 5})]
    [InlineData(true, new[] {0, 3, 2, 1})]
    [InlineData(false, new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9})]
    public void _09_ValidMountainArraySolve_ShouldReturnExpectedResult_WhenCalled(bool expectedResult, int[] array)
    {
        // Arrange
        // Act
        var result = _09_ValidMountainArray.Solve(array);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void _10_ReplaceElementsWithGreatestElementOnRightSide_ShouldReturnExpectedResult_WhenCalled()
    {
        // Arrange
        var expected = new[] {18, 6, 6, 6, 1, -1};
        var array = new[] {17, 18, 5, 4, 6, 1};

        // Act
        var result = _10_ReplaceElementsWithGreatestElementOnRightSide.Solve(array);

        // Assert
        Assert.Equivalent(expected, result);
    }

    [Fact]
    public void _11_RemoveDuplicatesFromSortedArray_ShouldReturnExpectedResult()
    {
        // Arrange
        var originalArray = new[] {1, 1, 2};
        var targetArray = new[] {1, 1, 2};

        // Act
        var result = _11_RemoveDuplicatesFromSortedArray.RemoveDuplicates(targetArray);

        // Assert
        Assert.Equivalent(originalArray.Distinct(), targetArray.Take(result));
    }

    [Theory]
    [InlineData(new[] {1, 3, 12, 0, 0}, new[] {0, 1, 0, 3, 12})]
    [InlineData(new[] {0}, new[] {0})]
    [InlineData(new[] {1}, new[] {1})]
    public void _12_MoveZeroes_ShouldReturnExpectedResult(int[] expected, int[] array)
    {
        // Arrange
        // Act
        _12_MoveZeroes.MoveZeroes(array);

        // Assert
        Assert.Equivalent(expected, array);
    }

    [Fact]
    public void _13_SortArrayByParity_ShouldReturnExpectedResult()
    {
        // Arrange
        var array = new[] {3, 1, 2, 4};
        // Act
        var result = _13_SortArrayByParity.SortArrayByParity(array);

        // Assert
        Assert.True(result.Take(2).All(a => a % 2 == 0));
        Assert.True(result.TakeLast(2).All(a => a % 2 == 1));
    }

    [Fact]
    public void _14_RemoveElement_ShouldReturnCorrectResult()
    {
        // Arrange
        var array = new[] {0, 1, 2, 2, 3, 0, 4, 2};
        var expected = new[] {0, 1, 3, 0, 4};

        // Act
        var result = _14_RemoveElement.RemoveElement(array, 2);

        // Assert
        Assert.Equivalent(expected, array.Take(result));
    }

    [Theory]
    [InlineData(3, new[] {1, 1, 4, 2, 1, 3})]
    [InlineData(5, new[] {5, 1, 2, 3, 4})]
    [InlineData(0, new[] {1, 2, 3, 4, 5})]
    public void _15_HeightChecker_ShouldReturnExpectedResult(int expected, int[] heights)
    {
        // Arrange
        // Act
        var result = _15_HeightChecker.HeightChecker(heights);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, new[] {3, 2, 1})]
    [InlineData(2, new[] {1, 2})]
    [InlineData(1, new[] {2, 2, 3, 1})]
    [InlineData(2, new[] {1, 2, 2, 5, 3, 5})]
    public void _16_ThirdMaximumNumber_ShouldReturnExpectedResult(int expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _16_ThirdMaximumNumber.ThirdMax(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] {5, 6}, new[] {4, 3, 2, 7, 8, 2, 3, 1})]
    [InlineData(new[] {2}, new[] {1, 1})]
    public void _17_FindAllNumbersDisappearedInAnArray_ShouldReturnExpectedResult(int[] expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _17_FindAllNumbersDisappearedInAnArray.FindDisappearedNumbers(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}