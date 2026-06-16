using DataStructures.Console.Extensions;
using DataStructures.Core.Sorting;

namespace DataStructures.Console.Implementation;

public class SortImplementation
{
    public static void DisplaySelectionSortResult()
    {
        int[] numbers = [64, 25, 12, 22, 11];
        numbers.Display();

        SelectionSort.Sort(numbers);
        numbers.Display();
    }

    public static void DisplayBubbleSortResult()
    {
        int[] numbers = [5, 1, 4, 2, 8];
        numbers.Display();

        BubbleSort.Sort(numbers);
        numbers.Display();
    }

    public static void DisplayMergeSortResult()
    {
        int[] numbers = [12, 11, 13, 5, 6];
        numbers.Display();

        MergeSort.Sort(numbers);
        numbers.Display();
    }
}