// ReSharper disable InconsistentNaming
namespace AlgorithmPlayground.LeetCode.Model;

public class DoubleListNode
{
    public int val;
    public DoubleListNode? next;
    public DoubleListNode? prev;

    public DoubleListNode(int val = 0, DoubleListNode? next = null, DoubleListNode? prev = null)
    {
        this.val = val;
        this.next = next;
        this.prev = prev;
    }
}