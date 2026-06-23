using System;

namespace DataStructures.Core.Sorting;

public static class QuickSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        QuickSortRecursive(array, 0, array.Length - 1);
    }

    private static void QuickSortRecursive<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        if (low < high)
        {
            int pi = Partition(array, low, high);
            QuickSortRecursive(array, low, pi - 1);
            QuickSortRecursive(array, pi + 1, high);
        }
    }

    private static int Partition<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        T pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j].CompareTo(pivot) <= 0)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    private static void Swap<T>(T[] array, int i, int j)
    {
        T temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}