using System;
using System.Linq;
using System.Text;

namespace DataStructures.Console.Implementation;

public class Strings
{
    private const string Greeting = "Hello, World!";

    public static void DisplayResult()
    {
        string str = Greeting;
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
        const string str = "The number to be parsed is: 123";
        // Slicing a string creates a new string.
        string num = str[(str.IndexOf(':') + 2)..];

        if (int.TryParse(num, out int parsedNumber))
        {
            System.Console.WriteLine($"Parsed Number: {parsedNumber}");
        }
        else
        {
            System.Console.WriteLine("Failed to parse the number.");
        }

        // Slicing a span reads the existing characters without allocating a string.
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

    public static void DisplayMemoryStringResult()
    {
        string firstString = "Test string";
        string secondString = "Test string";

        // Prints out true, because both strings are interned and reference the same object in memory
        System.Console.WriteLine(object.ReferenceEquals(firstString, secondString));

        // Copy into a mutable buffer; the interned strings remain unchanged.
        Memory<char> mem = firstString.ToCharArray();
        mem.Span[5] = 'Z';

        System.Console.WriteLine($"Modified String: {mem}");
        System.Console.WriteLine(firstString);
        System.Console.WriteLine(secondString);
    }

    public static void DisplayStringBuilderResult()
    {
        var sb = new StringBuilder();
        foreach (int i in Enumerable.Range(1, 20))
        {
            // StringBuilder is mutable, so we can modify it without creating a new object
            sb.Append(i).Append(',');
        }
        System.Console.WriteLine(sb.ToString());
    }
}
