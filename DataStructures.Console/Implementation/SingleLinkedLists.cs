using DataStructures.Core.LinkedLists.Single;

namespace DataStructures.Console.Implementation;

public class SingleLinkedLists
{
    public static void DisplayResult()
    {
        SingleList<int> linkedList = new();
        CreateList(ref linkedList);
        DisplayList(linkedList);
    }

    private static void CreateList(ref SingleList<int> linkedList)
    {
        linkedList.Head = new SingleNode<int> { Value = 10 };
        SingleNode<int> node1 = new() { Value = 1 };
        SingleNode<int> node2 = new() { Value = 2 };
        SingleNode<int> node3 = new() { Value = 3 };
        SingleNode<int> node4 = new() { Value = 4 };
        SingleNode<int> node5 = new() { Value = 5 };

        linkedList.Head.Next = node1;
        node1.Next = node2;
        node2.Next = node3;
        node3.Next = node4;
        node4.Next = node5;
    }

    private static void DisplayList(SingleList<int> linkedList) => linkedList.Display();
}
