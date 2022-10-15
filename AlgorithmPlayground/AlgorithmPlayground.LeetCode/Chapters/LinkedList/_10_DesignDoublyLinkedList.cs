using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public class _10_DesignDoublyLinkedList
{
    private DoubleListNode? _head;

    public _10_DesignDoublyLinkedList()
    {
    }

    public int Get(int index)
    {
        var i = 0;
        var current = _head;
        while (i < index)
        {
            i++;
            current = current.next;
        }

        return current.val;
    }

    public void AddAtHead(int val)
    {
        var newHead = new DoubleListNode(val, _head);
        if (_head is { })
        {
            _head.prev = newHead;
            newHead.next = _head;
        }
        _head = newHead;
    }

    public void AddAtTail(int val)
    {
        var current = _head;
        while (current?.next is {})
        {
            current = current.next;
        }

        var newTail = new DoubleListNode(val);
        newTail.prev = current;
        current.next = newTail;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index == 0)
        {
            AddAtHead(val);
        }

        var i = 0;
        var current = new DoubleListNode(0, _head);
        while (i < index)
        {
            i++;
            current = current.next;
        }

        var newNode = new DoubleListNode(val);
        newNode.prev = current;
        newNode.next = current.next;
        if (newNode.next is { })
        {
            newNode.next.prev = newNode;
        }
        current.next = newNode;
    }

    public void DeleteAtIndex(int index)
    {
        var i = 0;
        var current = _head;
        if (index == 0)
        {
            _head = _head.next;
        }

        while (i < index)
        {
            i++;
            current = current.next;
        }

        current.next = current.next.next;
        if (current.next is { })
        {
            current.next.prev = current;
        }
    }
}