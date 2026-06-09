using System;
using System.Collections.Generic;

namespace DataStructures.Core.Searching;

public static class LinearSearch
{
    public static int Search<T>(T[] array, T target)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (EqualityComparer<T>.Default.Equals(array[i], target))
            {
                return i; // Return the index of the found element
            }
        }
        return -1;
    }
}