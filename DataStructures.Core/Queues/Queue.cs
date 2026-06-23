using System;
using DataStructures.Core.Common;

namespace DataStructures.Core.Queues;

public class Queue<T>
{
    protected Node<T> Head { get; set; }
    protected Node<T> Tail { get; set; }

    public void Enqueue(T value)
    {
        var valueNode = new Node<T> { Value = value, Next = null };
        if (Tail is null)
        {
            Head = valueNode;
            Tail = Head;
            return;
        }

        Tail.Next = valueNode;
        Tail = valueNode;
    }

    public T Dequeue()
    {
        if (Head is null)
            throw new InvalidOperationException("The queue is empty!");

        var result = Head.Value;
        Head = Head.Next;
        return result;
    }

    public T Peek()
    {
        if (Head is null)
            throw new InvalidOperationException("The queue is empty!");

        return Head.Value;
    }

    public override string ToString()
    {
        string result = "[";
        var node = Head;
        while (node is not null)
        {
            result += node.Value;
            node = node.Next;

            if (node is not null) 
                result += ",";
        }
        result += "]";
        return result;
    }
}