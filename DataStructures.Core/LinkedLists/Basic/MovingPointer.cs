using DataStructures.Core.Extensions;

namespace DataStructures.Core.LinkedLists.Basic;

public class MovingPointer<T> : LinkedList<T>
{
    public Node<T> AddNode(Node<T> valueNode)
    {
        return AppendNode(valueNode);
    }

    public override string ToString()
    {
        if (this.HasCycle()) return "List with cycle";

        return BuildString();
    }
}
