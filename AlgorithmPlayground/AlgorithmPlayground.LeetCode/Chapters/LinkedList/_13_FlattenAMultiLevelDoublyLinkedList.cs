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

        var dummyHead = new DoubleListNodeWithChild();
        var builderNode = dummyHead;
        var stack = new Stack<DoubleListNodeWithChild>();
        stack.Push(head);

        while (stack.Any())
        {
            var current = stack.Pop();
            builderNode.next = new DoubleListNodeWithChild(current.val, null, builderNode);
            builderNode = builderNode.next;

            if (current.next is { })
            {
                stack.Push(current.next);
            }
            if (current.child is { })
            {
                stack.Push(current.child);
            }
        }

        dummyHead.next.prev = null;
        return dummyHead.next;
    }

}