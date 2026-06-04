using DataStructures.Core.Arrays;

namespace DataStructures.Console.Extensions;

public static class ArrayListExtensions
{
    public static void Display<T>(this ArrayList<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            System.Console.Write($"{list.Get(i)} ");
        }
        System.Console.WriteLine();
    }

    public static void DisplayReverse<T>(this ArrayList<T> list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            System.Console.Write($"{list.Get(i)} ");
        }
        System.Console.WriteLine();
    }
}