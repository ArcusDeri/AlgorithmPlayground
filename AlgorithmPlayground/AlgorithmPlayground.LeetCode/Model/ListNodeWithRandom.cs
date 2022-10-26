namespace AlgorithmPlayground.LeetCode.Model;

public class ListNodeWithRandom
{
    // ReSharper disable once InconsistentNaming
    public int val;

    // ReSharper disable once InconsistentNaming
    public ListNodeWithRandom? next;

    // ReSharper disable once InconsistentNaming
    public ListNodeWithRandom? random;

    public ListNodeWithRandom(int val = 0, ListNodeWithRandom? next = null, ListNodeWithRandom? random = null)
    {
        this.val = val;
        this.next = next;
        this.random = random;
    }
}