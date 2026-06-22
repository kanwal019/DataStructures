using DataStructures.Core.LinkedLists.Basic;
using DataStructures.Core.Extensions;

namespace DataStructures.Console.Extensions;

public static class LinkedListExtensions
{
    public static Node<T> SplitIntoHalves<T>(this MovingPointer<T> list)
    {
        var fast = list.Root;
        var slow = list.Root;

        while (fast?.Next?.Next != null)
        {
            fast = fast.Next.Next;
            slow = slow.Next;
        }
        return slow;
    }

    public static (Node<T> previous, Node<T> cycle) GetCycleNodes<T>(this MovingPointer<T> list)
    {
        Node<T> node = list.GetNodeInsideLoop();

        if (null == node) return (null, null);

        //get the size of the loop
        int size = 1;
        Node<T> slidingNode = node;

        while (slidingNode.Next != node)
        {
            slidingNode = slidingNode.Next;
            size++;
        }

        Node<T> first = list.Root;
        Node<T> previous = list.Root;
        Node<T> second = list.Root;

        for (int i = 0; i < size; i++)
        {
            if (i != 0) previous = previous.Next;
            second = second.Next;
        }

        while (first != second)
        {
            first = first.Next;
            second = second.Next;
            previous = previous.Next;
        }

        return (previous, second);
    }
}
