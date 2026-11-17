using System;
using System.Collections.Generic;

namespace DataStructures.Core.Searching;

public static class LinearSearch
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
        for (int i = 0; i < array.Length; i++)
        {
            if (EqualityComparer<T>.Default.Equals(array[i], target))
            {
                return i;
            }
        }
        return -1;
    }
}