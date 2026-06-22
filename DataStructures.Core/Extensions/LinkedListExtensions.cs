using DataStructures.Core.LinkedLists.Basic;

namespace DataStructures.Core.Extensions;

public static class LinkedListExtensions
{
    public static bool HasCycle<T>(this MovingPointer<T> list)
    {
        var node = GetNodeInsideLoop(list);
        return null != node;
    }

    public static Node<T> GetNodeInsideLoop<T>(this MovingPointer<T> list)
    {
        var fast = list.Root;
        var slow = list.Root;

        while (fast?.Next?.Next != null)
        {
            fast = fast.Next.Next;
            slow = slow.Next;

            if (fast == slow) return slow;
        }

        return null;
    }
}
