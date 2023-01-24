using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _14_CopyListWithRandomPointer
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/213/conclusion/1229/
    /// </summary>
    public static ListNodeWithRandom? CopyRandomList(ListNodeWithRandom? head)
    {
        if (head is null)
        {
            return null;
        }
        var map = new Dictionary<ListNodeWithRandom, ListNodeWithRandom>();
        var curr = head;

        while (curr is { })
        {
            map[curr] = new ListNodeWithRandom(curr.val);
            curr = curr.next;
        }

        curr = head;
        while (curr is {})
        {
            if (curr.next is { })
            {
                map[curr].next = map[curr.next];
            }

            if (curr.random is { })
            {
                map[curr].random = map[curr.random];
            }
            curr = curr.next;
        }
        
        return map[head];
    }

    public static ListNodeWithRandom? CopyRandomListInPlace(ListNodeWithRandom? head)
    {
        // duplicate each node
        var current = head;
        while (current is {})
        {
            var originalNext = current.next;
            current.next = new ListNodeWithRandom(current.val);
            current.next.next = originalNext;
            current = originalNext;
        }

        // assign "random" for new nodes
        current = head;
        while (current?.next is {})
        {
            var originalRandom = current.random;
            current.next.random = originalRandom?.next;
            current = current.next.next;
        }

        // detach old nodes
        current = head;
        var newHead = new ListNodeWithRandom(0);
        var newHeadCurrent = newHead;
        while (current is {})
        {
            var currNext = current.next.next;
            newHeadCurrent.next = current.next;
            current.next = currNext;
            newHeadCurrent = newHeadCurrent.next;
            current = current.next;
        }

        return newHead.next;
    }
}
