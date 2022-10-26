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
}
