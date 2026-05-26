using System;
using System.Linq;

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

    public static void DisplayMetadata<T>(this T[,] array) => System.Console.WriteLine($"Length: {array.Length}, Rows: {array.GetLength(0)}, Columns: {array.GetLength(1)}");

    public static void Display<T>(this T[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write($"{array[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }

    public static void DisplayMetadata<T>(this T[][] array)
    {
        System.Console.WriteLine($"Rows: {array.Length}, " +
            $"Min Columns: {(array.Length > 0 ? array.Min(r => r.Length) : 0)}, " +
            $"Max Columns: {(array.Length > 0 ? array.Max(r => r.Length) : 0)}");
    }

    public static void Display<T>(this T[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                System.Console.Write($"{array[i][j]} ");
            }
            System.Console.WriteLine();
        }
    }

    public static void DisplayReverse<T>(this T[][] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            for (int j = array[i].Length - 1; j >= 0; j--)
            {
                System.Console.Write($"{array[i][j]} ");
            }
            System.Console.WriteLine();
        }
    }

    public static void DisplayRow<T>(this T[][] array, int rowIndex)
    {
        if (rowIndex < 0 || rowIndex >= array.Length)
            throw new ArgumentOutOfRangeException(nameof(rowIndex));

        array[rowIndex].Display();
    }
}