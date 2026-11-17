using System;

namespace DataStructures.Core.Sorting;

public static class InsertionSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        Sort<T>(array.AsSpan());
    }

    /// <summary>Sorts only the supplied span in place.</summary>
    public static void Sort<T>(Span<T> array) where T : IComparable<T>
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            T key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j].CompareTo(key) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }
}