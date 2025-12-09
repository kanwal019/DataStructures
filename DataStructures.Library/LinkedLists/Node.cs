namespace DataStructures.Library.LinkedLists;

public abstract class Node<T>(T data)
{
    public T Data = data;
    public Node<T> Next = null;
}
