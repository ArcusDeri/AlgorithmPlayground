using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _13_FlattenAMultiLevelDoublyLinkedList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/213/conclusion/1225/
    /// </summary>
    public static DoubleListNodeWithChild? Flatten(DoubleListNodeWithChild? head)
    {
        if (head is null)
        {
            return null;
        }

        var ptr = head;
        while (ptr is not null)
        {
            if (ptr.child is null)
            {
                ptr = ptr.next;
                continue;
            }

            var temp = ptr.child;
            while (temp.next is not null)
            {
                temp = temp.next;
            }

            temp.next = ptr.next;
            if (ptr.next is not null)
            {
                ptr.next.prev = temp;
            }

            ptr.next = ptr.child;
            ptr.child.prev = ptr;
            ptr.child = null;
        }

        return head;
    }

}