using System;

namespace DataStructures.Library.LinkedLists.Double;

public class DoubleList<T> : List<T>
{
    public new DoubleNode<T> Head;

    public DoubleList()
    {
        Head = base.Head as DoubleNode<T>;
    }

    public new DoubleNode<T> GetLastNode()
    {
        DoubleNode<T> head = Head;
        while (head.Next is not null)
        {
            head = (DoubleNode<T>)head.Next;
        }
        return head;
    }

    public void DisplayReverse()
    {
        DoubleNode<T> head = GetLastNode();
        while(head is not null)
        {
            Console.Write($"{head.Data} ");
            head = (DoubleNode<T>)head.Prev;
        }
        Console.WriteLine();
    }
}
