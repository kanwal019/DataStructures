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
}
