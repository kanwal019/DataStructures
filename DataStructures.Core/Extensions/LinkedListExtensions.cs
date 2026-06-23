using DataStructures.Core.LinkedLists.Basic;
using DataStructures.Core.Common;

namespace DataStructures.Core.Extensions;

public static class LinkedListExtensions
{
    public static bool HasCycle<T>(this MovingPointer<T> list)
    {
        var node = GetNodeInsideLoop(list);
        return node is not null;
    }

    public static Node<T> GetNodeInsideLoop<T>(this MovingPointer<T> list)
    {
        var fast = list.Root;
        var slow = list.Root;

        while (fast?.Next?.Next is not null)
        {
            fast = fast.Next.Next;
            slow = slow.Next;

            if (fast == slow) return slow;
        }

        return null;
    }
}
