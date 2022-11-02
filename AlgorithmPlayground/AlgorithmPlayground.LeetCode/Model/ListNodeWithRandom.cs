// ReSharper disable InconsistentNaming
namespace AlgorithmPlayground.LeetCode.Model;

public class ListNodeWithRandom
{
    public int val;
    public ListNodeWithRandom? next;
    public ListNodeWithRandom? random;

    public ListNodeWithRandom(int val = 0, ListNodeWithRandom? next = null, ListNodeWithRandom? random = null)
    {
        this.val = val;
        this.next = next;
        this.random = random;
    }
}