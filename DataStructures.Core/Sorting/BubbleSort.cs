using System;

namespace DataStructures.Core.Sorting;

public static class BubbleSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
    }
}