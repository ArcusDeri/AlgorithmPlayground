namespace AlgorithmPlayground.LeetCode.Model;

public class DoubleListNodeWithChild
{
    // ReSharper disable once InconsistentNaming
    public int val;

    // ReSharper disable once InconsistentNaming
    public DoubleListNodeWithChild? next;

    // ReSharper disable once InconsistentNaming
    public DoubleListNodeWithChild? prev;

    // ReSharper disable once InconsistentNaming
    public DoubleListNodeWithChild? child;

    public DoubleListNodeWithChild(int val = 0, DoubleListNodeWithChild? next = null, DoubleListNodeWithChild? prev = null, DoubleListNodeWithChild? child = null)
    {
        this.val = val;
        this.next = next;
        this.prev = prev;
        this.child = child;
    }
}