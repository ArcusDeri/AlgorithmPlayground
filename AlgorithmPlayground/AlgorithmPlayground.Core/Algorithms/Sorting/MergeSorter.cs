namespace AlgorithmPlayground.Core.Algorithms.Sorting;

public static class MergeSorter
{
    public static int[] MergeSort(int[] array)
    {
        if (array.Length < 2)
        {
            return array;
        }

        var middle = array.Length / 2;
        var left = array[..middle];
        var right = array[middle..];
        return Merge(MergeSort(left), MergeSort(right));
    }

    private static int[] Merge(int[] left, int[] right)
    {
        var result = new List<int>();
        var leftList = left.ToList();
        var rightList = right.ToList();

        while (leftList.Any() || rightList.Any())
        {
            if (leftList.Any() && rightList.Any())
            {
                if (leftList[0] < rightList[0])
                {
                    result.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }
                else
                {
                    result.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }
            else if (leftList.Any())
            {
                result.AddRange(leftList);
                leftList.Clear();
            }
            else
            {
                result.AddRange(rightList);
                rightList.Clear();
            }
        }

        return result.ToArray();
    }
}