namespace DataStructures.Core.Sorting;

public static class HeapSort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        int n = array.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(array, n, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            T temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            Heapify(array, i, 0);
        }
    }

    private static void Heapify<T>(T[] array, int n, int i) where T : IComparable<T>
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && array[left].CompareTo(array[largest]) > 0)
        {
            largest = left;
        }

        if (right < n && array[right].CompareTo(array[largest]) > 0)
        {
            largest = right;
        }

        if (largest != i)
        {
            T temp = array[i];
            array[i] = array[largest];
            array[largest] = temp;

            Heapify(array, n, largest);
        }
    }
}