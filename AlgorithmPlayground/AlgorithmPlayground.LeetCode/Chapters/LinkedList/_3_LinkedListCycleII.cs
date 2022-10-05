using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _3_LinkedListCycleII
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1214/
    /// </summary>
    public static ListNode? DetectCycle(ListNode head)
    {
        var walker = head;
        var runner = head;
        while (runner?.next is { })
        {
            walker = walker.next;
            runner = runner.next.next;
            if (walker == runner)
            {
                walker = head;
                while (walker != runner)
                {
                    walker = walker.next;
                    runner = runner.next;
                }

                return walker;
            }
        }
        return null;
    }
}