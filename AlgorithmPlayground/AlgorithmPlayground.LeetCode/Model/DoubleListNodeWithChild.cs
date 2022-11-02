// ReSharper disable InconsistentNaming
namespace AlgorithmPlayground.LeetCode.Model;

public class DoubleListNodeWithChild
{
    public int val;
    public DoubleListNodeWithChild? next;
    public DoubleListNodeWithChild? prev;
    public DoubleListNodeWithChild? child;

    public DoubleListNodeWithChild(int val = 0, DoubleListNodeWithChild? next = null, DoubleListNodeWithChild? prev = null, DoubleListNodeWithChild? child = null)
    {
        this.val = val;
        this.next = next;
        this.prev = prev;
        this.child = child;
    }
}