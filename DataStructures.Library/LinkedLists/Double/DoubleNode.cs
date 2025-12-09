namespace DataStructures.Library.LinkedLists.Double;

public class DoubleNode<T>(T data) : Node<T>(data)
{
    public Node<T> Prev = null;
}
