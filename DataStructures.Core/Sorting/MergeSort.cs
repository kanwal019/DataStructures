using System;

namespace DataStructures.Core.Sorting;

public static class MergeSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        Sort<T>(array.AsSpan());
    }

    /// <summary>Stably sorts the supplied span using one reusable scratch buffer.</summary>
    public static void Sort<T>(Span<T> array) where T : IComparable<T>
    {
        if (array.Length <= 1)
            return;

        T[] scratch = new T[array.Length];
        SortRecursive(array, scratch.AsSpan());
    }

    private static void SortRecursive<T>(Span<T> array, Span<T> scratch) where T : IComparable<T>
    {
        if (array.Length <= 1)
            return;

        int mid = array.Length / 2;
        SortRecursive(array[..mid], scratch[..mid]);
        SortRecursive(array[mid..], scratch[mid..]);

        // Read from scratch so merging cannot overwrite values still being read.
        array.CopyTo(scratch);
        Merge<T>(array, scratch[..mid], scratch[mid..]);
    }

    private static void Merge<T>(Span<T> array, ReadOnlySpan<T> left, ReadOnlySpan<T> right) where T : IComparable<T>
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i].CompareTo(right[j]) <= 0)
            {
                array[k++] = left[i++];
            }
            else
            {
                array[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            array[k++] = left[i++];
        }

        while (j < right.Length)
        {
            array[k++] = right[j++];
        }
    }
}