using System;

namespace DataStructures.Library.LinkedLists;

public abstract class List<T>
{
    public Node<T> Head;

    public virtual void Display()
    {
        Node<T> head = Head;
        while (head is not null)
        {
            Console.Write($"{head.Data} ");
            head = head.Next;
        }
        Console.WriteLine();
    }

    public virtual Node<T> GetLastNode()
    {
        Node<T> head = Head;
        while (head.Next is not null)
        {
            Console.Write($"{head.Data} ");
            head = head.Next;
        }
        return head;
    }
}
