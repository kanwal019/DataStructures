using System;

namespace DataStructures.Core.Sorting;

public static class SelectionSort
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
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j].CompareTo(array[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            T temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
}