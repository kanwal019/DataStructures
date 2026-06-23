using DataStructures.Core.LinkedLists.Basic;
using DataStructures.Core.Extensions;
using DataStructures.Console.Extensions;
using DataStructures.Core.Common;

namespace DataStructures.Console.Implementation;

public class MovingPointerLinkedList
{
    public static void DisplayResult()
    {
        SplitTest();
        CyclesTest();
        GetCycleNodesTest();
    }

    static void GetCycleNodesTest()
    {
        var list = new MovingPointer<int>();

        list.Add(10);
        list.Add(20);
        System.Console.WriteLine(list);
        System.Console.WriteLine($"Has cycles: {list.HasCycle()}");
        System.Console.WriteLine("Adding cycle...");
        var cycleNode = new Node<int> { Value = 30, Next = list.Root };
        list.AddNode(cycleNode);
        System.Console.WriteLine($"Has cycles: {list.HasCycle()}");
        var (previous, loopNode) = list.GetCycleNodes();
        System.Console.WriteLine($"The node, that causes the loop: {previous.Value}");
        System.Console.WriteLine($"The node, that starts the loop: {loopNode.Value}");
        System.Console.WriteLine("Removing cycle...");
        previous.Next = null;
        System.Console.WriteLine($"Has cycles: {list.HasCycle()}");
        System.Console.WriteLine(list);
    }

    static void CyclesTest()
    {
        var list = new MovingPointer<int>();
        list.Add(10);
        list.Add(20);
        var node = list.Add(30);
        list.Add(40);
        list.Add(50);
        System.Console.WriteLine(list);
        System.Console.WriteLine($"Has cycles: {list.HasCycle()}");
        System.Console.WriteLine("Adding cycle");
        var cycleNode = new Node<int> { Value = 60, Next = node };
        list.AddNode(cycleNode);
        System.Console.WriteLine($"Has cycles: {list.HasCycle()}");
    }

    static void SplitTest()
    {
        var list = new MovingPointer<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);
        list.Add(60);
        list.Add(70);
        list.Add(80);

        System.Console.WriteLine(list);
        var node = list.SplitIntoHalves();
        System.Console.WriteLine(node.Value);

        list.Add(90);

        System.Console.WriteLine(list);
        node = list.SplitIntoHalves();
        System.Console.WriteLine(node.Value);
    }
}
