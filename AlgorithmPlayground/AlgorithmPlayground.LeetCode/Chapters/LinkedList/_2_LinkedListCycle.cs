using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _2_LinkedListCycle
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1212/
    /// </summary>
    public static bool HasCycle(ListNode head)
    {
        var slowNode = head;
        var fastNode = head;

        while (slowNode is { } && fastNode?.next is {})
        {
            slowNode = slowNode.next;
            fastNode = fastNode.next.next;

            if (fastNode == slowNode)
            {
                return true;
            }
        }

        return false;
    }
}