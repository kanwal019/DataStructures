using DataStructures.Library.LinkedLists.Double;

namespace DataStructures.Main.Implementation;

public class DoubleLinkedList
{
    public static void DisplayResult()
    {
        DoubleList<int> linkedList = new();
        CreateList(ref linkedList);
        DisplayList(linkedList, true);
    }

    private static void CreateList(ref DoubleList<int> linkedList)
    {
        linkedList.Head = new DoubleNode<int>(10);
        DoubleNode<int> node1 = new(1);
        DoubleNode<int> node2 = new(2);
        DoubleNode<int> node3 = new(3);
        DoubleNode<int> node4 = new(4);
        DoubleNode<int> node5 = new(5);

        linkedList.Head.Next = node1;
        node1.Prev = linkedList.Head;
        node1.Next = node2;
        node2.Prev = node1;
        node2.Next = node3;
        node3.Prev = node2;
        node3.Next = node4;
        node4.Prev = node3;
        node4.Next = node5;
        node5.Prev = node4;
    }

    private static void DisplayList(DoubleList<int> linkedList, bool reverse)
    {
        if (!reverse)
        {
            linkedList.Display();
            return;
        }
        linkedList.DisplayReverse();            
    }
}
