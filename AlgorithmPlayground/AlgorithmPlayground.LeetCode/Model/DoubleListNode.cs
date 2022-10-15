namespace AlgorithmPlayground.LeetCode.Model;

public class DoubleListNode
{
    // ReSharper disable once InconsistentNaming
    public int val;
    // ReSharper disable once InconsistentNaming
    public DoubleListNode? next;
    // ReSharper disable once InconsistentNaming
    public DoubleListNode? prev;

    public DoubleListNode(int val = 0, DoubleListNode? next = null, DoubleListNode? prev = null)
    {
        this.val = val;
        this.next = next;
        this.prev = prev;
    }
}