using DataStructures.Core.Queues;

namespace DataStructures.Console.Implementation;

public class QueueImplementation
{
    public static void DisplayResult()
    {
        var queue = new Queue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        System.Console.WriteLine(queue);

        int dequeuedValue = queue.Dequeue();
        System.Console.WriteLine($"Dequeued value: {dequeuedValue}");
        System.Console.WriteLine(queue);

        int peekedValue = queue.Peek();
        System.Console.WriteLine($"Peeked value: {peekedValue}");
        System.Console.WriteLine(queue);
    }
}