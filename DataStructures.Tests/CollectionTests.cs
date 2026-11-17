using DataStructures.Core.Arrays;
using Queue = DataStructures.Core.Queues.Queue<int>;

namespace DataStructures.Tests;

public class CollectionTests
{
    [Fact]
    public void QueueCanBeReusedAfterRemovingItsLastItem()
    {
        var queue = new Queue();
        for (int value = 0; value < 3; value++)
        {
            queue.Enqueue(value);
            Assert.Equal(value, queue.Peek());
            Assert.Equal(value, queue.Dequeue());
            Assert.Equal("[]", queue.ToString());
            Assert.Throws<InvalidOperationException>(() => queue.Peek());
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

        queue.Enqueue(10);
        queue.Enqueue(20);
        Assert.Equal(10, queue.Dequeue());
        queue.Enqueue(30);
        Assert.Equal(20, queue.Dequeue());
        Assert.Equal(30, queue.Dequeue());
    }

    [Fact]
    public void ArrayListIndexerWorksAfterGrowthInsertionAndRemoval()
    {
        ArrayList<int> list = [with(capacity: 0), 1, 2, 3];
        list[1] = 20;
        list.InsertAt(1, 10);
        list.RemoveAt(0);

        Assert.Equal(3, list.Count);
        Assert.Equal(new[] { 10, 20, 3 }, list);
        Assert.Equal(20, list[1]);
        Assert.Equal(list.Get(1), list[1]);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(2)]
    public void ArrayListIndexerRejectsInvalidIndices(int index)
    {
        ArrayList<int> list = [with(capacity: 8), 1, 2];
        Assert.Throws<ArgumentOutOfRangeException>(() => list[index]);
        Assert.Throws<ArgumentOutOfRangeException>(() => list[index] = 42);
    }

    [Fact]
    public void BitArrayDemoCountsThreeSetBits()
    {
        var original = System.Console.Out;
        using var output = new StringWriter();
        try
        {
            System.Console.SetOut(output);
            DataStructures.Console.Implementation.BitArrayImplementation.DisplayResult();
        }
        finally
        {
            System.Console.SetOut(original);
        }

        Assert.Contains("Bit count: 16", output.ToString());
        Assert.Contains("Set bits (manual): 3", output.ToString());
        Assert.Contains("Set bits (PopCount): 3", output.ToString());
    }
}
