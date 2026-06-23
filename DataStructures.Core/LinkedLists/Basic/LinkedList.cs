using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.Core.Common;

namespace DataStructures.Core.LinkedLists.Basic;

public class LinkedList<T>
{
    public Node<T> Root { get; protected set; }

    public (Node<T> previous, Node<T> found) FindFirst(T value)
    {
        Node<T> previous = null;
        for (var current = Root; current is not null; current = current.Next)
        {
            if (EqualityComparer<T>.Default.Equals(current.Value, value))
            {
                return (previous, current);
            }
            previous = current;
        }
        return (null, null);
    }

    public Node<T> AddAfter(Node<T> node, T value)
    {
        ArgumentNullException.ThrowIfNull(node);

        var valueNode = CreateNode(value, node.Next);
        node.Next = valueNode;

        return valueNode;
    }

    public Node<T> Add(T value)
    {
        var valueNode = CreateNode(value);

        if (Root is null)
        {
            Root = valueNode;
            return valueNode;
        }

        GetTail().Next = valueNode;
        return valueNode;
    }

    public bool DeleteAfter(Node<T> node)
    {
        ArgumentNullException.ThrowIfNull(node);

        var nextNode = node.Next;
        if (nextNode is null) return false;

        node.Next = nextNode.Next;
        return true;
    }

    public override string ToString() => BuildString();

    protected Node<T> AppendNode(Node<T> valueNode)
    {
        ArgumentNullException.ThrowIfNull(valueNode);

        if (Root is null)
        {
            Root = valueNode;
            return valueNode;
        }

        GetTail().Next = valueNode;
        return valueNode;
    }

    protected string BuildString()
    {
        StringBuilder result = new("["); ;
        var node = Root;

        while (node is not null)
        {
            result.Append(node.Value);
            node = node.Next;

            if (node is not null) result.Append(',');
        }

        result.Append(']');
        return result.ToString();
    }

    protected static Node<T> CreateNode(T value, Node<T> next = null) => new()
    {
        Value = value,
        Next = next
    };

    protected Node<T> GetTail()
    {
        var node = Root;
        while (node.Next is not null)
        {
            node = node.Next;
        }
        return node;
    }
}
