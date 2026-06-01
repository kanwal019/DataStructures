using System;
using System.Runtime.InteropServices;

namespace DataStructures.Console.Implementation;

public class Strings
{
    private static string str = "Hello, World!";

    public static void DisplayResult()
    {
        System.Console.WriteLine($"Original String: {str}");
        System.Console.WriteLine($"Length: {str.Length}");
        System.Console.WriteLine($"Uppercase: {str.ToUpper()}");
        System.Console.WriteLine($"Lowercase: {str.ToLower()}");
        System.Console.WriteLine($"Substring (0, 5): {str.Substring(0, 5)}");
        System.Console.WriteLine($"Contains 'World': {str.Contains("World")}");
        System.Console.WriteLine($"Index of 'o': {str.IndexOf('o')}");
        System.Console.WriteLine($"Replace 'World' with 'C#': {str.Replace("World", "C#")}");
    }

    public static void DisplayImmutabilityResult()
    {
        // This will create a new sytring as the string is immutable
        str = "The number to be parsed is: 123";
        string num = str[(str.IndexOf(':') + 2)..];

        if (int.TryParse(num, out int parsedNumber))
        {
            System.Console.WriteLine($"Parsed Number: {parsedNumber}");
        }
        else
        {
            System.Console.WriteLine("Failed to parse the number.");
        }

        // This will not create a new string as the ReadOnlySpan<T> is a stack-only type
        ReadOnlySpan<char> span = str;
        ReadOnlySpan<char> spanNum = span[(span.IndexOf(':') + 2)..];
        if (int.TryParse(spanNum, out parsedNumber))
        {
            System.Console.WriteLine($"Parsed Number: {parsedNumber}");
        }
        else
        {
            System.Console.WriteLine("Failed to parse the number.");
        }
    }
}
