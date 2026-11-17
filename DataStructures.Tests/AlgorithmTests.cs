using DataStructures.Core.Searching;
using DataStructures.Core.Sorting;

namespace DataStructures.Tests;

public class AlgorithmTests
{
    public enum SortAlgorithm
    {
        Bubble,
        Heap,
        Insertion,
        Merge,
        Quick,
        Selection
    }

    public enum SearchAlgorithm
    {
        Linear,
        Binary,
        RecursiveBinary
    }

    [Theory]
    [InlineData(SortAlgorithm.Bubble)]
    [InlineData(SortAlgorithm.Heap)]
    [InlineData(SortAlgorithm.Insertion)]
    [InlineData(SortAlgorithm.Merge)]
    [InlineData(SortAlgorithm.Quick)]
    [InlineData(SortAlgorithm.Selection)]
    public void SortsMatchFrameworkAndPreserveItemsOutsideSlice(SortAlgorithm algorithm)
    {
        int[][] cases = [[], [1], [3, 2, 1], [1, 2, 3], [2, 2, 1, 2], [0, -1, int.MaxValue, int.MinValue]];
        var random = new Random(42);
        cases = [.. cases, .. Enumerable.Range(0, 30)
            .Select(_ => Enumerable.Range(0, random.Next(0, 65)).Select(_ => random.Next(-20, 21)).ToArray())];

        Assert.Throws<ArgumentNullException>(() => SortArray(algorithm, null!));

        foreach (int[] input in cases)
        {
            int[] expected = input.Order().ToArray();
            int[] whole = (int[])input.Clone();
            SortArray(algorithm, whole);
            Assert.Equal(expected, whole);

            int[] sliced = [12345, .. input, -12345];
            SortSpan(algorithm, sliced.AsSpan(1, input.Length));
            Assert.Equal(12345, sliced[0]);
            Assert.Equal(-12345, sliced[^1]);
            Assert.Equal(expected, sliced[1..^1]);
        }
    }

    [Theory]
    [InlineData(SearchAlgorithm.Linear)]
    [InlineData(SearchAlgorithm.Binary)]
    [InlineData(SearchAlgorithm.RecursiveBinary)]
    public void SearchIndicesAreRelativeToSlice(SearchAlgorithm algorithm)
    {
        int[] items = [-99, 10, 20, 30, 99];
        Assert.Equal(1, SearchSpan(algorithm, items.AsSpan(1, 3), 20));
        Assert.Equal(0, SearchSpan(algorithm, items.AsSpan(1, 3), 10));
        Assert.Equal(2, SearchSpan(algorithm, items.AsSpan(1, 3), 30));
        Assert.Equal(-1, SearchSpan(algorithm, items.AsSpan(1, 3), 99));
        Assert.Equal(-1, SearchSpan(algorithm, ReadOnlySpan<int>.Empty, 20));
        Assert.Equal(0, SearchSpan(algorithm, items.AsSpan(2, 1), 20));
        Assert.Equal(2, SearchArray(algorithm, items, 20));
        Assert.Throws<ArgumentNullException>(() => SearchArray(algorithm, null!, 20));
    }

    [Fact]
    public void MergeSortPreservesOrderOfEqualKeys()
    {
        Entry[] items = [new(2, "a"), new(1, "b"), new(2, "c"), new(1, "d"), new(2, "e")];
        MergeSort.Sort(items.AsSpan());
        Assert.Equal(new[] { "b", "d", "a", "c", "e" }, items.Select(item => item.Label));
    }

    private sealed record Entry(int Key, string Label) : IComparable<Entry>
    {
        public int CompareTo(Entry? other) => other is null ? 1 : Key.CompareTo(other.Key);
    }

    private static void SortArray(SortAlgorithm algorithm, int[] items)
    {
        switch (algorithm)
        {
            case SortAlgorithm.Bubble:
                BubbleSort.Sort(items);
                break;
            case SortAlgorithm.Heap:
                HeapSort.Sort(items);
                break;
            case SortAlgorithm.Insertion:
                InsertionSort.Sort(items);
                break;
            case SortAlgorithm.Merge:
                MergeSort.Sort(items);
                break;
            case SortAlgorithm.Quick:
                QuickSort.Sort(items);
                break;
            case SortAlgorithm.Selection:
                SelectionSort.Sort(items);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(algorithm));
        }
    }

    private static void SortSpan(SortAlgorithm algorithm, Span<int> items)
    {
        switch (algorithm)
        {
            case SortAlgorithm.Bubble:
                BubbleSort.Sort(items);
                break;
            case SortAlgorithm.Heap:
                HeapSort.Sort(items);
                break;
            case SortAlgorithm.Insertion:
                InsertionSort.Sort(items);
                break;
            case SortAlgorithm.Merge:
                MergeSort.Sort(items);
                break;
            case SortAlgorithm.Quick:
                QuickSort.Sort(items);
                break;
            case SortAlgorithm.Selection:
                SelectionSort.Sort(items);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(algorithm));
        }
    }

    private static int SearchArray(SearchAlgorithm algorithm, int[] items, int target) => algorithm switch
    {
        SearchAlgorithm.Linear => LinearSearch.Search(items, target),
        SearchAlgorithm.Binary => BinarySearch.Search(items, target),
        SearchAlgorithm.RecursiveBinary => BinarySearch.SearchRecursive(items, target),
        _ => throw new ArgumentOutOfRangeException(nameof(algorithm))
    };

    private static int SearchSpan(SearchAlgorithm algorithm, ReadOnlySpan<int> items, int target) => algorithm switch
    {
        SearchAlgorithm.Linear => LinearSearch.Search(items, target),
        SearchAlgorithm.Binary => BinarySearch.Search(items, target),
        SearchAlgorithm.RecursiveBinary => BinarySearch.SearchRecursive(items, target),
        _ => throw new ArgumentOutOfRangeException(nameof(algorithm))
    };
}
