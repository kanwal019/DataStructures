using System;
using System.Collections;

namespace DataStructures.Console.Implementation;

public static class BitArrayImplementation
{
    public static void DisplayResult()
    {
        ReadOnlySpan<byte> bytes = [0b_0000_0011, 0b_1000_0000];
        var bits = new BitArray(bytes);

        // Compare a hand-written count with .NET 11's built-in operation.
        int manualCount = 0;
        foreach (bool bit in bits)
        {
            if (bit)
                manualCount++;
        }

        System.Console.WriteLine($"Bit count: {bits.Length}");
        System.Console.WriteLine($"Set bits (manual): {manualCount}");
        System.Console.WriteLine($"Set bits (PopCount): {bits.PopCount()}");
    }
}
