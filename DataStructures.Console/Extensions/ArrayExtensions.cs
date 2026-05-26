namespace DataStructures.Console.Extensions;

public static class ArrayExtensions
{
    public static void Display<T>(this T[] array)
    {
        foreach (T item in array)
        {
            System.Console.Write($"{item} ");
        }
        System.Console.WriteLine();
    }

    public static void DisplayReverse<T>(this T[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            System.Console.Write($"{array[i]} ");
        }
        System.Console.WriteLine();
    }
}
