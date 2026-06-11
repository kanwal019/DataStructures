using DataStructures.Console.Extensions;
using DataStructures.Core.Searching;

namespace DataStructures.Console.Implementation;

public class SearchImplementation
{
    public static void DisplayLinearSearchResult()
    {
        int[] numbers = new int[10];
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = i + 1;
        }
        numbers.Display();

        int target = 5;
        int index = LinearSearch.Search(numbers, target);
        if (index != -1)
        {
            System.Console.WriteLine($"Element {target} found at index {index}.");
        }
        else
        {
            System.Console.WriteLine($"Element {target} not found in the list.");
        }
    }

    public static void DisplayBinarySearchResult()
    {
        int[] numbers = new int[10];
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = i + 1;
        }
        numbers.Display();

        int target = 7;
        int index = BinarySearch.Search(numbers, target);
        if (index != -1)
        {
            System.Console.WriteLine($"Element {target} found at index {index}.");
        }
        else
        {
            System.Console.WriteLine($"Element {target} not found in the list.");
        }
    }

    public static void DisplayBinarySearchRecursiveResult()
    {
        int[] numbers = new int[10];
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = i + 1;
        }
        numbers.Display();

        int target = 3;
        int index = BinarySearch.SearchRecursive(numbers, target);
        if (index != -1)
        {
            System.Console.WriteLine($"Element {target} found at index {index}.");
        }
        else
        {
            System.Console.WriteLine($"Element {target} not found in the list.");
        }
    }
}