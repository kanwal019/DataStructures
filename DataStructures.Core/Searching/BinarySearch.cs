using System;
using System.Collections.Generic;

namespace DataStructures.Core.Searching;

public static class BinarySearch
{
    public static int Search<T>(T[] array, T target)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

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
}