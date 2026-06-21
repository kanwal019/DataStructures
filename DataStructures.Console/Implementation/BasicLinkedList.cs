using DataStructures.Core.LinkedLists.Basic;

namespace DataStructures.Console.Implementation;

public class BasicLinkedList
{
    public static void DisplayResult()
    {
        var list = new LinkedList<int>();
        
        list.Add(1);
        list.Add(5);
        list.Add(12);
        list.Add(15);
        System.Console.WriteLine(list);

        var (previous, node) = list.FindFirst(5);
        System.Console.WriteLine(node.Value);
        System.Console.WriteLine(node.Next.Value);

        list.DeleteAfter(previous);
        System.Console.WriteLine(list);

        list.AddAfter(previous, 10);
        System.Console.WriteLine(list);
    }
}