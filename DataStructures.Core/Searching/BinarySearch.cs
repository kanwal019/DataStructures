using System;
using System.Collections.Generic;

namespace DataStructures.Core.Searching;

public static class BinarySearch
{
    public static int Search<T>(T[] array, T target)
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        return Search<T>(array.AsSpan(), target);
    }

    /// <summary>Returns the index relative to the supplied span, or -1 when absent.</summary>
    public static int Search<T>(ReadOnlySpan<T> array, T target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (EqualityComparer<T>.Default.Equals(array[mid], target))
            {
                return mid;
            }

            if (Comparer<T>.Default.Compare(array[mid], target) < 0)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }

    public static int SearchRecursive<T>(T[] array, T target)
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }
        return SearchRecursive<T>(array.AsSpan(), target);
    }

    /// <summary>Returns the index relative to the supplied span, or -1 when absent.</summary>
    public static int SearchRecursive<T>(ReadOnlySpan<T> array, T target)
    {
        return SearchRecursiveHelper(array, target, 0, array.Length - 1);
    }

    private static int SearchRecursiveHelper<T>(ReadOnlySpan<T> array, T target, int low, int high)
    {
        if (low > high)
        {
            return -1;
        }

        int mid = low + (high - low) / 2;

        if (EqualityComparer<T>.Default.Equals(array[mid], target))
        {
            return mid;
        }

        if (Comparer<T>.Default.Compare(array[mid], target) < 0)
        {
            return SearchRecursiveHelper(array, target, mid + 1, high);
        }
        else
        {
            return SearchRecursiveHelper(array, target, low, mid - 1);
        }
    }   
}