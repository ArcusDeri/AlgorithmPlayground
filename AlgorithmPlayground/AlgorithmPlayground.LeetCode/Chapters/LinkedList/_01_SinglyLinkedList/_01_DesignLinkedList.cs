using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList._01_SinglyLinkedList;

/// <summary>
/// https://leetcode.com/explore/learn/card/linked-list/209/singly-linked-list/1290/
/// </summary>
public class _01_DesignLinkedList
{
    private ListNode? _head;

    public int Get(int index)
    {
        if (_head is null)
        {
            return -1;
        }

        var currentNode = _head;
        for (int i = 0; i < index; i++)
        {
            currentNode = currentNode.next;
            if (currentNode is null)
            {
                return -1;
            }
        }

        return currentNode.val;
    }

    public void AddAtHead(int val)
    {
        _head = new ListNode(val, _head);
    }

    public void AddAtTail(int val)
    {
        if (_head is null)
        {
            _head = new ListNode(val);
            return;
        }

        var currentNode = _head;
        while (currentNode.next is { })
        {
            currentNode = currentNode.next;
        }

        currentNode.next = new ListNode(val);
    }

    public void AddAtIndex(int index, int val)
    {
        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        if (_head is null)
        {
            return;
        }

        var currentNode = _head;
        for (int i = 0; i + 1 < index; i++)
        {
            currentNode = currentNode.next;
            if (currentNode is null)
            {
                return;
            }
        }

        var newNode = new ListNode(val, currentNode.next);
        currentNode.next = newNode;
    }

    public void DeleteAtIndex(int index)
    {
        if (_head is null)
        {
            return;
        }

        var currentNode = _head;
        for (var i = 0; i < index; i++)
        {
            if (currentNode is null)
            {
                return;
            }

            currentNode = currentNode.next;
        }

        if (currentNode is null)
        {
            return;
        }

        if (currentNode == _head)
        {
            _head = _head.next;
            return;
        }

        var prev = _head;
        while (prev.next != currentNode)
        {
            prev = prev.next;
        }

        prev.next = currentNode?.next;
    }
}